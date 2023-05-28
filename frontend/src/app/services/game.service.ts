import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Topic } from './topic.service';
import { environment } from 'src/environments/environment';
import { tap } from 'rxjs/operators';

export type GuessResult = {
    original: string;
    guess: string;
    correct: boolean;
    translations?: string[];
};

export type GuessResults = GuessResult[];

type ApiGuesses = { WordId: string; Original: string; Guess: string }[];

type WordObject = {
    id: string;
    word: string;
};

@Injectable({
    providedIn: 'root',
})
export class GameService {
    maxTimeSeconds = 30;
    timeRemaining!: number;
    topic!: Topic | undefined;
    words!: WordObject[];
    guesses!: string[];
    results!: GuessResults;
    private interval!: any;
    private _phase!: 'pending' | 'playing' | 'submitting' | 'finished';

    public get phase(): typeof this._phase {
        return this._phase;
    }

    private set phase(value: typeof this._phase) {
        this._phase = value;
    }

    constructor(private http: HttpClient) {
        this.reset();
    }

    reset() {
        clearInterval(this.interval);
        this.phase = 'finished';
        this.topic = undefined;
        this.timeRemaining = this.maxTimeSeconds;
        this.words = [];
        this.guesses = [];
        this.results = [];
    }

    startGame(topic: Topic) {
        this.reset();
        this.topic = topic;

        return this.getWords().subscribe((words) => {
            this.words = words;
            this.interval = setInterval(this.timerTick.bind(this), 1000);
            this.guesses = Array(this.words.length).fill('');
            this.phase = 'playing';
        });
    }

    endGame() {
        clearInterval(this.interval);
        this.phase = 'submitting';

        const guessesToApi: ApiGuesses = this.words.map((wordObject, idx) => {
            const guess = this.guesses[idx];

            return {
                WordId: wordObject.id || 'SKIPPED',
                Original: wordObject.word || 'SKIPPED',
                Guess: guess !== undefined ? guess : '',
            };
        });

        const headers = { 'Content-Type': 'application/json' };

        return this.http
            .post<GuessResults>(environment.apiUrl + 'Game/EndGame', guessesToApi, { headers })
            .pipe(
                tap((results: GuessResults) => {
                    this.results = results;
                    this.phase = 'finished';
                })
            );
    }

    private getWords() {
        const headers = { 'Content-Type': 'application/json' };
        const body = [this.topic?.id];

        return this.http
            .post<WordObject[]>(environment.apiUrl + 'Game/StartGameWeighted', body, { headers })
            .pipe(
                tap((words: WordObject[]) => {
                    this.words = words.map((wordObject: WordObject) => ({
                        id: wordObject.id,
                        word: wordObject.word,
                    }));
                })
            );
    }

    private timerTick() {
        if (this.timeRemaining <= 0) {
            this.endGame().subscribe();
        } else {
            this.timeRemaining = Math.max(0, this.timeRemaining - 1);
        }
    }
}

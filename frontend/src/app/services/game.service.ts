import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Topic } from './topic.service';
import { environment } from 'src/environments/environment';

export type GuessResult = {
    original: string;
    guess: string;
    correct: boolean;
    translations?: string[];
};

export type GuessResults = GuessResult[];

type ApiGuesses = { original: string; guess: string }[];

@Injectable({
    providedIn: 'root',
})
export class GameService {
    /** The maximum time the player might take during the game to enter their guesses. */
    maxTimeSeconds = 30;

    /** Time remaining in the current game */
    timeRemaining!: number;

    /** The topic of the current game. */
    topic!: Topic | undefined;

    /** The words provided by the API */
    words!: string[];

    /** The guesses entered by the user. */
    guesses!: string[];

    results!: GuessResults;

    /** The interval used by the timer. */
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

    /** Resets everything. */
    reset() {
        clearInterval(this.interval);
        this.phase = 'finished';
        this.phase = 'pending';
        this.topic = undefined;
        this.timeRemaining = this.maxTimeSeconds;
        this.words = [];
        this.guesses = [];
        this.results = [];
    }

    /** Starts the game in the given topic.
     * @param topic The topic of the game
     */
    startGame(topic: Topic) {
        this.reset();

        this.topic = topic;

        return this.getWords().subscribe((words) => {
            this.words = words;

            this.interval = setInterval(this.timerTick.bind(this), 1000);

            // Filling up the guesses with blank strings
            this.guesses = Array(this.words.length).fill('');
            this.phase = 'playing';
        });
    }

    /** Ends the game and submits the guesses to the API. */
    endGame() {
        clearInterval(this.interval);
        this.phase = 'submitting';
/*
        // TODO remove this
        this.results = this.guesses.map((guess, index) => {
            return {
                original: this.words[index],
                guess: guess,
                correct: Boolean(Math.round(Math.random())),
                translations: ['Correct solution', 'Other solution'],
            };
        });
        this.phase = 'finished';
*/
        // TODO uncomment

        this.submitGuesses().subscribe((results) => {
            this.results = results;
            this.phase = 'finished';
        });

    }

    private getWords() {
        const headers = { 'Content-Type': 'application/json' };
        const body = [this.topic?.id];

        return this.http.post<string[]>(
            environment.apiUrl + 'Game/StartGameWeighted',
            body,
            { headers }
        );
    }

    /** This function is called every second to decrement the timer. */
    private timerTick() {
        if (this.timeRemaining <= 0) {
            this.endGame();
        } else this.timeRemaining = Math.max(0, this.timeRemaining - 1);
    }

    private submitGuesses() {
        if (this.topic == undefined || this.words.length === 0)
            throw new Error('Something went wrong.');

        const guessesToApi: ApiGuesses = this.words.map((word, idx) => {
            return { original: word, guess: this.guesses[idx] };
        });

        const headers = { 'Content-Type': 'application/json' };

        return this.http.post<GuessResults>(
            environment.apiUrl + 'Game/EndGame',
            guessesToApi,
            { headers }
        );
    }
}

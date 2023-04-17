import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Topic } from './topic.service';
import { environment } from 'src/environments/environment';

export type Word = {
    original: string;
    id: string;
    translation: string;
};

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
        this.phase = 'pending';
        this.topic = undefined;
        this.timeRemaining = this.maxTimeSeconds;
        this.words = [];
        this.guesses = [];
    }

    /** Starts the game in the given topic.
     * @param topic The topic of the game
     */
    startGame(topic: Topic) {
        this.reset();

        this.topic = topic;

        this.getWords().subscribe((words) => {
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

        this.submitGuesses();

        this.phase = 'finished';
    }

    private getWords() {
        const headers = { 'Content-Type': 'application/json' };
        const body = [this.topic?.id];
        console.log(environment.apiUrl + 'Word/StartGame');

        return this.http.post<string[]>(
            environment.apiUrl + 'Word/StartGame',
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

    private async submitGuesses() {
        if (this.topic == undefined || this.words.length === 0)
            throw new Error('Something went wrong.');

        const guessesToApi: ApiGuesses = this.words.map((word, idx) => {
            return { original: word, guess: this.guesses[idx] };
        });

        // TODO Submit to API
        console.log(guessesToApi);
    }
}

type ApiGuesses = { original: string; guess: string }[];

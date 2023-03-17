import { Injectable } from '@angular/core';
import { Topic } from './topic.service';
import { WordsService } from './words.service';

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

    constructor(private wordService: WordsService) {
        this.reset();
    }

    /** Resets everything. */
    reset() {
        this.phase = 'pending';
        this.topic = undefined;
        this.timeRemaining = this.maxTimeSeconds;
        this.words = [];
        this.guesses = [];
    }

    /**
     * Starts the game in the given topic.
     * @param topic The topic of the game
     */
    startGame(topic: Topic) {
        this.reset();

        this.topic = topic;
        this.interval = setInterval(this.timerTick.bind(this), 1000);

        this.words = this.wordService.getRandomWords(topic);

        // Filling up the guesses with blank strings
        this.guesses = Array(this.words.length).fill('');
        this.phase = 'playing';
    }

    /** Ends the game and submits the guesses to the API. */
    endGame() {
        clearInterval(this.interval);
        this.phase = 'submitting';
        this.topic = undefined;

        // TODO submit
        this.phase = 'finished';
    }

    /** This function is called every second to decrement the timer. */
    private timerTick() {
        if (this.timeRemaining <= 0) {
            this.endGame();
        } else this.timeRemaining = Math.max(0, this.timeRemaining - 1);
    }
}

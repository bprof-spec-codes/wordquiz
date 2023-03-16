import { Injectable } from '@angular/core';
import { Topic } from './topic.service';
import { WordsService } from './words.service';

@Injectable({
    providedIn: 'root',
})
export class GameService {
    maxTimeSeconds = 30;
    timeRemaining = this.maxTimeSeconds;
    interval!: any;

    words!: string[];
    guesses!: string[];

    private _phase!: 'pending' | 'playing' | 'submitting' | 'finished';
    public get phase(): typeof this._phase {
        return this._phase;
    }
    private set phase(value: typeof this._phase) {
        this._phase = value;
    }

    constructor(private wordService: WordsService) {
        this.phase = 'pending'; // TODO change back to pending
    }

    startGame(topic: Topic) {
        this.timeRemaining = this.maxTimeSeconds;
        this.interval = setInterval(this.timerTick.bind(this), 1000);

        this.words = this.wordService.getRandomWords(topic);
        this.guesses = [];
        this.words.forEach((w) => this.guesses.push(''));
        this.phase = 'playing';
    }

    endGame() {
        clearInterval(this.interval);
        this.phase = 'submitting';

        // TODO submit
        this.phase = 'finished';
    }

    private timerTick() {
        if (this.timeRemaining <= 0) {
            this.endGame();
        } else this.timeRemaining = Math.max(0, this.timeRemaining - 1);
    }
}

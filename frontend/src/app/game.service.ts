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

    constructor(private wordService: WordsService) {}

    startGame(topic: Topic) {
        this.interval = setInterval(this.timerTick.bind(this), 1000);

        this.words = this.wordService.getRandomWords(topic);
    }

    private timerTick() {
        this.timeRemaining = Math.max(0, this.timeRemaining - 1);
    }
}

import { Component, SimpleChange, SimpleChanges } from '@angular/core';
import { NgForm, NgModel } from '@angular/forms';
import { Topic, TopicService } from '../topic.service';

import { ActivatedRoute } from '@angular/router';
import { GameService } from '../game.service';

@Component({
    selector: 'app-game',
    templateUrl: './game.component.html',
    styleUrls: ['./game.component.scss'],
})
export class GameComponent {
    topic!: Topic | undefined;

    activeWord!: number;

    currentGuess!: string;

    /**
     *
     */
    constructor(
        private route: ActivatedRoute,
        private topicService: TopicService,
        public gameService: GameService
    ) {}

    ngOnInit() {
        const routeParams = this.route.snapshot.paramMap;
        const topicIdFromRoute = String(routeParams.get('topicId'));

        this.topic = this.topicService
            .getAll()
            .find((t) => t.id == topicIdFromRoute);
    }

    onStartClicked() {
        this.activeWord = 0;
        this.gameService.startGame(this.topic!);
        console.log(this.gameService.phase);
    }

    onNextClicked() {
        this.activeWord = Math.min(
            this.gameService.words.length - 1,
            this.activeWord + 1
        );
        console.log(this.currentGuess);
    }

    onPrevClicked() {
        this.activeWord = Math.max(0, this.activeWord - 1);
    }

    onSubmitClicked() {}
}

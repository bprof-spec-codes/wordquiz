import {
    Component,
    ElementRef,
    SimpleChange,
    SimpleChanges,
    ViewChild,
} from '@angular/core';
import { NgForm, NgModel } from '@angular/forms';
import { Topic, TopicService } from '../../services/topic.service';

import { ActivatedRoute } from '@angular/router';
import { GameService } from '../../services/game.service';
import { NgbProgressbarModule } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-game',
    templateUrl: './game.component.html',
    styleUrls: ['./game.component.scss'],
})
export class GameComponent {
    topic!: Topic;

    activeWord!: number;

    currentGuess!: string;

    @ViewChild('guessBox') guessBox!: ElementRef;

    /**
     *
     */
    constructor(
        private route: ActivatedRoute,
        private topicService: TopicService,
        public gameService: GameService
    ) {}

    ngOnInit() {
        this.gameService.reset();

        const routeParams = this.route.snapshot.paramMap;
        const topicIdFromRoute = String(routeParams.get('topicId'));

        this.topicService
            .getOne(topicIdFromRoute)
            .subscribe((topic) => (this.topic = topic));
    }

    /** Handles the event when the start button has been clicked. */
    onStartClicked() {
        this.activeWord = 0;

        this.gameService.startGame(this.topic!).add(() => {
            setTimeout(() => {
                this.guessBox.nativeElement.value = '';
                this.guessBox.nativeElement.focus();
            }, 20);
        });
    }

    /** Handles the event when the next button has been clicked. */
    onNextClicked() {
        if (this.activeWord == this.gameService.words.length - 1)
            this.onSubmitClicked();

        this.activeWord = Math.min(
            this.gameService.words.length - 1,
            this.activeWord + 1
        );
        this.loadGuess();
        this.guessBox.nativeElement.focus();
    }

    /** Handles the event when the previous button has been clicked. */
    onPrevClicked() {
        this.activeWord = Math.max(0, this.activeWord - 1);
        this.loadGuess();
        this.guessBox.nativeElement.focus();
    }

    /** Stores the current guess. */
    saveGuess() {
        this.gameService.guesses[this.activeWord] = this.currentGuess.trim();
    }

    /** Loads a guess into the current guess */
    loadGuess() {
        this.currentGuess = this.gameService.guesses[this.activeWord];
    }

    onSubmitClicked() {
        this.gameService.endGame();
    }

    get completionPercentage() {
        return (this.completedWords / this.gameService.words.length) * 100;
    }

    get completedWords() {
        return this.gameService.guesses.filter((g) => g !== '').length;
    }

    onGuessKeydown() {
        this.saveGuess();
    }
}

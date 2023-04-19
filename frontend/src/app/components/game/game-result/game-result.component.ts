import { Component, EventEmitter, Input, Output } from '@angular/core';

import { GameService } from 'src/app/services/game.service';

@Component({
    selector: 'app-game-result',
    templateUrl: './game-result.component.html',
    styleUrls: ['./game-result.component.scss'],
})
export class GameResultComponent {
    @Output() restartClicked = new EventEmitter();

    get correctAnswers() {
        return this.gameService.results.filter((r) => r.correct).length;
    }

    /**
     *
     */
    constructor(public gameService: GameService) {}
}

import { Component, EventEmitter, Input, Output } from '@angular/core';

import { ActivatedRoute } from '@angular/router';
import { GameService } from 'src/app/services/game.service';
import { RouterModule } from '@angular/router';
import { Topic } from '../../../services/topic.service';

@Component({
    selector: 'app-game-start',
    templateUrl: './game-start.component.html',
    styleUrls: ['./game-start.component.scss'],
})
export class GameStartComponent {
    @Input() topic!: Topic;
    @Output() startClicked = new EventEmitter();

    /**
     *
     */
    constructor(public gameService: GameService) {}

    onStartClicked() {
        // TODO
    }
}

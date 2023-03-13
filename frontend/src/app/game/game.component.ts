import { Topic, TopicService } from '../topic.service';

import { ActivatedRoute } from '@angular/router';
import { Component } from '@angular/core';
import { GameService } from '../game.service';

@Component({
    selector: 'app-game',
    templateUrl: './game.component.html',
    styleUrls: ['./game.component.scss'],
})
export class GameComponent {
    topic!: Topic | undefined;

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
}

import { Topic, TopicService } from '../topic.service';

import { ActivatedRoute } from '@angular/router';
import { Component } from '@angular/core';
import { WordsService } from '../words.service';

@Component({
    selector: 'app-topic-details',
    templateUrl: './topic-details.component.html',
    styleUrls: ['./topic-details.component.scss'],
})
export class TopicDetailsComponent {
    topic!: Topic | undefined;

    wordBank!: { [key: string]: string };

    /**
     *
     */
    constructor(
        private route: ActivatedRoute,
        private topicService: TopicService,
        public wordService: WordsService
    ) {}

    ngOnInit() {
        const routeParams = this.route.snapshot.paramMap;
        const topicIdFromRoute = String(routeParams.get('topicId'));

        this.topic = this.topicService
            .getAll()
            .find((t) => t.id == topicIdFromRoute);

        if (this.topic)
            this.wordBank = this.wordService.getAllFromTopic(this.topic);
    }
}

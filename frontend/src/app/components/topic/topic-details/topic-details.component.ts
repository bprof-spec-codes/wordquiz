import { Topic, TopicService } from '../../../services/topic.service';

import { ActivatedRoute } from '@angular/router';
import { Component } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-topic-details',
    templateUrl: './topic-details.component.html',
    styleUrls: ['./topic-details.component.scss'],
})
export class TopicDetailsComponent {
    topic!: Observable<Topic>;

    /**
     *
     */
    constructor(
        private route: ActivatedRoute,
        private topicService: TopicService
    ) {}

    ngOnInit() {
        const routeParams = this.route.snapshot.paramMap;
        const topicIdFromRoute = String(routeParams.get('topicId'));

        this.topic = this.topicService.getOne(topicIdFromRoute);
    }
}

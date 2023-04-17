import { Topic, TopicService } from '../../../services/topic.service';

import { Component } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-topic-selection',
    templateUrl: './topic-selection.component.html',
    styleUrls: ['./topic-selection.component.scss'],
})
export class TopicSelectionComponent {
    topics!: Observable<Topic[]>;

    /**
     *
     */
    constructor(private topicService: TopicService) {}

    ngOnInit() {
        this.topics = this.topicService.getAll();
    }
}

import { Component } from '@angular/core';
import { TopicService } from 'src/app/services/topic.service';

@Component({
    selector: 'app-admin-topic-details',
    templateUrl: './admin-topic-details.component.html',
    styleUrls: ['./admin-topic-details.component.scss'],
})
export class AdminTopicDetailsComponent {
    constructor(topicService: TopicService) {}
}

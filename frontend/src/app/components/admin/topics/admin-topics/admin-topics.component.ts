import { Component, OnInit } from '@angular/core';
import { Topic, TopicService } from 'src/app/services/topic.service';

import { Observable } from 'rxjs';

@Component({
    selector: 'app-admin-topics',
    templateUrl: './admin-topics.component.html',
    styleUrls: ['./admin-topics.component.scss'],
})
export class AdminTopicsComponent implements OnInit {
    topics!: Observable<Topic[]>;

    constructor(public topicService: TopicService) {}

    ngOnInit() {
        this.topics = this.topicService.getAll();
    }
}

import { Component, OnInit } from '@angular/core';
import { Topic, TopicService } from '../../services/topic.service';

import { Observable } from 'rxjs';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
    topics!: Observable<Topic[]>;
    layout!: null;
    topicCount!: number;

    constructor(private topicService: TopicService) {
        this.topicService.getAll().subscribe((data) => {
            this.topicCount = data.length;
        });
    }

    ngOnInit() {
        this.topics = this.topicService.getAll();
    }
}

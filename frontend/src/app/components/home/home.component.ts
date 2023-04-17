import { Topic, TopicService } from '../../services/topic.service';

import { Component } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
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

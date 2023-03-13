import { Topic, TopicService } from '../topic.service';

import { Component } from '@angular/core';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
    topics!: Topic[];
    layout!: null;

    constructor(private topicService: TopicService) {}

    ngOnInit() {
        this.topics = this.topicService.getAll();
    }
}

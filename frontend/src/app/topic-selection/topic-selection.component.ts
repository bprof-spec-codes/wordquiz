import { Topic, TopicService } from '../topic.service';

import { Component } from '@angular/core';

@Component({
  selector: 'app-topic-selection',
  templateUrl: './topic-selection.component.html',
  styleUrls: ['./topic-selection.component.scss'],
})
export class TopicSelectionComponent {
  topics!: Topic[];

  /**
   *
   */
  constructor(private topicService: TopicService) {}

  ngOnInit() {
    this.topics = this.topicService.getAll();
  }
}

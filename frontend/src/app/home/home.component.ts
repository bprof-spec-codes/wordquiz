import { Component } from '@angular/core';
import { TopicService } from '../topic.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  topics!: string[];

  constructor(private topicService: TopicService) {}

  ngOnInit() {
    this.topics = this.topicService.getAll();
  }
}

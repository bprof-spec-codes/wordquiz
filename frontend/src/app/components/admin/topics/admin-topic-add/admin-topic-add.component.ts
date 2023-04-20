import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { TopicService } from 'src/app/services/topic.service';

@Component({
    selector: 'app-admin-topic-add',
    templateUrl: './admin-topic-add.component.html',
    styleUrls: ['./admin-topic-add.component.scss'],
})
export class AdminTopicAddComponent {
    addForm = this.formBuilder.group({
        title: [''],
        description: [''],
    });

    constructor(
        private formBuilder: FormBuilder,
        public topicService: TopicService,
        private router: Router
    ) {}

    onAddTopic() {
        this.topicService
            .create({
                title: this.addForm.value.title!,
                description: this.addForm.value.description!,
            })
            .subscribe(() => {
                this.router.navigate(['/admin/topics']);
            });
    }
}

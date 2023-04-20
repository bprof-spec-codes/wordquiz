import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Topic, TopicService } from 'src/app/services/topic.service';

import { ActivatedRoute } from '@angular/router';
import { FormBuilder } from '@angular/forms';
import { Observable } from 'rxjs';
import { WordService } from 'src/app/services/word.service';

@Component({
    selector: 'app-admin-topic-details',
    templateUrl: './admin-topic-details.component.html',
    styleUrls: ['./admin-topic-details.component.scss'],
})
export class AdminTopicDetailsComponent implements OnInit {
    topic!: Observable<Topic>;

    @ViewChild('originalBox') originalBox!: ElementRef;

    addForm = this.formBuilder.group({
        original: [''],
        translation: [''],
    });

    topicId!: string;

    constructor(
        private topicService: TopicService,
        private wordService: WordService,
        private formBuilder: FormBuilder,
        private route: ActivatedRoute
    ) {}

    ngOnInit(): void {
        const routeParams = this.route.snapshot.paramMap;
        this.topicId = String(routeParams.get('topicId'));
        this.refreshTopic();
    }

    onAddWord() {
        this.wordService
            .create({
                original: this.addForm.value.original!,
                translation: this.addForm.value.translation!,
                topicId: this.topicId,
            })
            .subscribe(() => {
                this.refreshTopic();
                this.addForm.setValue({ original: '', translation: '' });
                this.originalBox.nativeElement.focus();
            });
    }

    refreshTopic() {
        this.topic = this.topicService.getOne(this.topicId);
    }

    onDeleteClicked(id: string) {
        this.wordService.delete(id).subscribe(() => this.refreshTopic());
    }
}

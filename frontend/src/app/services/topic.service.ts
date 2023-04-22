import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Word } from './word.service';
import { environment } from 'src/environments/environment';

export type Topic = {
    title: string;
    description: string;
    id: string;
    words: Word[];
};

export type AddTopicBody = {
    title: string;
    description: string;
};

@Injectable({
    providedIn: 'root',
})
export class TopicService {
    constructor(private http: HttpClient) {}

    getAll() {
        return this.http.get<Topic[]>(environment.apiUrl + 'Topic');
    }

    getOne(id: string) {
        return this.http.get<Topic>(environment.apiUrl + 'Topic/' + id);
    }

    create(topic: AddTopicBody) {
        return this.http.post<Topic>(environment.apiUrl + 'Topic/', topic);
    }

    delete(id: string) {
        return this.http.delete<Topic>(environment.apiUrl + 'Topic/' + id);
    }
}

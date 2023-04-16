import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Word } from './game.service';
import { environment } from './../environments/environment';

export type Topic = {
    title: string;
    description: string;
    id: string;
    words: Word[];
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
}

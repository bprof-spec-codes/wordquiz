import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

export type Word = {
    original: string;
    id: string;
    translation: string;
};

type NewWordRequest = {
    original: string;
    translation: string;
    topicId: string;
};

@Injectable({
    providedIn: 'root',
})
export class WordService {
    constructor(private http: HttpClient) {}

    create(word: NewWordRequest) {
        return this.http.post<Word>(environment.apiUrl + 'Word/', word);
    }

    delete(id: string) {
        return this.http.delete<Word>(environment.apiUrl + 'Word/' + id);
    }
}

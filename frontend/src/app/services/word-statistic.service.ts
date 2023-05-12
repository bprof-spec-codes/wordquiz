import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
    providedIn: 'root',
})
export class WordStatisticService {
    private apiUrl = environment.apiUrl;

    constructor(private http: HttpClient) {}

    getWordStatistics(): Observable<any[]> {
        return this.http.get<any[]>(`${this.apiUrl}data/user/wordstatistics`);
    }
}

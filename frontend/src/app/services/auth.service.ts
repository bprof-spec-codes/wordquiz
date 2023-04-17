// Thanks to https://www.positronx.io/angular-jwt-user-authentication-tutorial/

import * as moment from 'moment';

import {
    HttpClient,
    HttpErrorResponse,
    HttpHeaders,
} from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';

export type User = {
    userName: string;
    email: string;
};

@Injectable({
    providedIn: 'root',
})
export class AuthService {
    headers = new HttpHeaders().set('Content-Type', 'application/json');
    currentUser: User | undefined = undefined;
    loading = false;
    constructor(private http: HttpClient, public router: Router) {}
    // Sign-up
    signUp(user: User): Observable<any> {
        let api = environment.apiUrl + 'player';
        return this.http.post(api, user).pipe(catchError(this.handleError));
    }
    // Sign-in
    signIn(user: { userName: string; password: string }) {
        return this.http
            .post<any>(environment.apiUrl + 'Auth', user)
            .subscribe((res: any) => {
                localStorage.setItem('access_token', res.token);
                return this.getUserProfile().subscribe((res) => {
                    this.currentUser = res;
                    this.router.navigate(['/']);
                });
            });
    }

    getToken() {
        return localStorage.getItem('access_token');
    }

    get isLoggedIn(): boolean {
        let authToken = localStorage.getItem('access_token');
        const isLoggedIn = authToken !== null ? true : false;

        if (isLoggedIn && !this.currentUser && !this.loading) {
            this.loading = true;
            this.getUserProfile().subscribe((res) => {
                this.currentUser = res;
            });
        }

        return isLoggedIn;
    }

    doLogout() {
        let removeToken = localStorage.removeItem('access_token');
        if (removeToken == null) {
            this.router.navigate(['/']);
        }
    }

    // User profile
    getUserProfile(): Observable<any> {
        let api = `${environment.apiUrl}Player`;
        return this.http.get(api, { headers: this.headers }).pipe(
            map((res) => {
                return res || {};
            }),
            catchError(this.handleError)
        );
    }

    // Error
    handleError(error: HttpErrorResponse) {
        let msg = '';
        if (error.error instanceof ErrorEvent) {
            // client-side error
            msg = error.error.message;
        } else {
            // server-side error
            msg = `Error Code: ${error.status}\nMessage: ${error.message}`;
        }
        return throwError(() => new Error(msg));
    }
}
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

import { AuthService } from 'src/app/services/auth.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
    loginForm = this.formBuilder.group({
        username: [''],
        password: [''],
    });

    /**
     *
     */
    constructor(
        private formBuilder: FormBuilder,
        public AuthService: AuthService,
        private router: Router
    ) {}

    ngOnInit() {
        if (this.AuthService.isLoggedIn) {
            this.router.navigate(['/']);
        }
    }

    login() {
        this.AuthService.signIn({
            userName: this.loginForm.value.username!,
            password: this.loginForm.value.password!,
        });
    }
}

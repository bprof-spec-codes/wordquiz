import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

import { AuthService } from '../shared/auth.service';

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
        public AuthService: AuthService
    ) {}

    ngOnInit() {}

    login() {
        this.AuthService.signIn({
            userName: this.loginForm.value.username!,
            password: this.loginForm.value.password!,
        }).add(() => {
            console.log(this.AuthService.currentUser);
        });
    }
}

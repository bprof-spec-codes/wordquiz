import { AuthService, User } from 'src/app/services/auth.service';
import { Component, OnInit } from '@angular/core';

import { Location } from '@angular/common';

@Component({
    selector: 'app-navbar',
    templateUrl: './navbar.component.html',
    styleUrls: ['./navbar.component.scss'],
})
export class NavbarComponent {
    constructor(public authService: AuthService) {}

    logout() {
        this.authService.doLogout();
    }
}

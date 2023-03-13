import { Component } from '@angular/core';
import { Location } from '@angular/common';

@Component({
    selector: 'app-navbar',
    templateUrl: './navbar.component.html',
    styleUrls: ['./navbar.component.scss'],
})
export class NavbarComponent {
    __URL: string = '';

    /**
     *
     */
    constructor(private location: Location) {}

    ngOnInit() {
        this.__URL = this.location.path();
        console.log(this.__URL);
    }
}

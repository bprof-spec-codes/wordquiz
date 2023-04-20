import {
    ActivatedRouteSnapshot,
    CanActivate,
    Router,
    RouterStateSnapshot,
    UrlTree,
} from '@angular/router';

import { AuthService } from '../services/auth.service';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root',
})
export class AdminGuard implements CanActivate {
    constructor(public authService: AuthService, public router: Router) {}

    canActivate(
        route: ActivatedRouteSnapshot,
        state: RouterStateSnapshot
    ):
        | Observable<boolean | UrlTree>
        | Promise<boolean | UrlTree>
        | boolean
        | UrlTree {
        if (
            this.authService.isLoggedIn !== true ||
            !this.authService.currentUser ||
            this.authService.currentUser.admin
        ) {
            this.router.navigate(['/']);
        }
        return true;
    }
}

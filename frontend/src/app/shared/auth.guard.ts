import {
    ActivatedRouteSnapshot,
    CanActivate,
    Router,
    RouterStateSnapshot,
    UrlTree,
} from '@angular/router';
import { Injectable, inject } from '@angular/core';

import { AuthService } from '../services/auth.service';
import { Observable } from 'rxjs';

export const AuthGuard = (
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
) => {
    const authService = inject(AuthService);
    const router = inject(Router);
    if (authService.isLoggedIn !== true) {
        router.navigate(['user/login']);
    }
    return true;
};

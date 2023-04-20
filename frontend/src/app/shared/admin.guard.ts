import {
    ActivatedRouteSnapshot,
    CanActivate,
    Router,
    RouterStateSnapshot,
    UrlTree,
} from '@angular/router';
import { Injectable, inject } from '@angular/core';
import { Observable, firstValueFrom } from 'rxjs';

import { AuthService } from '../services/auth.service';

export const AdminGuard = async (
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
) => {
    const authService = inject(AuthService);
    const router = inject(Router);

    const isAdmin = await firstValueFrom(authService.getUserProfile()).then(
        (user) => !!user && user.admin
    );

    if (!isAdmin) {
        console.log('Unauthorized');
        router.navigate(['/']);
    }

    return true;
};

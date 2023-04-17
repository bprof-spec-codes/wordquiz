import { RouterModule, Routes } from '@angular/router';

import { AuthGuard } from './shared/auth.guard';
import { GameComponent } from './game/game.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { NgModule } from '@angular/core';
import { TopicDetailsComponent } from './topic-details/topic-details.component';
import { TopicSelectionComponent } from './topic-selection/topic-selection.component';

const routes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'topics', component: TopicSelectionComponent },
    { path: 'topics/:topicId', component: TopicDetailsComponent },

    { path: 'user/login', component: LoginComponent },

    {
        path: 'play/:topicId',
        component: GameComponent,
        canActivate: [AuthGuard],
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}

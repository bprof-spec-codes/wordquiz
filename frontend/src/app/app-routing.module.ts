import { RouterModule, Routes } from '@angular/router';

import { AdminGuard } from './shared/admin.guard';
import { AdminTopicAddComponent } from './components/admin/topics/admin-topic-add/admin-topic-add.component';
import { AdminTopicDetailsComponent } from './components/admin/topics/admin-topic-details/admin-topic-details.component';
import { AdminTopicsComponent } from './components/admin/topics/admin-topics/admin-topics.component';
import { AuthGuard } from './shared/auth.guard';
import { DataImportExportComponent } from './components/data-import-export/data-import-export.component';
import { GameComponent } from './components/game/game.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/user/login/login.component';
import { NgModule } from '@angular/core';
import { RegisterComponent } from './components/user/register/register.component';
import { TopicDetailsComponent } from './components/topic/topic-details/topic-details.component';
import { TopicSelectionComponent } from './components/topic/topic-selection/topic-selection.component';
import { WordStatisticsComponent } from './components/word-statistics/word-statistics.component';

const routes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'topics', component: TopicSelectionComponent },
    { path: 'topics/:topicId', component: TopicDetailsComponent },

    { path: 'user/login', component: LoginComponent },
    { path: 'user/register', component: RegisterComponent },

    {
        path: 'play/:topicId',
        component: GameComponent,
        canActivate: [AuthGuard],
    },

    {
        path: 'admin/topics',
        component: AdminTopicsComponent,
        canActivate: [AuthGuard, AdminGuard],
    },

    {
        path: 'admin/topics/add',
        component: AdminTopicAddComponent,
        canActivate: [AuthGuard, AdminGuard],
    },

    {
        path: 'admin/topics/:topicId',
        component: AdminTopicDetailsComponent,
        canActivate: [AuthGuard, AdminGuard],
    },
    {
        path: 'data-import-export',
        component: DataImportExportComponent,
        canActivate: [AuthGuard, AdminGuard],
    },
    {
        path: 'word-statistics',
        component: WordStatisticsComponent,
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}

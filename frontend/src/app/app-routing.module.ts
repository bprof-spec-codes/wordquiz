import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';
import { TopicSelectionComponent } from './topic-selection/topic-selection.component';

const routes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'topics', component: TopicSelectionComponent },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule {}

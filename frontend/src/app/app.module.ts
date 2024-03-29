import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';

import { AdminTopicAddComponent } from './components/admin/topics/admin-topic-add/admin-topic-add.component';
import { AdminTopicDetailsComponent } from './components/admin/topics/admin-topic-details/admin-topic-details.component';
import { AdminTopicsComponent } from './components/admin/topics/admin-topics/admin-topics.component';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { AuthInterceptor } from '../app/shared/authconfig.interceptor';
import { BrowserModule } from '@angular/platform-browser';
import { DataImportExportComponent } from './components/data-import-export/data-import-export.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { GameComponent } from './components/game/game.component';
import { GameResultComponent } from './components/game/game-result/game-result.component';
import { GameStartComponent } from './components/game/game-start/game-start.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/user/login/login.component';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { NgChartsModule } from 'ng2-charts';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RegisterComponent } from './components/user/register/register.component';
import { RouterModule } from '@angular/router';
import { SecondaryRegionComponent } from './components/shared/secondary-region/secondary-region.component';
import { TopicDetailsComponent } from './components/topic/topic-details/topic-details.component';
import { TopicSelectionComponent } from './components/topic/topic-selection/topic-selection.component';
import { WordStatisticsComponent } from './components/word-statistics/word-statistics.component';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        NavbarComponent,
        SecondaryRegionComponent,
        FooterComponent,
        TopicSelectionComponent,
        GameComponent,
        TopicDetailsComponent,
        LoginComponent,
        RegisterComponent,
        GameResultComponent,
        GameStartComponent,
        AdminTopicsComponent,
        AdminTopicDetailsComponent,
        AdminTopicAddComponent,
        DataImportExportComponent,
        WordStatisticsComponent,
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        NgbModule,
        FormsModule,
        ReactiveFormsModule,
        HttpClientModule,
        MatSelectModule,
        MatButtonModule,
        MatInputModule,
        MatIconModule,
        MatFormFieldModule,
        NgChartsModule,
        RouterModule,
    ],
    providers: [
        {
            provide: HTTP_INTERCEPTORS,
            useClass: AuthInterceptor,
            multi: true,
        },
    ],
    bootstrap: [AppComponent],
})
export class AppModule {}

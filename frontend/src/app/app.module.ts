import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { AuthInterceptor } from '../app/shared/authconfig.interceptor.ts';
import { BrowserModule } from '@angular/platform-browser';
import { FooterComponent } from './components/shared/footer/footer.component';
import { GameComponent } from './components/game/game.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/user/login/login.component';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RegisterComponent } from './components/user/register/register.component';
import { RouterModule } from '@angular/router';
import { SecondaryRegionComponent } from './components/shared/secondary-region/secondary-region.component';
import { TopicDetailsComponent } from './components/topic/topic-details/topic-details.component';
import { TopicSelectionComponent } from './components/topic/topic-selection/topic-selection.component';

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
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        NgbModule,
        FormsModule,
        ReactiveFormsModule,
        HttpClientModule,
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

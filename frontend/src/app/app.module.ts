import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { FooterComponent } from './footer/footer.component';
import { FormsModule } from '@angular/forms';
import { GameComponent } from './game/game.component';
import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './navbar/navbar.component';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';
import { SecondaryRegionComponent } from './secondary-region/secondary-region.component';
import { TopicDetailsComponent } from './topic-details/topic-details.component';
import { TopicSelectionComponent } from './topic-selection/topic-selection.component';

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
    ],
    imports: [BrowserModule, AppRoutingModule, NgbModule, FormsModule],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule {}

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { HomeComponent } from './home/home.component';
import { NavbarComponent } from './navbar/navbar.component';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SecondaryRegionComponent } from './secondary-region/secondary-region.component';
import { FooterComponent } from './footer/footer.component';
import { TopicSelectionComponent } from './topic-selection/topic-selection.component';

@NgModule({
  declarations: [AppComponent, HomeComponent, NavbarComponent, SecondaryRegionComponent, FooterComponent, TopicSelectionComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot([{ path: '', component: HomeComponent }]),
    NgbModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}

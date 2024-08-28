import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { StudentListPageComponent } from './student-list-page/student-list-page.component';
import { WelcomePageComponent } from './welcome-page/welcome-page.component';
import { CreatePageComponent } from './create-page/create-page.component';
import { AccountManagementPageComponent } from './account-management-page/account-management-page.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginPageComponent,
    StudentListPageComponent,
    WelcomePageComponent,
    CreatePageComponent,
    AccountManagementPageComponent,
    NavBarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

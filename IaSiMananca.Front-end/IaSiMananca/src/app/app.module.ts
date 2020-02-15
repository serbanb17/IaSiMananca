import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AboutComponent } from './components/about/about.component';
import { RestaurantsComponent } from './components/restaurants/restaurants.component';
import { DataService } from './shared/services/data.service';
import { HttpClientModule } from '@angular/common/http';
import { ContactComponent } from './components/contact/contact.component';
import { RestaurantDetailsComponent } from './components/restaurant-details/restaurant-details.component';
import { ErrorComponent } from './shared/components/error/error.component';
import { FormsModule } from '@angular/forms';
import { FilterPipeModule } from 'ngx-filter-pipe';
import { OrderModule } from 'ngx-order-pipe';
import { SortByPipe } from './shared/pipes/sort-by.pipe';
import { FilterPipe } from './shared/pipes/filter.pipe';
import { RestaurantDishComponent } from './components/restaurant-dish/restaurant-dish.component';
import { RestaurantDishDetailsComponent } from './components/restaurant-dish-details/restaurant-dish-details.component';
import { RestaurantPageComponent } from './components/restaurant-page/restaurant-page.component';
import { UpdateReviewComponent } from './components/update-review/update-review.component';
import { AddReviewComponent } from './components/add-review/add-review.component';
import { SearchComponent } from './components/search/search.component';
import { SignupComponent } from './components/signup/signup.component';
import { SignupSuccesfulComponent } from './components/signup-succesful/signup-succesful.component';
import { LoginComponent } from './components/login/login.component';
import { LoginSuccessfulComponent } from './components/login-successful/login-successful.component';


@NgModule({
  declarations: [
    AppComponent,
    AboutComponent,
    RestaurantsComponent,
    ContactComponent,
    RestaurantDetailsComponent,
    ErrorComponent,
    SortByPipe,
    FilterPipe,
    RestaurantDishComponent,
    RestaurantDishDetailsComponent,
    RestaurantPageComponent,
    UpdateReviewComponent,
    AddReviewComponent,
    SearchComponent,
    SignupComponent,
    SignupSuccesfulComponent,
    LoginComponent,
    LoginSuccessfulComponent

    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    FilterPipeModule,
    OrderModule,

  ],
  providers: [DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }

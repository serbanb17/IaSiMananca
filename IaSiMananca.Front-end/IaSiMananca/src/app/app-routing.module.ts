import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RestaurantsComponent } from './components/restaurants/restaurants.component';
import { RestaurantDetailsComponent } from './components/restaurant-details/restaurant-details.component';
import { AboutComponent } from './components/about/about.component';
import { ErrorComponent } from './shared/components/error/error.component';
import { ContactComponent } from './components/contact/contact.component';
import { RestaurantDishComponent } from './components/restaurant-dish/restaurant-dish.component';
import { RestaurantDishDetailsComponent} from './components/restaurant-dish-details/restaurant-dish-details.component';
import { RestaurantPageComponent } from './components/restaurant-page/restaurant-page.component';
import { UpdateReviewComponent } from './components/update-review/update-review.component';
import { AddReviewComponent } from './components/add-review/add-review.component';
import { SignupComponent } from './components/signup/signup.component';
import { LoginComponent } from './components/login/login.component';

import { SignupSuccesfulComponent } from './components/signup-succesful/signup-succesful.component';
import { SearchComponent } from './components/search/search.component';
import { LoginSuccessfulComponent } from './components/login-successful/login-successful.component';

const routes: Routes = [
  // {
//   path: '',
//   pathMatch: 'full',
//   redirectTo: 'restaurants'
// },
{
  path: 'restaurants',
  component: RestaurantsComponent
},
{
  path: 'restaurants/:id',
  component: RestaurantDetailsComponent
},
{
  path: 'about',
  component: AboutComponent
},
{
  path:'restaurantPage/:id',
  component: RestaurantPageComponent
},
{
  path: 'contact',
  component: ContactComponent
},
{
  path: "restaurant-dish",
  component: RestaurantDishComponent
},
{
  path: "restaurant-dish/:id",
  component: RestaurantDishDetailsComponent
},
{
  path: "add-review/:id",
  component: AddReviewComponent
},
{
  path: "update-review/:id",
  component: UpdateReviewComponent
  },
  {
    path: 'signup/:id',
    component: SignupComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
{
  path: 'signup/:id',
  component: SignupComponent
},
{
  path: 'login',
  component: LoginComponent
},
{
  path: 'signup-succesful',
  component: SignupSuccesfulComponent
},
{
  path: 'login-successful',
  component: LoginSuccessfulComponent
},
{
  path:'search',
  component:SearchComponent
},

{
  path: '**',
  component: ErrorComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

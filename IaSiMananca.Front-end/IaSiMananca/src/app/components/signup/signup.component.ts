import { Component, OnInit } from '@angular/core';
import { DataService } from '../../shared/services/data.service';
import { ActivatedRoute, Router } from '@angular/router';
import { RestaurantUser } from '../../shared/models/restaurantUser.model';

@Component({
  selector: 'ISM-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {

  id: string;
  restaurantUser: RestaurantUser;
  // restaurants: Restaurant[];
  addNewMode: boolean = false;

  constructor(private route: ActivatedRoute, private router: Router, private service: DataService) {
    this.route.params.subscribe((c) => {
      this.id = c['id'];

      if (this.id === 'addNew') {
        this.addNewMode = true;
        this.restaurantUser = new RestaurantUser();
      }

      if (!this.addNewMode) {
        this.service.get<RestaurantUser>('RestaurantUser/' + this.id)
          .subscribe(restaurantUser => {
            this.restaurantUser = restaurantUser;
          })
      }
      // this.getRestaurants();
    });
  }

  onSubmit() {
    if (this.addNewMode) {
      this.saveNewRestaurantUser();
    } else {
      this.updateRestaurantUser();
    }
  }

  private saveNewRestaurantUser() {
    this.service.post('RestaurantUser/', this.restaurantUser)
      .subscribe(response => {
        console.log('Saved!');
        this.router.navigate(['./signup-succesful']);
      });
  }

  private updateRestaurantUser() {
    this.service.update('RestaurantUser/', this.restaurantUser)
      .subscribe(response => {
        console.log('Successfully updated!');
        this.router.navigate(['./restaurants']);
      })
  }
  //  private getRestaurants() {
  //   this.service.get<Restaurant[]>('Restaurant').subscribe(restaurants => {
  //     this.restaurants = restaurants;
  //   })
  //  }
  ngOnInit() {
  }

}


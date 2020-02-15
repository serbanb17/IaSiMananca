import { Component, OnInit } from '@angular/core';
import { DataService } from '../../shared/services/data.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Restaurant } from '../../shared/models/restaurant.model';
import { RestaurantDish } from '../../shared/models/restaurantDish.model';

@Component({
  selector: 'ISM-restaurant-details',
  templateUrl: './restaurant-details.component.html',
  styleUrls: ['./restaurant-details.component.scss']
})
export class RestaurantDetailsComponent implements OnInit {

  id: string;
  restaurant: Restaurant;
  dishes: RestaurantDish[];

  addNewMode: boolean = false;

  constructor(private route: ActivatedRoute, private router: Router,
    private service: DataService) {
    this.route.params.subscribe((c) => {
      this.id = c['id'];
      

      if (this.id === 'addNew') {
        this.addNewMode = true;
        this.restaurant = new Restaurant();
      }

      if (!this.addNewMode) {
        this.service.get<Restaurant>('Restaurant/' + this.id)
          .subscribe(restaurant => {
            this.restaurant = restaurant;
          })
      }

      this.getRestaurantTypes();
    });
  }

  onSubmit() {
    if (this.addNewMode) {
      this.saveNewRestaurant();
    } else {
      this.updateRestaurant();
    }
  }

  private saveNewRestaurant() {
    this.service.post('Restaurant', this.restaurant).subscribe(response => {
      console.log('Saved!');
      this.router.navigate(['./restaurants']);
    });
  }

  private updateRestaurant() {
    //implement update
    this.service.update('Restaurant/'+this.restaurant.id, this.restaurant).subscribe(response => {
    console.log('updated!');
    this.router.navigate(['./restaurants']);
    });
  }

  private getRestaurantTypes() {
    //get your own RestaurantTypes from the database (create webapi service)
    // var et1 = new RestaurantType();
    // et1.id = '1470bba3-3f9f-4187-a8cd-a32036d10b19';
    // et1.name = 'Rap';

    // var et2 = new RestaurantType();
    // et2.id = '69d95e8e-08c8-4aed-9114-9dc8eca23994';
    // et2.name = 'Classical';
    // this.eventTypes = [];
    // this.eventTypes.push(et1, et2);
  }

  ngOnInit() {
  }

}

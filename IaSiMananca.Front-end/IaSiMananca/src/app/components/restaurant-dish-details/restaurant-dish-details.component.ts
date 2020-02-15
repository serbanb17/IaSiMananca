import { Component, OnInit } from '@angular/core';
import { DataService } from '../../shared/services/data.service';
import { ActivatedRoute, Router } from '@angular/router';
import { RestaurantDish } from '../../shared/models/restaurantDish.model';
import { Restaurant } from '../../shared/models/restaurant.model';

@Component({
  selector: 'ISM-restaurant-dish-details',
  templateUrl: './restaurant-dish-details.component.html',
  styleUrls: ['./restaurant-dish-details.component.scss']
})
export class RestaurantDishDetailsComponent implements OnInit {

  id: string;
  restaurants: Restaurant[];
  restaurantDish: RestaurantDish;
  addNewMode: boolean = false;

  constructor(private route: ActivatedRoute, private router: Router, private service: DataService) {
    this.route.params.subscribe((c) => {
      this.id = c['id'];

      if(this.id === 'addNew') {
        this.addNewMode = true;
        this.restaurantDish = new RestaurantDish();
      }

      if(!this.addNewMode) {
        this.service.get<RestaurantDish>('RestaurantDish/' + this.id)
        .subscribe(restaurantDish => {
          this.restaurantDish = restaurantDish;
        })
      }
      this.getRestaurants();
    });
   }

   onSubmit() {
     if(this.addNewMode) {
       this.saveNewRestaurantDish();
     } else {
       this.updateRestaurantDish();
     }
   }

   private saveNewRestaurantDish(){
     this.service.post('RestaurantDish/', this.restaurantDish)
     .subscribe(response => {
       console.log('Saved!');
       this.router.navigate(['./restaurant-dish']);
     });
   }

   private updateRestaurantDish() {
     this.service.update('RestaurantDish/', this.restaurantDish)
     .subscribe(response => {
       console.log('Successfully updated!');
       this.router.navigate(['./restaurant-dish']);
     })
   }

   private getRestaurants() {
    this.service.get<Restaurant[]>('Restaurant').subscribe(restaurants => {
      this.restaurants = restaurants;
    })
   }
  ngOnInit() {
  }

}

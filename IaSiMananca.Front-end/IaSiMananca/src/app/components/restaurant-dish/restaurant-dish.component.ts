import { Component, OnInit } from '@angular/core';
import { DataService } from '../../shared/services/data.service';
import { Router } from '@angular/router';
import { RestaurantDish } from '../../shared/models/restaurantDish.model';

@Component({
  selector: 'ISM-restaurant-dish',
  templateUrl: './restaurant-dish.component.html',
  styleUrls: ['./restaurant-dish.component.scss']
})
export class RestaurantDishComponent implements OnInit {
  restaurantDishes: RestaurantDish[];


  constructor(private service: DataService, private router: Router) {
    this.service.get<RestaurantDish[]>('RestaurantDish').subscribe(restaurantDishes => {
    this.restaurantDishes = restaurantDishes;
    })
  }

  deleteRestaurantDish(restaurantDish: RestaurantDish) {
    this.service.delete('RestaurantDish/' + restaurantDish.id).subscribe(response => {
      this.service.get<RestaurantDish[]>('RestaurantDish').subscribe(restaurantDishes => {
        this.restaurantDishes = restaurantDishes;
        this.router.navigate(['./restaurant-dish']);
      })
    });
    console.log('Deleting dish with id:' + restaurantDish.id);
  }

  
  ngOnInit() {
  }
}
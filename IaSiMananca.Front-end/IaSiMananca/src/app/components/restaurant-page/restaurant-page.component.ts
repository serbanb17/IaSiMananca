import { Component, OnInit } from '@angular/core';
import { DataService } from '../../shared/services/data.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Restaurant } from '../../shared/models/restaurant.model';
import { RestaurantDish } from '../../shared/models/restaurantDish.model';
import { Review } from '../../shared/models/review.model';
import { $ } from 'protractor';

@Component({
  selector: 'ISM-restaurant-page',
  templateUrl: './restaurant-page.component.html',
  styleUrls: ['./restaurant-page.component.scss']
})
export class RestaurantPageComponent implements OnInit {

  id: string;
  restaurant: Restaurant;
  reviews: Review[];
  dishes: RestaurantDish[];
  restaurantDish: RestaurantDish;
  selectedField: string = 'name';



  constructor(private route: ActivatedRoute, private router: Router,
    private service: DataService) {
    this.route.params.subscribe((c) => {
      this.id = c['id'];
      this.service.get<Restaurant>('Restaurant/' + this.id)
        .subscribe(restaurant => {
          this.restaurant = restaurant;
            this.service.get<number>('RestaurantReview/AverageRating/' + restaurant.id).subscribe(avR => { 
              restaurant.rating = avR;
          });
        });
        this.service.get<RestaurantDish[]>('RestaurantDish/Filter/RestaurantID/' + this.id)
        .subscribe(dishes => {
          this.dishes = dishes;
        });
        this.service.get<Review[]>('RestaurantReview/' + this.id)
        .subscribe(reviews => {
          this.reviews = reviews;
        });
    });
  }

  deleteRestaurantDish(restaurantDish: RestaurantDish) {
    this.service.delete('RestaurantDish/' + restaurantDish.id).subscribe(response => {
      this.service.get<RestaurantDish[]>('RestaurantDish').subscribe(restaurantDishes =>  {
        this.dishes = restaurantDishes;
        this.router.navigate(['./restaurant-dish']);
      })
    });
    console.log('Deleting dish with id:' + restaurantDish.id);
  }


  setFieldName(name) {
    if (this.selectedField === name) {
      this.selectedField = '-' + this.selectedField;
    } else {
      this.selectedField = name;
    }
  }
  ngOnInit() {
  }

  //Review
  deleteReview(id: string)
  {
    this.service.delete<Review>('RestaurantReview/' + id).subscribe();
    window.location.reload();
  }

}

window.addEventListener("beforeunload", function () {
  document.body.classList.add("animate-out");
});


import { Component, OnInit } from '@angular/core';
import { Restaurant } from '../../shared/models/restaurant.model';
import { DataService } from '../../shared/services/data.service';
import { Router, ActivatedRoute } from '@angular/router';
import { OrderPipe } from 'ngx-order-pipe';
import { RestaurantDish } from '../../shared/models/restaurantDish.model';

@Component({
  selector: 'ISM-restaurants',
  templateUrl: './restaurants.component.html',
  styleUrls: ['./restaurants.component.scss'],

})
export class RestaurantsComponent implements OnInit {

  restaurants: Restaurant[];
  selectedField: string = 'name';
  term: string = "";

  constructor(private service: DataService, private router: Router, private route: ActivatedRoute, private orderPipe: OrderPipe) {
    this.service.get<Restaurant[]>('Restaurant').subscribe(restaurants => {
      this.restaurants = restaurants
      this.restaurants.forEach(r => {
        this.service.get<number>('RestaurantReview/AverageRating/' + r.id).subscribe(avR => {
          r.rating = avR;
        });
      });
    })

  }

  deleteRestaurant(restaurant: Restaurant) {
    this.service.delete('Restaurant/' + restaurant.id).subscribe(response => {
      this.service.get<Restaurant[]>('Restaurant').subscribe(restaurants => {
        this.restaurants = restaurants;
        this.router.navigate(['./restaurants']);
      })
    });
    console.log('deleting event with id: ' + restaurant.id);
  }
  customFilterObj = {
    normal: {
      name: '',
    },
    range: {
      age: { start: 0, end: 0 }
    },
    search:
    {
      name: ''
    },
    searchThroughDishes:
    {
      dishName: ''
    }
  };

  setFieldName(name) {
    if (this.selectedField === name) {
      this.selectedField = '-' + this.selectedField;
    } else {
      this.selectedField = name;
    }
  }


  ngOnInit() {
  }

}

window.addEventListener("beforeunload", function () {
  document.body.classList.add("animate-out");
});

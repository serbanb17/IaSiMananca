import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DataService } from '../../shared/services/data.service';
import { Review } from '../../shared/models/review.model';
import { RestaurantDish } from '../../shared/models/restaurantDish.model';

@Component({
  selector: 'ISM-update-review',
  templateUrl: './update-review.component.html',
  styleUrls: ['./update-review.component.scss']
})
export class UpdateReviewComponent implements OnInit {
  id: string;
  review: Review;
  orders: RestaurantDish[];

  constructor(private route: ActivatedRoute, private router: Router, private service: DataService) { 
    this.route.params.subscribe((c) => {
      this.id = c['id'];
    });
    this.service.get<Review>('RestaurantReview/Entity/' + this.id)
      .subscribe(review => {
        this.review = review;
        // console.log("GetRestaurant******************************************")
        // console.log("id: " + this.review.id);
        // console.log("nameUser: " + this.review.nameUser);
        // console.log("commentDate: " + this.review.commentDate);
        // console.log("order: " + this.review.order);
        // console.log("comment: " + this.review.comment);
        // console.log("rating: " + this.review.rating);
        // console.log("restaurantId: " + this.review.restaurantId);
        // console.log("*******************************************************")
        // console.log("\n\n\n");
      this.service.get<RestaurantDish[]>('RestaurantDish/Filter/RestaurantID/' + this.review.restaurantId).subscribe(rd => {
        this.orders = rd;
        //this.orders.forEach(function (val) { console.log(val.dishName) } );
      });
    });
  }

  onSubmit(){
    // console.log("id: " + this.review.id);
    // console.log("nameUser: " + this.review.nameUser);
    // console.log("commentDate: " + this.review.commentDate);
    // console.log("order: " + this.review.order);
    // console.log("comment: " + this.review.comment);
    // console.log("rating: " + this.review.rating);
    // console.log("restaurantId: " + this.review.restaurantId);
    this.service.update<Review>('RestaurantReview', this.review).subscribe(response => {
      console.log('Saved!');
      window.location.replace("/restaurantPage/" + this.review.restaurantId);
    });
  }

  ngOnInit() {
  }

}

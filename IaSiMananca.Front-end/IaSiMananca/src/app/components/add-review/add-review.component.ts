import { Component, OnInit } from '@angular/core';
import { Review } from '../../shared/models/review.model';
import { DataService } from '../../shared/services/data.service';
import { ActivatedRoute, Router } from '@angular/router';
import { RestaurantDish } from '../../shared/models/restaurantDish.model';

@Component({
  selector: 'ISM-add-review',
  templateUrl: './add-review.component.html',
  styleUrls: ['./add-review.component.scss']
})
export class AddReviewComponent implements OnInit {
  restaurantId: string;
  review: Review;
  orders: RestaurantDish[];

  constructor(private route: ActivatedRoute, private router: Router, private service: DataService) { 
    this.route.params.subscribe((c) => {
      this.restaurantId = c['id'];
      this.service.get<RestaurantDish[]>('RestaurantDish/Filter/RestaurantID/' + this.restaurantId).subscribe(rd => {
        this.orders = rd;
        //this.orders.forEach(function (val) { console.log(val.dishName) } );
      });
    });
    this.review = new Review;
  }

  onSubmit(){
    this.review.restaurantId = this.restaurantId;
    // console.log("id: " + this.review.id);
    // console.log("nameUser: " + this.review.nameUser);
    // console.log("commentDate: " + this.review.commentDate);
    // console.log("order: " + this.review.order);
    // console.log("comment: " + this.review.comment);
    // console.log("rating: " + this.review.rating);
    // console.log("restaurantId: " + this.review.restaurantId);
    this.service.post<Review>('RestaurantReview', this.review).subscribe(response => {
      console.log('Saved!');
      window.location.replace("/restaurantPage/" + this.restaurantId);
    });
  }

  ngOnInit() {
  }

}

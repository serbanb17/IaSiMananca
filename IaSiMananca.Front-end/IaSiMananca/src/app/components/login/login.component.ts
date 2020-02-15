import { Component, OnInit, Input } from '@angular/core';
import { DataService } from '../../shared/services/data.service';
import { ActivatedRoute, Router } from '@angular/router';
import { RestaurantUser } from '../../shared/models/restaurantUser.model';

@Component({
  selector: 'ISM-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  restaurantUser: RestaurantUser;
  email: string;
  password: string;
  info: string;
  expectedPass:string;

  constructor(private route: ActivatedRoute, private router: Router, private service: DataService) {
    this.route.params.subscribe((c) => {
      this.email = c['email'];
      this.password = c['password'];
    }); 
   }
   
  onSubmit() {
    this.service.get<RestaurantUser>('RestaurantUser/Filter/EmailAndPassword?email='+this.email+'&password='+this.password)
    .subscribe(restaurantUser => {
      this.restaurantUser = restaurantUser;
      console.log(this.restaurantUser);
    })   
    if(this.restaurantUser==null)
    {
      this.router.navigate(['./login-successful']);
    }
    else{
      this.router.navigate(['./restaurant-dish'])
    }
  }
  ngOnInit() {
  }

}
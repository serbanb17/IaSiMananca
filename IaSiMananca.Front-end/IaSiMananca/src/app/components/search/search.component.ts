import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { DataService } from '../../shared/services/data.service';
import { Restaurant } from '../../shared/models/restaurant.model';
import { OrderPipe } from 'ngx-order-pipe';


@Component({
  selector: 'ISM-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit {
  term: string = "";
  show: boolean = false;
  restaurants: Restaurant[];
  selectedField: string = 'name';

  constructor(private router: Router, private route: ActivatedRoute, private service: DataService, private orderPipe: OrderPipe) {
    this.route.params.subscribe(params => {
      console.log(params);
      this.term = params['term'];
      this.service.get<Restaurant[]>('Restaurant/Filter/DishName/'+this.term).subscribe(restaurants => {
        this.restaurants = restaurants
        

      });
     
    })

  }
  doSearch() {
    //this.router.navigate(["search/"+this.term]);
    this.router.navigate(["search/", { term: this.term }]);
    if(this.restaurants!=null)
    {
      this.show = true;
    }
    
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

}

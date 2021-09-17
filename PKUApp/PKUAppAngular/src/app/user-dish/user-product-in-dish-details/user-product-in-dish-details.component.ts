import { Component, OnInit, Input } from '@angular/core';
import { UserDishComponent } from '../user-dish.component'

@Component({
  selector: 'app-user-product-in-dish-details',
  templateUrl: './user-product-in-dish-details.component.html',
  styleUrls: ['./user-product-in-dish-details.component.css']
})
export class UserProductInDishDetailsComponent implements OnInit {

  constructor(private closing:UserDishComponent) { }

  @Input() 
  product:any;

  ngOnInit(): void {
  }

  Close(){
    this.closing.closeClickFromOutside();
  }
}
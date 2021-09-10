import { Component, OnInit, Input } from '@angular/core';
import { UserEditMealComponent } from '../user-edit-meal.component'

@Component({
  selector: 'app-user-product-in-meal-details',
  templateUrl: './user-product-in-meal-details.component.html',
  styleUrls: ['./user-product-in-meal-details.component.css']
})
export class UserProductInMealDetailsComponent implements OnInit {

  constructor(private closing:UserEditMealComponent) { }

  @Input() 
  product:any;

  ngOnInit(): void {
  }

  Close(){
    this.closing.closeClickFromOutside();
  }
}

import { Component, OnInit, Input } from '@angular/core';
import { UserEditMealComponent } from '../user-edit-meal/user-edit-meal.component'

@Component({
  selector: 'app-user-meal-details-product',
  templateUrl: './user-meal-details-product.component.html',
  styleUrls: ['./user-meal-details-product.component.css']
})
export class UserMealDetailsProductComponent implements OnInit {
  
    constructor(private closing:UserEditMealComponent) { }
  
    @Input() 
        product:any;
        ProductId:number;
        Name:string;
        Phe:number;
        Calories:number;
        Protein:number;
        Fat:number;
        Carb:number;
  
    ngOnInit(): void {
      this.ProductId=this.product.ProductId;
      this.Name=this.product.Name;
      this.Phe=this.product.Phe;
      this.Calories=this.product.Calories;
      this.Protein=this.product.Protein;
      this.Fat=this.product.Fat;
      this.Carb=this.product.Carb;
    }
  
    Close(){
      this.closing.closeClickFromOutside();
    }
  
  }

import { Component, OnInit, Input } from '@angular/core';
import { UserDishComponent } from '../user-dish.component'

@Component({
  selector: 'app-user-dish-details-product',
  templateUrl: './user-dish-details-product.component.html',
  styleUrls: ['./user-dish-details-product.component.css']
})
export class UserDishDetailsProductComponent implements OnInit {
  
    constructor(private closing:UserDishComponent) { }
  
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

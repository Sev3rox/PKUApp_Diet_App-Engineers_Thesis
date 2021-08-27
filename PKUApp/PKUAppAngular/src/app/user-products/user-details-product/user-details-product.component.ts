import { Component, OnInit, Input } from '@angular/core';
import { UserShowProductsComponent } from 'src/app/user-products/user-show-products/user-show-products.component'

@Component({
  selector: 'app-user-details-product',
  templateUrl: './user-details-product.component.html',
  styleUrls: ['./user-details-product.component.css']
})
export class UserDetailsProductComponent implements OnInit {
  constructor(private closing:UserShowProductsComponent) { }

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

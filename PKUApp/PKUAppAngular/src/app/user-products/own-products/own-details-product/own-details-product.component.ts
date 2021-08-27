import { Component, OnInit, Input } from '@angular/core';
import { OwnShowProductsComponent } from 'src/app/user-products/own-products/own-show-products/own-show-products.component'

@Component({
  selector: 'app-own-details-product',
  templateUrl: './own-details-product.component.html',
  styleUrls: ['./own-details-product.component.css']
})
export class OwnDetailsProductComponent implements OnInit {

  constructor(private closing:OwnShowProductsComponent) { }

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

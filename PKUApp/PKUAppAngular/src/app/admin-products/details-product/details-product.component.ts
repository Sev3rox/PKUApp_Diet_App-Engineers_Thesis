import { Component, OnInit, Input } from '@angular/core';
import { ShowProductsComponent } from 'src/app/admin-products/show-products/show-products.component'

@Component({
  selector: 'app-details-product',
  templateUrl: './details-product.component.html',
  styleUrls: ['./details-product.component.css']
})
export class DetailsProductComponent implements OnInit {

  constructor(private closing:ShowProductsComponent) { }

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

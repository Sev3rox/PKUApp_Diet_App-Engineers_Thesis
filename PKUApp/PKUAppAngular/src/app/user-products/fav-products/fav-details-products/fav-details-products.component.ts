import { Component, OnInit, Input } from '@angular/core';
import { FavShowProductsComponent } from 'src/app/user-products/fav-products/fav-show-products/fav-show-products.component'

@Component({
  selector: 'app-fav-details-products',
  templateUrl: './fav-details-products.component.html',
  styleUrls: ['./fav-details-products.component.css']
})
export class FavDetailsProductsComponent implements OnInit {

  constructor(private closing:FavShowProductsComponent) { }

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


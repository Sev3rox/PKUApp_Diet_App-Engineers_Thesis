import { Component, OnInit, Input } from '@angular/core';
import { NotlogedShowProductsComponent } from '../notloged-show-products/notloged-show-products.component';

@Component({
  selector: 'app-notloged-details-product',
  templateUrl: './notloged-details-product.component.html',
  styleUrls: ['./notloged-details-product.component.css']
})
export class NotlogedDetailsProductComponent implements OnInit {

    constructor(private closing:NotlogedShowProductsComponent) { }
  
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
  


import { Component, OnInit, Input } from '@angular/core';
import { UserDishComponent } from '../user-dish.component'
import { ToastrService } from 'ngx-toastr';
import { UserDishService } from 'src/app/shared/services/user-dish.service';

@Component({
  selector: 'app-user-delete-product-dish',
  templateUrl: './user-delete-product-dish.component.html',
  styleUrls: ['./user-delete-product-dish.component.css']
})
export class UserDeleteProductDishComponent implements OnInit {

  constructor(private closing:UserDishComponent, private toastr: ToastrService, private service:UserDishService) { }
  
  @Input() 
      product:any;

  ngOnInit(): void {
  }

  Delete(){
    this.service.deleteDishProduct(this.product.Product.ProductId).subscribe(_=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Deleted successfully", "Dish Management")});
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}

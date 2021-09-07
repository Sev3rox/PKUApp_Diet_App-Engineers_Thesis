import { Component, OnInit, Input } from '@angular/core';
import { UserEditMealComponent } from '../user-edit-meal/user-edit-meal.component'
import { ToastrService } from 'ngx-toastr';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';

@Component({
  selector: 'app-user-delete-product-meal',
  templateUrl: './user-delete-product-meal.component.html',
  styleUrls: ['./user-delete-product-meal.component.css']
})
export class UserDeleteProductMealComponent implements OnInit {

  constructor(private closing:UserEditMealComponent, private toastr: ToastrService, private service:UserPlanService) { }
  
  @Input() 
      product:any;
  @Input() 
      mealid:number;

  ngOnInit(): void {
  }

  Delete(){
    this.service.deleteMealProduct(this.mealid, this.product.Product.ProductId).subscribe(_=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Deleted successfully", "Meal Edit Management")});
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}

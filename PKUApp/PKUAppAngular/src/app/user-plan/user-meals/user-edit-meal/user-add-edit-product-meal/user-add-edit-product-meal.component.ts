import { Component, OnInit, Input } from '@angular/core';
import { UserEditMealComponent } from '../user-edit-meal.component'
import { ToastrService } from 'ngx-toastr';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-user-add-edit-product-meal',
  templateUrl: './user-add-edit-product-meal.component.html',
  styleUrls: ['./user-add-edit-product-meal.component.css']
})
export class UserAddEditProductMealComponent implements OnInit {

  constructor(private closing:UserEditMealComponent, private toastr: ToastrService, private service:UserPlanService) { }
  
  @Input() 
      product:any;
  @Input() 
      mealid:number;
  @Input() 
      weight:number;

      public productMealForm: FormGroup;
      public errorMessage: string = '';
      public showError: boolean;

  ngOnInit(): void {
    this.productMealForm = new FormGroup({
      Weight: new FormControl(this.weight, [Validators.required, Validators.min(1), Validators.max(10000)]),
    })
  }

  addUpdateMealProduct(productMealFormValue){
    if(this.weight==0)
    this.Add(productMealFormValue);
    else
    this.Update(productMealFormValue);
  }

  Add(formValue){

    var val = {MealId:this.mealid,
               ProductId:this.product.Product.ProductId,
               Weight:(Math.round((Math.round(formValue.Weight * 100) / 100)*100))}

    this.service.addProductToMeal(val).subscribe(res=>{
      this.toastr.success("Added successfully", "Meal Edit Management");
      this.closing.closeClickFromOutside();
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  Update(formValue){

    var val = {MealId:this.mealid,
               ProductId:this.product.Product.ProductId,
               Weight:(Math.round((Math.round(formValue.Weight * 100) / 100)*100))}

    this.service.editProductToMeal(val).subscribe(res=>{
      this.toastr.success("Edited successfully", "Meal Edit Management");
      this.closing.closeClickFromOutside();
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.productMealForm.controls[controlName].hasError(errorName)
  }

  public validateControl = (controlName: string) => {
    return this.productMealForm.controls[controlName].invalid && this.productMealForm.controls[controlName].touched
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}
import { Component, OnInit, Input } from '@angular/core';
import { UserDishComponent } from '../user-dish.component'
import { ToastrService } from 'ngx-toastr';
import { UserDishService } from 'src/app/shared/services/user-dish.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-user-add-edit-product-dish',
  templateUrl: './user-add-edit-product-dish.component.html',
  styleUrls: ['./user-add-edit-product-dish.component.css']
})
export class UserAddEditProductDishComponent implements OnInit {

  constructor(private closing:UserDishComponent, private toastr: ToastrService, private service:UserDishService) { }
  
  @Input() 
      product:any;
  @Input() 
      weight:number;

      public productDishForm: FormGroup;
      public errorMessage: string = '';
      public showError: boolean;

  ngOnInit(): void {
    this.productDishForm = new FormGroup({
      Weight: new FormControl(this.weight, [Validators.required, Validators.min(1), Validators.max(10000)]),
    })
  }

  addUpdateDishProduct(productDishFormValue){
    if(this.weight==0)
    this.Add(productDishFormValue);
    else
    this.Update(productDishFormValue);
  }

  Add(formValue){

    var val = {ProductId:this.product.Product.ProductId,
               Weight:(Math.round((Math.round(formValue.Weight * 100) / 100)*100))}

    this.service.addProductToDish(val).subscribe(res=>{
      this.toastr.success("Added successfully", "Dish Management");
      this.closing.closeClickFromOutside();
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  Update(formValue){

    var val = {ProductId:this.product.Product.ProductId,
               Weight:(Math.round((Math.round(formValue.Weight * 100) / 100)*100))}

    this.service.editProductToDish(val).subscribe(res=>{
      this.toastr.success("Edited successfully", "Dish Management");
      this.closing.closeClickFromOutside();
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.productDishForm.controls[controlName].hasError(errorName)
  }

  public validateControl = (controlName: string) => {
    return this.productDishForm.controls[controlName].invalid && this.productDishForm.controls[controlName].touched
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}
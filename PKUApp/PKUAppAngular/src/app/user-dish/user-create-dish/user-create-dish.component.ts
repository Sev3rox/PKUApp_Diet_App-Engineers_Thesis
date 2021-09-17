import { Component, OnInit, Input } from '@angular/core';
import { UserDishService } from 'src/app/shared/services/user-dish.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { UserDishComponent } from '../user-dish.component'

@Component({
  selector: 'app-user-create-dish',
  templateUrl: './user-create-dish.component.html',
  styleUrls: ['./user-create-dish.component.css']
})
export class UserCreateDishComponent implements OnInit {

  constructor(private service:UserDishService, private toastr: ToastrService, private closing:UserDishComponent) { }

  public dishForm: FormGroup;
  public errorMessage: string = '';
  public showError: boolean;
  Name:string="";

  ngOnInit(): void {

    this.dishForm = new FormGroup({
      Name: new FormControl(this.Name, [Validators.required]),
    })
  }

  addDish(dishFormValue){
    this.service.createDish(dishFormValue.Name).subscribe(res=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Created successfully", "Dish Management");
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.dishForm.controls[controlName].hasError(errorName)
  }

  public validateControl = (controlName: string) => {
    return this.dishForm.controls[controlName].invalid && this.dishForm.controls[controlName].touched
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}

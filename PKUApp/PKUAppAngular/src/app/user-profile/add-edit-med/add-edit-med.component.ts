import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, Input, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { UserProfileComponent } from '../user-profile.component'
import { UserService } from './../../shared/services/user.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-add-edit-med',
  templateUrl: './add-edit-med.component.html',
  styleUrls: ['./add-edit-med.component.css']
})
export class AddEditMedComponent implements OnInit {

  constructor(private toastr: ToastrService, private closing:UserProfileComponent, private service:UserService, private datePipe: DatePipe) { }

  @Input()
  med

  UserMedicineId:number;
  Phe:number;
  Calories:number;
  Protein:number;
  Fat:number;
  Carb:number;
  UserId:number;

  public userMedForm: FormGroup;
  public errorMessage: string = '';
  public showError: boolean;

  date:any;

  ngOnInit(): void {
    this.UserMedicineId=this.med.UserMedicineId;
    this.Phe=this.med.Phe/100;
    this.Calories=this.med.Calories/100;
    this.Protein=this.med.Protein/100;
    this.Fat=this.med.Fat/100;
    this.Carb=this.med.Carb/100;
    this.UserId=this.med.UserId;
    

    this.userMedForm = new FormGroup({
      Phe: new FormControl(this.Phe, [Validators.required, Validators.min(0), Validators.max(10000)]),
      Calories: new FormControl(this.Calories, [Validators.required, Validators.min(0), Validators.max(10000)]),
      Protein: new FormControl(this.Protein, [Validators.required, Validators.min(0), Validators.max(1000)]),
      Fat: new FormControl(this.Fat, [Validators.required, Validators.min(0), Validators.max(1000)]),
      Carb: new FormControl(this.Carb, [Validators.required, Validators.min(0), Validators.max(1000)])
    });
  }

  addEditMedUser(formValue){
    if(this.UserMedicineId==0)
    this.addMed(formValue);
    else
    this.updateMed(formValue);
  }

  addMed(formValue){
    this.showError = false;
    this.date=new Date();

    var val = { UserMedicineId:this.UserMedicineId,
      Phe:(Math.round((Math.round(formValue.Phe * 100) / 100)*100)),
      Calories:(Math.round((Math.round(formValue.Calories * 100) / 100)*100)),
      Protein:(Math.round((Math.round(formValue.Protein * 100) / 100)*100)),
      Fat:(Math.round((Math.round(formValue.Fat * 100) / 100)*100)),
      Carb:(Math.round((Math.round(formValue.Carb * 100) / 100)*100))}

    this.service.addMedicine(val, this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(_=>{
      this.toastr.success("Medicine added successfully", "User Management");
      this.closing.closeClickFromOutside();
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  updateMed(formValue){
    this.showError = false;
    this.date=new Date();

    var val = { UserMedicineId:this.UserMedicineId,
      Phe:(Math.round((Math.round(formValue.Phe * 100) / 100)*100)),
      Calories:(Math.round((Math.round(formValue.Calories * 100) / 100)*100)),
      Protein:(Math.round((Math.round(formValue.Protein * 100) / 100)*100)),
      Fat:(Math.round((Math.round(formValue.Fat * 100) / 100)*100)),
      Carb:(Math.round((Math.round(formValue.Carb * 100) / 100)*100)),
      UserId:this.UserId}

    this.service.editMedicine(val, this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(_=>{
      this.toastr.success("Medicine updated successfully", "User Management");
      this.closing.closeClickFromOutside();
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    }); 
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.userMedForm.controls[controlName].hasError(errorName)
  }

  public validateControl = (controlName: string) => {
    return this.userMedForm.controls[controlName].invalid && this.userMedForm.controls[controlName].touched
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}

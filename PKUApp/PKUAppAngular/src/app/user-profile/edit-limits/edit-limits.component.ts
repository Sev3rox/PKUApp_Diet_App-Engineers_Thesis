import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { UserProfileComponent } from '../user-profile.component'
import { UserService } from './../../shared/services/user.service';

@Component({
  selector: 'app-edit-limits',
  templateUrl: './edit-limits.component.html',
  styleUrls: ['./edit-limits.component.css']
})
export class EditLimitsComponent implements OnInit {

  constructor(private toastr: ToastrService, private closing:UserProfileComponent, private service:UserService) { }

  @Input()
  Limits:any;
  UserDailyLimitsId:number;
  PheLimit:number;
  CaloriesLimit:number;
  ProteinLimit:number;
  FatLimit:number;
  CarbLimit:number;
  UserId:number;

  public userLimitsForm: FormGroup;
  public errorMessage: string = '';
  public showError: boolean;

  ngOnInit(): void {
    this.UserDailyLimitsId=this.Limits.UserDailyLimitsId;
    this.PheLimit=this.Limits.PheLimit/100;
    this.CaloriesLimit=this.Limits.CaloriesLimit/100;
    this.ProteinLimit=this.Limits.ProteinLimit/100;
    this.FatLimit=this.Limits.FatLimit/100;
    this.CarbLimit=this.Limits.CarbLimit/100;
    this.UserId=this.Limits.UserId;
    

    this.userLimitsForm = new FormGroup({
      PheLimit: new FormControl(this.PheLimit, [Validators.required, Validators.min(0), Validators.max(100000)]),
      CaloriesLimit: new FormControl(this.CaloriesLimit, [Validators.required, Validators.min(0), Validators.max(100000)]),
      ProteinLimit: new FormControl(this.ProteinLimit, [Validators.required, Validators.min(0), Validators.max(10000)]),
      FatLimit: new FormControl(this.FatLimit, [Validators.required, Validators.min(0), Validators.max(10000)]),
      CarbLimit: new FormControl(this.CarbLimit, [Validators.required, Validators.min(0), Validators.max(10000)])
    });
  }

  editUserLimits(formValue){
    var val = { UserDailyLimitsId:this.UserDailyLimitsId,
      PheLimit:(Math.round((Math.round(formValue.PheLimit * 100) / 100)*100)),
      CaloriesLimit:(Math.round((Math.round(formValue.CaloriesLimit * 100) / 100)*100)),
      ProteinLimit:(Math.round((Math.round(formValue.ProteinLimit * 100) / 100)*100)),
      FatLimit:(Math.round((Math.round(formValue.FatLimit * 100) / 100)*100)),
      CarbLimit:(Math.round((Math.round(formValue.CarbLimit * 100) / 100)*100)),
      UserId:this.UserId}

    this.service.editLimits(val).subscribe(_=>{
      this.toastr.success("Limits edited successfully", "User Management");
      this.closing.closeClickFromOutside();
    });
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.userLimitsForm.controls[controlName].hasError(errorName)
  }

  public validateControl = (controlName: string) => {
    return this.userLimitsForm.controls[controlName].invalid && this.userLimitsForm.controls[controlName].touched
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}

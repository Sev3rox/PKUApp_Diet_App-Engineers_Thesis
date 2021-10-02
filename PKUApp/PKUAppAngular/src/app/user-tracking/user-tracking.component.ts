import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { UserTrackingService } from 'src/app/shared/services/user-tracking.service';
import { DatePipe } from '@angular/common';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-user-tracking',
  templateUrl: './user-tracking.component.html',
  styleUrls: ['./user-tracking.component.css']
})
export class UserTrackingComponent implements OnInit {

  constructor(private datePipe: DatePipe, private service:UserTrackingService, private toastr: ToastrService) { }
  weight:number=0;
  phe:number=0;
  wholeWeight:any;
  wholePhe:any;
  isWeight:boolean=true;
  isPhe:boolean=false;
  date:Date;
  msg:string="";
  msgType:number=1;

  public weightTrackingForm: FormGroup;
  public pheTrackingForm: FormGroup;
  public errorMessageWeight: string = '';
  public showErrorWeight: boolean;
  public errorMessagePhe: string = '';
  public showErrorPhe: boolean;

  selectedType:number=1;
  colorScheme:any;
  yAxis:string;
  chartData:any;
  chartColor:any;
  chartUnit:string="(kg)";
  loaded:boolean=false;

  ngOnInit(): void {

    this.date=new Date();

    this.colorScheme = {
      colorWeight: {
      domain: ['#853c00']
    },
    colorPhe: {
      domain: ['#b700ff']
    }
    };

    this.chartColor=this.colorScheme.colorWeight;
    this.yAxis="Weight (kg)";

    this.refreshWeight();
    this.refreshPhe();

    this.weightTrackingForm = new FormGroup({
      Weight: new FormControl(this.weight, [Validators.required, Validators.min(1), Validators.max(1000)]),
    })

    this.pheTrackingForm = new FormGroup({
      Phe: new FormControl(this.phe, [Validators.required, Validators.min(1), Validators.max(1000)]),
    })


  }

resetButtons(){
  this.isPhe=false;
  this.isWeight=false;
}

addUpdateWeightTracking(FormValue){
  if(this.weight==0)
  this.AddWeight(FormValue);
  else
  this.UpdateWeight(FormValue);
}

AddWeight(formValue){

    this.date=new Date();

    let val = {Date:this.datePipe.transform(this.date, 'yyyy-MM-dd'),
               Type:1,
               Value:(Math.round((Math.round(formValue.Weight * 100) / 100)*100))}

    this.service.addWeightTracking(val).subscribe(res=>{
    this.refreshWeight();
    this.toastr.success("Added successfully", "Weight Tracking Management");
    },
    (error) => {
      this.errorMessageWeight = error;
      this.showErrorWeight = true;
    });
}

UpdateWeight(formValue){
    this.service.updateWeightTracking(this.wholeWeight.TrackedValueId, (Math.round((Math.round(formValue.Weight * 100) / 100)*100))).subscribe(res=>{
      this.refreshWeight();
      this.toastr.success("Updated successfully", "Weight Tracking Management");
    },
    (error) => {
      this.errorMessageWeight = error;
      this.showErrorWeight = true;
    });
}

addUpdatePheTracking(FormValue){
  if(this.phe==0)
  this.AddPhe(FormValue);
  else
  this.UpdatePhe(FormValue);
}

AddPhe(formValue){

  this.date=new Date();

  let val = {Date:this.datePipe.transform(this.date, 'yyyy-MM-dd'),
             Type:2,
             Value:(Math.round((Math.round(formValue.Phe * 100) / 100)*100))}

  this.service.addPheTracking(val).subscribe(res=>{
  this.refreshPhe();
  this.toastr.success("Added successfully", "Phe Tracking Management");
  },
  (error) => {
    this.errorMessagePhe = error;
    this.showErrorPhe = true;
  });
}

UpdatePhe(formValue){
  this.service.updatePheTracking(this.wholePhe.TrackedValueId, (Math.round((Math.round(formValue.Phe * 100) / 100)*100))).subscribe(res=>{
    this.refreshPhe();
    this.toastr.success("Updated successfully", "Phe Tracking Management");
  },
  (error) => {
    this.errorMessagePhe = error;
    this.showErrorPhe = true;
  });
}

  buttonChange(type){
    this.resetButtons();
    if(type=="Weight"){
        this.isWeight=true;
        this.chartColor=this.colorScheme.colorWeight;
        this.yAxis="Weight (kg)";
        this.chartUnit="(kg)";
    }
    else if(type=="Phe"){
        this.isPhe=true;
        this.chartColor=this.colorScheme.colorPhe;
        this.yAxis="Phe [mg/dL]";
        this.chartUnit="[mg/dL]";
    }

    this.getChartData();
  }

  refreshWeight(){
    this.date=new Date();
    this.service.getWeightTracking(1, this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
      if(data!=null){
      this.weight=data.Value/100;
      this.wholeWeight=data;
      this.weightTrackingForm = new FormGroup({
        Weight: new FormControl(this.weight, [Validators.required, Validators.min(1), Validators.max(1000)]),
      })
    }
      this.getChartData();
    })
  }

  refreshPhe(){
    this.date=new Date();
    this.service.getPheTracking(2, this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
      if(data!=null){
      this.phe=data.Value/100;
      this.wholePhe=data;
      this.pheTrackingForm = new FormGroup({
        Phe: new FormControl(this.phe, [Validators.required, Validators.min(1), Validators.max(1000)]),
      })
    }
      this.getChartData();
    })
  }

  getChartData(){
    this.date=new Date();
    if(this.isWeight==true)
    this.selectedType=1;
    else if(this.isPhe==true)
    this.selectedType=2;

    this.loaded=false;
    this.service.getChartData(this.selectedType, this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
      this.chartData=data
      this.loaded=true;
      this.getMessage();
    });
  }

  getMessage(){
    this.service.getMessage(this.selectedType, this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
      if(data!=null){
        this.msg=data.msg;
        this.msgType=data.type;
      }
    });
  }
  

  public hasErrorWeight = (controlName: string, errorName: string) => {
    return this.weightTrackingForm.controls[controlName].hasError(errorName)
  }

  public validateControlWeight = (controlName: string) => {
    return this.weightTrackingForm.controls[controlName].invalid && this.weightTrackingForm.controls[controlName].touched
  }

  public hasErrorPhe = (controlName: string, errorName: string) => {
    return this.pheTrackingForm.controls[controlName].hasError(errorName)
  }

  public validateControlPhe= (controlName: string) => {
    return this.pheTrackingForm.controls[controlName].invalid && this.pheTrackingForm.controls[controlName].touched
  }

}

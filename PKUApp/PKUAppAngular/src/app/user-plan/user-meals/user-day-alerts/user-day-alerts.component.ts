import { Component, Input, OnInit } from '@angular/core';
import { UserShowMealsComponent } from '../user-show-meals/user-show-meals.component'
import { ToastrService } from 'ngx-toastr';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-user-day-alerts',
  templateUrl: './user-day-alerts.component.html',
  styleUrls: ['./user-day-alerts.component.css']
})
export class UserDayAlertsComponent implements OnInit {

  constructor(private closing:UserShowMealsComponent, private toastr: ToastrService,private service:UserPlanService, private datePipe: DatePipe) { }

  @Input()
  date
  @Input()
  daySummary
  @Input()
  Limits

  showPhe:boolean=false;
  showCalories:boolean=false;
  showProtein:boolean=false;
  showFat:boolean=false;
  showCarb:boolean=false;

  ngOnInit(): void {
  if(this.daySummary?.Product.Phe>this.Limits?.PheLimit && this.Limits?.PheLimit!=0)
    this.showPhe=true;
  if(this.daySummary?.Product.Calories>this.Limits?.CaloriesLimit && this.Limits?.CaloriesLimit!=0)
    this.showCalories=true;
  if(this.daySummary?.Product.Protein>this.Limits?.ProteinLimit && this.Limits?.ProteinLimit!=0)
    this.showProtein=true; 
  if(this.daySummary?.Product.Fat>this.Limits?.FatLimit && this.Limits?.FatLimit!=0)
    this.showFat=true; 
  if(this.daySummary?.Product.Carb>this.Limits?.CarbLimit && this.Limits?.CarbLimit!=0)
    this.showCarb=true;
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

  DontShow(){
    this.service.addOffAlerts(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(_=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Alerts won't be shown this day", "Alerts Management")
    });
  }
}

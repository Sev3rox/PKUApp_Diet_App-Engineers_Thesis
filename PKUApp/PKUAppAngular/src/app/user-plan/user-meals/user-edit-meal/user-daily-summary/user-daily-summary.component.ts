import { Component, Input, OnInit,  } from '@angular/core';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';
import { UserService } from './../../../../shared/services/user.service';
import { DatePipe } from '@angular/common';
import { UserEditMealComponent } from '../user-edit-meal.component'

@Component({
  selector: 'app-user-daily-summary',
  templateUrl: './user-daily-summary.component.html',
  styleUrls: ['./user-daily-summary.component.css']
})
export class UserDailySummaryComponent implements OnInit {

  constructor(private service:UserPlanService, private userService:UserService, private datePipe: DatePipe, private closing:UserEditMealComponent) { }

  @Input()
  date

  daySummary:any;
  daySummaryCharts:any;
  colorScheme:any;
  Limits: any;
  dayMed:any;

  ngOnInit(): void {
    this.colorScheme = {
      colorCalories: {
      domain: ['#ffd900']
    },
    colorPhe: {
      domain: ['#b700ff']
    }
    ,
    colorProtein: {
      domain: ['#0059ff']
    }
    ,
    colorFat: {
      domain: ['#00b10f']
    }
    ,
    colorCarb: {
      domain: ['#ff1e00']
    }
    };

    this.refreshDaySummary();
  }

  refreshDaySummary(){
    this.service.getDaySummary(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
      this.daySummary=data;
      this.refreshDayMed();
      this.getLimits();
    });
    }

    refreshChartSummary(){
      this.daySummaryCharts={
        Phe:
        [{
          "name": "Phe limit",
          "value": (this.daySummary?.Product.Phe/100).toFixed()
        }],
        Calories:
        [{
          "name": "Calories limit",
          "value": (this.daySummary?.Product.Calories/100).toFixed()
        }],
        Protein:
        [{
          "name": "Protein limit",
          "value": (this.daySummary?.Product.Protein/100).toFixed()
        }],
        Fat:
        [{
          "name": "Fat limit",
          "value": (this.daySummary?.Product.Fat/100).toFixed()
        }],
        Carb:
        [{
          "name": "Carb limit",
          "value": (this.daySummary?.Product.Carb/100).toFixed()
        }],
      };
    }  

    refreshDayMed(){
      this.service.getDayMed(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
        this.dayMed=data;
        if(data!=undefined){
        this.daySummary.Product.Phe+=this.dayMed.Phe;
        this.daySummary.Product.Calories+=this.dayMed.Calories;
        this.daySummary.Product.Protein+=this.dayMed.Protein;
        this.daySummary.Product.Fat+=this.dayMed.Fat;
        this.daySummary.Product.Carb+=this.dayMed.Carb;
        }

        if(this.daySummary.Product.Phe<100)
        this.daySummary.Product.Phe=0
        if(this.daySummary.Product.Calories<100)
        this.daySummary.Product.Calories=0
        if(this.daySummary.Product.Protein<100)
        this.daySummary.Product.Protein=0
        if(this.daySummary.Product.Fat<100)
        this.daySummary.Product.Fat=0
        if(this.daySummary.Product.Carb<100)
        this.daySummary.Product.Carb=0
        this.refreshChartSummary();
      });
    }

    Close(){
      this.closing.closeClickFromOutside();
    }

    getLimits(){
      this.userService.getLimits()
      .subscribe(res =>{this.Limits=res;});
    }

}

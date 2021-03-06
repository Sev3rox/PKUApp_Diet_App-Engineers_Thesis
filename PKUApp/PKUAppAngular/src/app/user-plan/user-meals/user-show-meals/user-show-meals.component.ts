import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';
import { UserService } from './../../../shared/services/user.service';
import { UserExercisesService } from 'src/app/shared/services/user-exercises.service';
import { ToastrService } from 'ngx-toastr';
import { DatePipe } from '@angular/common';
import { Router } from '@angular/router';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-user-show-meals',
  templateUrl: './user-show-meals.component.html',
  styleUrls: ['./user-show-meals.component.css']
})
export class UserShowMealsComponent implements OnInit {

  constructor(private route: ActivatedRoute, private service:UserPlanService, private userService:UserService, private toastr: ToastrService, private datePipe: DatePipe, private router:Router, private exerservice: UserExercisesService) { }
  MealsList:any=[];
  date:Date;
  currDate:Date;
  alertDate:Date;
  isToday:boolean=true;
  public errorMessage: string = '';
  public showError: boolean;
  meal:any;
  daySummary:any;
  dayMed:any;
  ModalTitle:string;
  ActivateDeleteMealComp:boolean=false;
  ActivateDetailsMealComp:boolean=false;
  ActivateDayAlertsComp:boolean=false;
  ActivateDayMedComp:boolean=false;

  daySummaryCharts:any;
  colorScheme:any;
  Limits: any;

  @ViewChild('alertbutton') alertbutton: ElementRef<HTMLElement>;

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

    this.route.queryParams.subscribe(params => {
      if(params.date!=undefined)
      this.date=new Date(params.date);
  });

    this.currDate=new Date();
    this.alertDate=new Date();

    if(this.date===undefined)
    {
    this.date=new Date();
    this.currDate.setDate(this.currDate.getDate());
    }
    else{
    this.currDate.setDate(this.currDate.getDate()-1);
    }

    if(this.datePipe.transform(this.date, 'yyyy-MM-dd')!=this.datePipe.transform(new Date(), 'yyyy-MM-dd')){
      this.isToday=false;
    }
    else{
      this.isToday=true;
    }
    this.refreshMealsList();
    this.refreshDaySummaryOnInit();
    
  }

  dateClick(val){
    this.date.setDate(this.date.getDate()+val);
    this.date=new Date(this.date);
    if(this.datePipe.transform(this.date, 'yyyy-MM-dd')!=this.datePipe.transform(new Date(), 'yyyy-MM-dd')){
      this.isToday=false;
    }
    else{
      this.isToday=true;
    }
    this.refreshMealsList();
    this.refreshDaySummaryOnInit();
  }

  dateChangeinput(indate){

    this.date=new Date(indate);
    if(this.datePipe.transform(this.date, 'yyyy-MM-dd')!=this.datePipe.transform(new Date(), 'yyyy-MM-dd')){
      this.isToday=false;
    }
    else{
      this.isToday=true;
    }
    this.refreshMealsList();
    this.refreshDaySummaryOnInit();
  }

  addMealClick(){
    this.showError = false;
    this.service.addMeal(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
    this.toastr.success("Added successfully", "Meal Management");
    this.refreshMealsList();
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  deleteClick(item:any){
    this.meal=item;
    this.ModalTitle="Delete Meal";
    this.ActivateDeleteMealComp=true;
  }

  editClick(item:any){
    this.router.navigate(['/user-edit-meal'],{queryParams:{id: item.MealId, date: this.date}});
  }

  deatailsClick(item:any){
    this.meal=item;
    this.ModalTitle="Meal Details";
    this.ActivateDetailsMealComp=true;
  }

  deatailsMedClick(){
    this.ModalTitle="Medicine Details";
    this.ActivateDayMedComp=true;
  }

  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;

  closeClickFromOutside(){
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
  }

  closeClick(){
    this.ActivateDeleteMealComp=false;
    this.ActivateDetailsMealComp=false;
    this.ActivateDayAlertsComp=false;
    this.ActivateDayMedComp=false;
    this.refreshMealsList();
    this.refreshDaySummary();
  }

  getLimits(){
    this.userService.getLimits()
    .subscribe(res =>{this.Limits=res;
    this.getIfAdd();
    });
  }

  getLimitsOnInit(){
    this.userService.getLimits()
    .subscribe(res =>{this.Limits=res;
    this.getIfAddOnInit();
    });
  }

  getIfAdd(){
    if(this.Limits.CaloriesLimit!=0 && this.Limits.AddCalories==true)
    this.getExercise();
  }

  getIfAddOnInit(){
    if(this.Limits.CaloriesLimit!=0 && this.Limits.AddCalories==true)
    this.getExerciseOnInit();
    else
    this.showAlerts();
  }

  getExercise(){
    this.exerservice.getDaySummary(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(_=>{
      this.Limits.CaloriesLimit+=_.Calories;
    });
  }

  getExerciseOnInit(){
    this.exerservice.getDaySummary(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(_=>{
      this.Limits.CaloriesLimit+=_.Calories;
      this.showAlerts();
    });
  }

  dailyAlertsClick(){
    this.ModalTitle="Alerts "+(this.datePipe.transform(this.date, 'MM-dd-yyyy'));
    this.ActivateDayAlertsComp=true;
  }

  showAlerts(){
    let isalert=false;
    
    if(this.date>=this.alertDate||this.isToday){
        this.service.getOffAlerts(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{

        if(data==false){
            if(this.daySummary?.Product.Phe>this.Limits?.PheLimit && this.Limits?.PheLimit!=0)
              isalert=true;
            else if(this.daySummary?.Product.Calories>this.Limits?.CaloriesLimit && this.Limits?.CaloriesLimit!=0)
              isalert=true;
            else if(this.daySummary?.Product.Protein>this.Limits?.ProteinLimit && this.Limits?.ProteinLimit!=0)
              isalert=true; 
            else if(this.daySummary?.Product.Fat>this.Limits?.FatLimit && this.Limits?.FatLimit!=0)
              isalert=true; 
            else if(this.daySummary?.Product.Carb>this.Limits?.CarbLimit && this.Limits?.CarbLimit!=0)
              isalert=true;           
        }

        if(isalert==true){
        let el: HTMLElement = this.alertbutton.nativeElement;
            el.click();
        }
      });
    }
  }

  refreshMealsList(){
    this.service.getMealsList(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
    this.MealsList=data;
    });
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

    refreshDaySummary(){
      this.service.getDaySummary(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
        this.daySummary=data;
        this.refreshDayMed();
        this.getLimits();
      });
      }

      refreshDaySummaryOnInit(){
        this.service.getDaySummary(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
          this.daySummary=data;
          this.refreshDayMed();
          this.getLimitsOnInit();
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
}

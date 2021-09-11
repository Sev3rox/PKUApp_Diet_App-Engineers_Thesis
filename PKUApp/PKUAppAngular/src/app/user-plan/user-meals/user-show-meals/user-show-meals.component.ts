import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';
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

  constructor(private route: ActivatedRoute, private service:UserPlanService,private toastr: ToastrService,private datePipe: DatePipe, private router:Router) { }
  MealsList:any=[];
  date:Date;
  minDate:Date;
  maxDate:Date;
  public errorMessage: string = '';
  public showError: boolean;
  meal:any;
  daySummary:any;
  ModalTitle:string;
  ActivateDeleteMealComp:boolean=false;
  ActivateDetailsMealComp:boolean=false;

  ngOnInit(): void {

    this.route.queryParams.subscribe(params => {
      if(params.date!=undefined)
      this.date=new Date(params.date);
  });

    this.minDate=new Date();
    this.maxDate=new Date();

    if(this.date===undefined)
    {
    this.date=new Date();
    this.maxDate.setDate(this.maxDate.getDate()+6);
    }
    else
    this.maxDate.setDate(this.maxDate.getDate()+5);

    console.log(this.minDate)
    console.log(this.maxDate)
    
    this.refreshMealsList();
    this.refreshDaySummary();
    
  }

  dateClick(val){
    this.date.setDate(this.date.getDate()+val);
    this.date=new Date(this.date);
    this.refreshMealsList();
    this.refreshDaySummary();
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

  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;

  closeClickFromOutside(){
    this.ActivateDeleteMealComp=false;
    this.ActivateDetailsMealComp=false;
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
    this.refreshMealsList();
    this.refreshDaySummary();
  }

  closeClick(){
    this.ActivateDeleteMealComp=false;
    this.ActivateDetailsMealComp=false;
    this.refreshMealsList();
    this.refreshDaySummary();
  }

  refreshMealsList(){
    this.service.getMealsList(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
    this.MealsList=data;
    });
    }

    refreshDaySummary(){
      this.service.getDaySummary(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
        this.daySummary=data;
      });
      }

}

import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';
import { ToastrService } from 'ngx-toastr';
import { DatePipe } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-show-meals',
  templateUrl: './user-show-meals.component.html',
  styleUrls: ['./user-show-meals.component.css']
})
export class UserShowMealsComponent implements OnInit {

  constructor(private service:UserPlanService,private toastr: ToastrService,private datePipe: DatePipe,private router:Router) { }
  MealsList:any=[];
  date:Date;
  minDate:Date;
  maxDate:Date;
  public errorMessage: string = '';
  public showError: boolean;
  meal:any;
  ModalTitle:string;
  ActivateDeleteMealComp:boolean=false;

  ngOnInit(): void {
    this.minDate=new Date();
    this.date=new Date();
    this.maxDate=new Date();
    this.maxDate.setDate(this.maxDate.getDate()+6);
    this.refreshMealsList();
  }

  dateClick(val){
    this.date.setDate(this.date.getDate()+val);
    this.date=new Date(this.date);
    this.refreshMealsList();
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
    this.router.navigate(['/user-edit-meal', item.MealId]);
  }


  @ViewChild('mybutton') mybutton: ElementRef<HTMLElement>;

  closeClickFromOutside(){
    this.ActivateDeleteMealComp=false;
    let el: HTMLElement = this.mybutton.nativeElement;
    el.click();
    this.refreshMealsList();
  }

  closeClick(){
    this.ActivateDeleteMealComp=false;
    this.refreshMealsList();
  }

  refreshMealsList(){
    this.service.getMealsList(this.datePipe.transform(this.date, 'yyyy-MM-dd')).subscribe(data=>{
    this.MealsList=data;
    });
    }

}

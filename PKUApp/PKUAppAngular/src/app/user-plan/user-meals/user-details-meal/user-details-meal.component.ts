import { Component, Input, OnInit} from '@angular/core';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';
import { UserShowMealsComponent } from '../user-show-meals/user-show-meals.component'

@Component({
  selector: 'app-user-details-meal',
  templateUrl: './user-details-meal.component.html',
  styleUrls: ['./user-details-meal.component.css']
})
export class UserDetailsMealComponent implements OnInit {

  constructor(private service:UserPlanService,private closing:UserShowMealsComponent) { }

@Input()
meal

  pagepm:number=1;
  countpm:number=1;
  pageSizepm:number=1;
  MealProductsList:any=[];
  MealProductsSummary:any;
  mealid:number;

  ngOnInit(): void {
    this.mealid=this.meal.MealId;
    this.refreshMealProductsList();
    this.refreshMealSummary();
  }

  onPageChange2(event){
    this.pagepm=event;
    this.refreshMealProductsList();
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

  refreshMealProductsList(){
    this.service.getMealProductsList(this.mealid,this.pagepm).subscribe(data=>{
      this.MealProductsList=data.Items;
      this.pagepm=data.PageIndex;
      this.countpm=data.Count;
      this.pageSizepm=data.PageSize;
      this.refreshMealSummary();
    });
    }

    refreshMealSummary(){
      this.service.getMealSummary(this.mealid).subscribe(data=>{
        this.MealProductsSummary=data;
      });
      }

}

import { Component, OnInit, Input } from '@angular/core';
import { UserShowMealsComponent } from '../user-show-meals/user-show-meals.component'
import { ToastrService } from 'ngx-toastr';
import { UserPlanService } from 'src/app/shared/services/user-plan.service';

@Component({
  selector: 'app-user-delete-meal',
  templateUrl: './user-delete-meal.component.html',
  styleUrls: ['./user-delete-meal.component.css']
})
export class UserDeleteMealComponent implements OnInit {

  
    constructor(private closing:UserShowMealsComponent, private toastr: ToastrService, private service:UserPlanService) { }
  
    @Input() 
        meal:any;
  
    ngOnInit(): void {
    }
  
    Delete(){
      this.service.deleteMeal(this.meal.MealId).subscribe(_=>{
        this.closing.closeClickFromOutside();
        this.toastr.success("Deleted successfully", "Meal Management")});
    }
  
    Close(){
      this.closing.closeClickFromOutside();
    }
  }
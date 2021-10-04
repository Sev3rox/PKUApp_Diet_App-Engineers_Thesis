import { Component, Input, OnInit } from '@angular/core';
import { UserExercisePlanComponent } from 'src/app/user-exercise-plan/user-exercise-plan.component'

@Component({
  selector: 'app-user-exercise-plan-details-exercise',
  templateUrl: './user-exercise-plan-details-exercise.component.html',
  styleUrls: ['./user-exercise-plan-details-exercise.component.css']
})
export class UserExercisePlanDetailsExerciseComponent implements OnInit {

  constructor(private closing:UserExercisePlanComponent) { }

  @Input() 
      exercise:any;
      Name:string;
      Calories:number;

  ngOnInit(): void {
    this.Name=this.exercise.Name;
    this.Calories=this.exercise.Calories;
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}
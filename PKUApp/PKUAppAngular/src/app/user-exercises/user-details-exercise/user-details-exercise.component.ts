
import { Component, Input, OnInit } from '@angular/core';
import { UserShowExercisesComponent } from 'src/app/user-exercises/user-show-exercises/user-show-exercises.component'

@Component({
  selector: 'app-user-details-exercise',
  templateUrl: './user-details-exercise.component.html',
  styleUrls: ['./user-details-exercise.component.css']
})
export class UserDetailsExerciseComponent implements OnInit {

  constructor(private closing:UserShowExercisesComponent) { }

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
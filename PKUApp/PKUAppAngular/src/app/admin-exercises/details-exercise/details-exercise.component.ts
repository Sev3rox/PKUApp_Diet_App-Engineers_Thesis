import { Component, Input, OnInit } from '@angular/core';
import { ShowExercisesComponent } from 'src/app/admin-exercises/show-exercises/show-exercises.component'

@Component({
  selector: 'app-details-exercise',
  templateUrl: './details-exercise.component.html',
  styleUrls: ['./details-exercise.component.css']
})
export class DetailsExerciseComponent implements OnInit {

  constructor(private closing:ShowExercisesComponent) { }

  @Input() 
      exercise:any;
      ExerciseId:number;
      Name:string;
      Calories:number;

  ngOnInit(): void {
    this.ExerciseId=this.exercise.ExerciseId;
    this.Name=this.exercise.Name;
    this.Calories=this.exercise.Calories;
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}

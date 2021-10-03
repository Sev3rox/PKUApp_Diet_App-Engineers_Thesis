import { Component, Input, OnInit } from '@angular/core';
import { NotlogedShowExercisesComponent } from 'src/app/exercises/notloged-show-exercises/notloged-show-exercises.component'

@Component({
  selector: 'app-notloged-details-exercise',
  templateUrl: './notloged-details-exercise.component.html',
  styleUrls: ['./notloged-details-exercise.component.css']
})
export class NotlogedDetailsExerciseComponent implements OnInit {

  constructor(private closing:NotlogedShowExercisesComponent) { }

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

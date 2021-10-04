import { Component, OnInit, Input } from '@angular/core';
import { UserExercisePlanComponent } from '../user-exercise-plan.component'
import { ToastrService } from 'ngx-toastr';
import { UserExercisesService } from 'src/app/shared/services/user-exercises.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-user-exercise-plan-delete-exercise',
  templateUrl: './user-exercise-plan-delete-exercise.component.html',
  styleUrls: ['./user-exercise-plan-delete-exercise.component.css']
})
export class UserExercisePlanDeleteExerciseComponent implements OnInit {

  constructor(private closing:UserExercisePlanComponent, private toastr: ToastrService, private service:UserExercisesService, private datePipe: DatePipe) { }
  
  @Input() 
      exercise:any;
  @Input() 
      date:any;

  ngOnInit(): void {
  }

  Delete(){
    this.service.deleteExerciseToDay(this.datePipe.transform(this.date, 'yyyy-MM-dd'), this.exercise.ExerciseId).subscribe(_=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Deleted successfully", "Exercise Plan Management")});
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}

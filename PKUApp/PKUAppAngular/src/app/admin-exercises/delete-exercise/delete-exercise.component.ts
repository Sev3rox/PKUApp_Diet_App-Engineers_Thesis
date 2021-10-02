import { Component, Input, OnInit } from '@angular/core';
import { ShowExercisesComponent } from 'src/app/admin-exercises/show-exercises/show-exercises.component'
import { ToastrService } from 'ngx-toastr';
import { AdminExercisesService } from 'src/app/shared/services/admin-exercises.service';

@Component({
  selector: 'app-delete-exercise',
  templateUrl: './delete-exercise.component.html',
  styleUrls: ['./delete-exercise.component.css']
})
export class DeleteExerciseComponent implements OnInit {

  constructor(private closing:ShowExercisesComponent, private toastr: ToastrService, private service:AdminExercisesService) { }

  @Input() 
    exercise:any;

  ngOnInit(): void {
  }

  Delete(){
    this.service.deleteExercise(this.exercise.ExerciseId).subscribe(_=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Deleted successfully", "Exercise Management")});
  }
  
  Close(){
    this.closing.closeClickFromOutside();
  }
}

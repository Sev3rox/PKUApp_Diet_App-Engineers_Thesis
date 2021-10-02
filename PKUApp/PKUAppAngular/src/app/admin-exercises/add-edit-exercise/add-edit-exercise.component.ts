import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ShowExercisesComponent } from 'src/app/admin-exercises/show-exercises/show-exercises.component'
import { ToastrService } from 'ngx-toastr';
import { AdminExercisesService } from 'src/app/shared/services/admin-exercises.service';

@Component({
  selector: 'app-add-edit-exercise',
  templateUrl: './add-edit-exercise.component.html',
  styleUrls: ['./add-edit-exercise.component.css']
})
export class AddEditExerciseComponent implements OnInit {

  public exerciseForm: FormGroup;
  public errorMessage: string = '';
  public showError: boolean;
  
  constructor(private service:AdminExercisesService, private toastr: ToastrService, private closing:ShowExercisesComponent) { }

  @Input() 
      exercise:any;
      ExerciseId:number;
      Name:string;
      Calories:number;

  ngOnInit(): void {

      this.ExerciseId=this.exercise.ExerciseId;
      this.Name=this.exercise.Name;
      this.Calories=this.exercise.Calories/100;

      this.exerciseForm = new FormGroup({
        Name: new FormControl(this.Name, [Validators.required]),
        Calories: new FormControl(this.Calories, [Validators.required, Validators.min(1),Validators.max(1000)])
      })
    }

    addUpdateExercise(exerciseFormValue){
      if(this.ExerciseId==0)
      this.addExercise(exerciseFormValue);
      else
      this.updateExercise(exerciseFormValue);
    }

  addExercise(exerciseFormValue){
    this.showError = false;
    const exercise = {... exerciseFormValue };
    let val = { ExerciseId:this.ExerciseId,
                Name:exercise.Name,
                Calories:(Math.round((Math.round(exercise.Calories * 100) / 100)*100))}

    this.service.addExercise(val).subscribe(res=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Added successfully", "Exercise Management");
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  updateExercise(exerciseFormValue){
    this.showError = false;
    const exercise = {... exerciseFormValue };
    let val = { ExerciseId:this.ExerciseId,
                Name:exercise.Name,
                Calories:(Math.round((Math.round(exercise.Calories * 100) / 100)*100))}

    this.service.updateExercise(val).subscribe(res=>{
      this.closing.closeClickFromOutside();
      this.toastr.success("Updated successfully", "Exercise Management");
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.exerciseForm.controls[controlName].hasError(errorName)
  }

  public validateControl = (controlName: string) => {
    return this.exerciseForm.controls[controlName].invalid && this.exerciseForm.controls[controlName].touched
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}

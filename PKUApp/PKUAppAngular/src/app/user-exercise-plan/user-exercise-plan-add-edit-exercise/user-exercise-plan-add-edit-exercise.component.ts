  import { Component, OnInit, Input } from '@angular/core';
  import { UserExercisePlanComponent } from '../user-exercise-plan.component'
  import { ToastrService } from 'ngx-toastr';
  import { UserExercisesService } from 'src/app/shared/services/user-exercises.service';
  import { FormGroup, FormControl, Validators } from '@angular/forms';
  import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-user-exercise-plan-add-edit-exercise',
  templateUrl: './user-exercise-plan-add-edit-exercise.component.html',
  styleUrls: ['./user-exercise-plan-add-edit-exercise.component.css']
})
export class UserExercisePlanAddEditExerciseComponent implements OnInit {

  constructor(private closing:UserExercisePlanComponent, private datePipe: DatePipe, private toastr: ToastrService, private service:UserExercisesService) { }
  
  @Input() 
      exercise:any;
  @Input() 
      time:number;
  @Input() 
      date:any;
  @Input() 
      userId:string;
  @Input() 
      userExerciseId:string;

      public exerciseForm: FormGroup;
      public errorMessage: string = '';
      public showError: boolean;

  ngOnInit(): void {
    this.exerciseForm = new FormGroup({
      Time: new FormControl(this.time, [Validators.required, Validators.min(1), Validators.max(10000)]),
    })
  }

  addUpdateExercise(exerciseFormValue){
    if(this.time==0)
    this.Add(exerciseFormValue);
    else
    this.Update(exerciseFormValue);
  }

  Add(formValue){

    let val = {ExerciseId:this.exercise.Exercise.ExerciseId,
               Date:this.datePipe.transform(this.date, 'yyyy-MM-dd'),
               Time:(Math.round((Math.round(formValue.Time * 100) / 100)*100))}

    this.service.addExerciseToDay(val).subscribe(res=>{
      this.toastr.success("Added successfully", "Exercise Plan Management");
      this.closing.closeClickFromOutside();
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    });
  }

  Update(formValue){
    let val = {UserExerciseId:this.userExerciseId,
               ExerciseId:this.exercise.Exercise.ExerciseId,
               UserId:this.userId,
               Date:this.datePipe.transform(this.date, 'yyyy-MM-dd'),
               Time:(Math.round((Math.round(formValue.Time * 100) / 100)*100))}

    this.service.editExerciseToDay(val).subscribe(res=>{
      this.toastr.success("Edited successfully", "Exercise Plan Management");
      this.closing.closeClickFromOutside();
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

import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { UserProfileComponent } from '../user-profile.component'
import { UserService } from './../../shared/services/user.service';

@Component({
  selector: 'app-edit-user',
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent implements OnInit {

  constructor(private toastr: ToastrService, private closing:UserProfileComponent, private service:UserService) { }

  @Input()
  Name

  public userForm: FormGroup;
  public errorMessage: string = '';
  public showError: boolean;

  ngOnInit(): void {

    this.userForm = new FormGroup({
      Name: new FormControl(this.Name, [Validators.required]),
    })
  }

  editUser(formValue){
    this.service.editSettings(formValue.Name).subscribe(_=>{
      this.toastr.success("Edited successfully", "User Management");
      this.closing.closeClickFromOutside();
    });
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.userForm.controls[controlName].hasError(errorName)
  }

  public validateControl = (controlName: string) => {
    return this.userForm.controls[controlName].invalid && this.userForm.controls[controlName].touched
  }

  Close(){
    this.closing.closeClickFromOutside();
  }

}

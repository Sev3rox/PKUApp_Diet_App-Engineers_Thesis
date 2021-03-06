//Whole implementation of .NET Identity and JWT is inspired by the one that is pressented in https://docs.microsoft.com/en-us/documentation/ and other sites
//So Code that is used in this app that implements identity might be similar to other applications bacause it is almostly the same in all apps using it

import { Component, OnInit } from '@angular/core';
import { UserForRegistrationDto } from './../../_interfaces/userForRegistrationDto.model';
import { PasswordConfirmationValidatorService } from './../../shared/custom-validators/password-confirmation-validator.service';
import { AuthenticationService } from './../../shared/services/authentication.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-register-user',
  templateUrl: './register-user.component.html',
  styleUrls: ['./register-user.component.css']
})
export class RegisterUserComponent implements OnInit {

  constructor(private _authService: AuthenticationService, private _passConfValidator: PasswordConfirmationValidatorService,private _router: Router,
    private toastr: ToastrService) { }

  registerForm: FormGroup;
  public errorMessage: string = '';
  public showError: boolean;

  ngOnInit(): void {
    this.registerForm = new FormGroup({
      Name: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.minLength(6)]),
      confirm: new FormControl('')
    });

    this.registerForm.get('confirm')!.setValidators([Validators.required, this._passConfValidator.validateConfirmPassword(this.registerForm.get('password')!)]);
  }

  public validateControl = (controlName: string) => {
    return this.registerForm.controls[controlName].invalid && this.registerForm.controls[controlName].touched
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.registerForm.controls[controlName].hasError(errorName)
  }

  public registerUser = (registerFormValue) => {
    this.showError = false;
    const formValues = { ...registerFormValue };

    const user: UserForRegistrationDto = {
      Name: formValues.Name,
      email: formValues.email,
      password: formValues.password,
      confirmPassword: formValues.confirm
    };

    this._authService.registerUser("api/accounts/registration", user)
    .subscribe(_ =>{
      this._router.navigate(["/authentication/login"])
      this.toastr.success("Registered successfully", "Registration");
    },
    error => {this.errorMessage = error; this.showError = true}
    )
  }
}

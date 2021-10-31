//Whole implementation of .NET Identity and JWT is inspired by the one that is pressented in https://docs.microsoft.com/en-us/documentation/ and other sites
//So Code that is used in this app that implements identity might be similar to other applications bacause it is almostly the same in all apps using it

import { UserForAuthenticationDto } from './../../_interfaces/userForAuthenticationDto.model';
import { Router, ActivatedRoute } from '@angular/router';
import { AuthenticationService } from './../../shared/services/authentication.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  public loginForm: FormGroup;
  public errorMessage: string = '';
  public showError: boolean;
  private _returnUrl: string;

  constructor(private _authService: AuthenticationService, private _router: Router, private _route: ActivatedRoute,
    private toastr: ToastrService) { }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      username: new FormControl("", [Validators.required]),
      password: new FormControl("", [Validators.required])
    })

    this._returnUrl = this._route.snapshot.queryParams['returnUrl'] || '/';
  }

  public validateControl = (controlName: string) => {
    return this.loginForm.controls[controlName].invalid && this.loginForm.controls[controlName].touched
  }

  public hasError = (controlName: string, errorName: string) => {
    return this.loginForm.controls[controlName].hasError(errorName)
  }

  public loginUser = (loginFormValue) => {
    this.showError = false;
    const login = {... loginFormValue };
    const userForAuth: UserForAuthenticationDto = {
      email: login.username,
      password: login.password
    }

    this._authService.loginUser('api/accounts/login', userForAuth)
    .subscribe(res => {
       localStorage.setItem("token", res.Token);
       this._authService.sendAuthStateChangeNotification(res.IsAuthSuccessful);
       this._router.navigate([this._returnUrl]);
       this.toastr.success("Logged in successfully", "Logging In");
    },
    (error) => {
      this.errorMessage = error;
      this.showError = true;
    })
  }

}
//Whole implementation of .NET Identity and JWT is inspired by the one that is pressented in https://docs.microsoft.com/en-us/documentation/ and other sites
//So Code that is used in this app that implements identity might be similar to other applications bacause it is almostly the same in all apps using it

import { Injectable } from '@angular/core';
import { AbstractControl, ValidatorFn } from '@angular/forms';
@Injectable({
  providedIn: 'root'
})
export class PasswordConfirmationValidatorService {
  constructor() { }
  public validateConfirmPassword = (passwordControl: AbstractControl): ValidatorFn => {
    return (confirmationControl: AbstractControl) : { [key: string]: boolean } | null => {
      const confirmValue = confirmationControl.value;
      const passwordValue = passwordControl.value;
      if (confirmValue === '') {
          return null;
      }
      if (confirmValue !== passwordValue) {
          return  { mustMatch: true }
      } 
      return null;
    };
  }
}
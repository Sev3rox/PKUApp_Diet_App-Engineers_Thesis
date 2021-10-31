//Whole implementation of .NET Identity and JWT is inspired by the one that is pressented in https://docs.microsoft.com/en-us/documentation/ and other sites
//So Code that is used in this app that implements identity might be similar to other applications bacause it is almostly the same in all apps using it

import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { AuthenticationService } from '../services/authentication.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(private _authService: AuthenticationService, private _router: Router){}

  canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot) { 
    if (this._authService.isUserAuthenticated()) {
      return true;
    }

    this._router.navigate(['/authentication/login'], { queryParams: { returnUrl: state.url }});
    return false;
  }
  
}


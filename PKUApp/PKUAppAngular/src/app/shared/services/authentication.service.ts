import { AuthResponseDto } from './../../_interfaces/authResponseDto.model';
import { UserForAuthenticationDto } from './../../_interfaces/userForAuthenticationDto.model';
import { UserForRegistrationDto } from './../../_interfaces/userForRegistrationDto.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import { Subject } from 'rxjs';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  private _authChangeSub = new Subject<boolean>()
  public authChanged = this._authChangeSub.asObservable();

  constructor(private _http: HttpClient, private _jwtHelper: JwtHelperService) { }

  public registerUser = (route: string, body: UserForRegistrationDto) => {
    return this._http.post(this.createCompleteRoute(route, environment.urlAddress), body);
  }

  public loginUser = (route: string, body: UserForAuthenticationDto) => {
    console.log(route+"   "+body+"   "+environment.urlAddress)
    return this._http.post<AuthResponseDto>(this.createCompleteRoute(route, environment.urlAddress), body);
  }

  public logout = () => {
    localStorage.removeItem("token");
    this.sendAuthStateChangeNotification(false);
  }

  public sendAuthStateChangeNotification = (isAuthenticated: boolean) => {
    this._authChangeSub.next(isAuthenticated);
  }

  public isUserAuthenticated = (): boolean => {
    const token = localStorage.getItem("token");
 
    return (!!(token)) && (!this._jwtHelper.isTokenExpired(token));
  }

  public privacy = (route: string) =>{
    return this._http.get(this.createCompleteRoute(route,environment.urlAddress))
  }

  public createCompleteRoute = (route: string, envAddress: string) => {
    return `${envAddress}/${route}`;
  }
}

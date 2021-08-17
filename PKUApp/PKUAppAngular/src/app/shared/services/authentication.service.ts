import { AuthResponseDto } from './../../_interfaces/authResponseDto.model';
import { UserForAuthenticationDto } from './../../_interfaces/userForAuthenticationDto.model';
import { UserForRegistrationDto } from './../../_interfaces/userForRegistrationDto.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import { EnvironmentUrlService } from './environment-url.service';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  private _authChangeSub = new Subject<boolean>()
  public authChanged = this._authChangeSub.asObservable();

  constructor(private _http: HttpClient,) { }

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

  private createCompleteRoute = (route: string, envAddress: string) => {
    return `${envAddress}/${route}`;
  }
}

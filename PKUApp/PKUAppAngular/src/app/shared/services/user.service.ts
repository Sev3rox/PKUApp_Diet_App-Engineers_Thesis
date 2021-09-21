import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from './../../../environments/environment';
import {AuthenticationService} from './authentication.service'

@Injectable({
  providedIn: 'root'
})

export class UserService {

  readonly APIUrl=environment.urlAddress+"/api";
  constructor(private http: HttpClient, private _auth: AuthenticationService) { }

  public getName(){
    return this.http.get<any>(this.APIUrl+'/Accounts/GetName');
  }

  getLimits(){
    return this.http.get<any>(this.APIUrl+'/Accounts/GetLimits');
  }

  public isAdmin(){
    return this.http.get<any>(this.APIUrl+'/Accounts/isAdmin');
  }

  public editSettings(name:string){
    return this.http.put<any>(this.APIUrl+'/Accounts/ChangeSettings'+'?name='+name,null);
  }

  public editLimits(Limits:any){
    return this.http.put<any>(this.APIUrl+'/Accounts/ChangeLimits/'+Limits.UserDailyLimitsId,Limits);
  }
}

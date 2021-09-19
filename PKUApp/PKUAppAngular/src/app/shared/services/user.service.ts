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

  public isAdmin(){
    return this.http.get<any>(this.APIUrl+'/Accounts/isAdmin');
  }

  public editName(name){
    console.log(name)
    return this.http.put<any>(this.APIUrl+'/Accounts/ChangeName'+'?name='+name,null);
  }
}

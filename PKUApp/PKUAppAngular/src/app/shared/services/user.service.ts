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

  getMedicine(){
    return this.http.get<any>(this.APIUrl+'/Accounts/GetMedicine');
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

  public resetLimits(){
    return this.http.put<any>(this.APIUrl+'/Accounts/ResetLimits',null);
  }

  public addMedicine(med:any, date:any){
    return this.http.post<any>(this.APIUrl+'/Accounts/AddMedicine'+'?date='+date,med);
  }

  public deleteMedicine(id:any, date:any){
    return this.http.delete<any>(this.APIUrl+'/Accounts/DeleteMedicine'+'?date='+date+'&&'+'id='+id);
  }

  public editMedicine(med:any, date:any){
    return this.http.put<any>(this.APIUrl+'/Accounts/PutMedicine'+'?date='+date+'&&'+'id='+med.UserMedicineId,med);
  }

}

import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserTrackingService {
  readonly APIUrl=environment.urlAddress+"/api";
  constructor(private http:HttpClient) { }

  getWeightTracking(type:number, date:any){
    return this.http.get<any>(this.APIUrl+'/Track/GetCurrentRecord'+'?date='+date+'&&'+'type='+type);
  }

  getPheTracking(type:number, date:any){
    return this.http.get<any>(this.APIUrl+'/Track/GetCurrentRecord'+'?date='+date+'&&'+'type='+type);
  }

  addWeightTracking(val:any){
    return this.http.post<any>(this.APIUrl+'/Track',val);
  }

  addPheTracking(val:any){
    return this.http.post<any>(this.APIUrl+'/Track',val);
  }

  updateWeightTracking(id:number, value:number){
    return this.http.put<any>(this.APIUrl+'/Track'+'?id='+id+'&&'+'value='+value,null);
  }

  updatePheTracking(id:number, value:number){
    return this.http.put<any>(this.APIUrl+'/Track'+'?id='+id+'&&'+'value='+value,null);
  }

  getMessage(type:number, date:any){
    return this.http.get<any>(this.APIUrl+'/Track/GetMessage'+'?date='+date+'&&'+'type='+type);    
  }

  getChartData(type:number, date:any){
    return this.http.get<any>(this.APIUrl+'/Track'+'?date='+date+'&&'+'type='+type);
  }

}

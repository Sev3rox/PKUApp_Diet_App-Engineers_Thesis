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

  addWeightTracking(val:any){
    return this.http.post<any>(this.APIUrl+'/Track',val);
  }

  updateWeightTracking(id:number, value:number){
    return this.http.put<any>(this.APIUrl+'/Track'+'?id='+id+'&&'+'value='+value,null);
  }

  getPheTracking(type:number, date:any){
    return this.http.get<any>(this.APIUrl+'/Track/GetCurrentRecord'+'?date='+date+'&&'+'type='+type);
  }

  addPheTracking(val:any){
    return this.http.post<any>(this.APIUrl+'/Track',val);
  }

  updatePheTracking(id:number, value:number){
    return this.http.put<any>(this.APIUrl+'/Track'+'?id='+id+'&&'+'value='+value,null);
  }

  getChartData(type:number){
    return this.http.get<any>(this.APIUrl+'/Track'+'?type='+type);
  }
}

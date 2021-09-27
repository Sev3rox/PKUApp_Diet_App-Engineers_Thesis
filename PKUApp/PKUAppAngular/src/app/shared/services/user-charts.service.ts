import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserChartsService {
  readonly APIUrl=environment.urlAddress+"/api";
  constructor(private http:HttpClient) { }

  getChartData(date:any, chartType:string, chartDays:number){
    return this.http.get<any>(this.APIUrl+'/Charts'+'?date='+date+'&&'+'chartType='+chartType+'&&'+'chartDays='+chartDays);
  }
}

import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserPlanService {
  readonly APIUrl=environment.urlAddress+"/api";
  constructor(private http:HttpClient) { }

  getMealsList(date:any):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Meals'+'?date='+date);
  }

  addMeal(date:any){
    return this.http.post<any>(this.APIUrl+'/Meals'+'?date='+date, null);
  }

  deleteMeal(id:any){
    return this.http.delete(this.APIUrl+'/Meals/'+id);
  }
}

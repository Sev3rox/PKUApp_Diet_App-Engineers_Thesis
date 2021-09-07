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

  deleteMealProduct(mealid:number, productid:number){
    return this.http.delete(this.APIUrl+'/Meals/DeleteMealProducts'+'?mealid='+mealid+'&&'+'productid='+productid);
  }

  addProductToMeal(productid:number, weight:number, mealid:number){
    return this.http.post(this.APIUrl+'/Meals/AddProductToMeal'+'?productid='+productid+'&&'+'weight='+weight+'&&'+'mealid='+mealid ,null);
  }

  getMealProductsList(id:any):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Meals/GetMealProducts/'+id);
  }

}

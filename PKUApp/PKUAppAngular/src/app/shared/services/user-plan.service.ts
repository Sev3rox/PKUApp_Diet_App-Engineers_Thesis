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

  addProductToMeal(val:any){
    return this.http.post(this.APIUrl+'/Meals/AddProductToMeal',val);
  }

  editProductToMeal(val:any){
    return this.http.put(this.APIUrl+'/Meals/EditProductToMeal',val);
  }

  getMealProductsList(id:any,page:number):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Meals/GetMealProducts'+'?id='+id+'&&'+'page='+page);
  }
  
  getMealSummary(id:any){
    return this.http.get<any>(this.APIUrl+'/Meals/GetMealSummary/'+id);
  }

  getDaySummary(date:any){
    return this.http.get<any>(this.APIUrl+'/Meals/GetDaySummary'+'?date='+date);
  }

  getMeal(id:number){
    return this.http.get<any>(this.APIUrl+'/Meals/'+id);
  }

  getOffAlerts(date:any){
    return this.http.get<any>(this.APIUrl+'/Meals/GetOffAlerts'+'?date='+date);
  }

  addOffAlerts(date:any){
    return this.http.post<any>(this.APIUrl+'/Meals/AddOffAlerts'+'?date='+date, null);
  }

  getDayMed(date:any){
    return this.http.get<any>(this.APIUrl+'/Meals/GetDayMedicine'+'?date='+date);
  }
}

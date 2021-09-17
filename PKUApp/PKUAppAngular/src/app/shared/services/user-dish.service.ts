import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserDishService {
  readonly APIUrl=environment.urlAddress+"/api";
  constructor(private http:HttpClient) { }

  deleteDishProduct(productid:number){
    return this.http.delete(this.APIUrl+'/Dish/DeleteDishProducts'+'?productid='+productid);
  }

  addProductToDish(val:any){
    return this.http.post(this.APIUrl+'/Dish/AddProductToDish',val);
  }

  editProductToDish(val:any){
    return this.http.put(this.APIUrl+'/Dish/EditProductToDish',val);
  }

  getDishProductsList(page:number):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Dish/GetDishProducts'+'?page='+page);
  }
  
  getDishSummary(){
    return this.http.get<any>(this.APIUrl+'/Dish/GetDishSummary');
  }

  deleteAllDishProducts(){
    return this.http.delete(this.APIUrl+'/Dish/DeleteAllDishProducts');
  }

  createDish(name:string){
    return this.http.post(this.APIUrl+'/Dish/CreateDish'+'?name='+name,null);
  }
}

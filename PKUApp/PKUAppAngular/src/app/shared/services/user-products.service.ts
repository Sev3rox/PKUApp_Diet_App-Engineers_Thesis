import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserProductsService {
  readonly APIUrl=environment.urlAddress+"/api";
  constructor(private http:HttpClient) { }

  getProductsList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Products/GetUserProducts');
  }

  getOwnProductsList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Products/GetUserOwnProducts');
  }

  deleteProduct(val:any){
    return this.http.delete(this.APIUrl+'/Products/OwnDelete/'+val);
  }

  addProduct(val:any){
    return this.http.post(this.APIUrl+'/Products/OwnAdd',val);
  }

  updateProduct(val:any){
    return this.http.put(this.APIUrl+'/Products/OwnUpdate/'+val.ProductId,val);
  }

  getAllCategoriesNames(){
    return this.http.get<any>(this.APIUrl+'/Products/GetAllCategories');
  }
}
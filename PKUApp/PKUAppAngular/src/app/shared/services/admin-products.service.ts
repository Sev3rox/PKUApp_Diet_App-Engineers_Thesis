import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AdminProductsService {
  readonly APIUrl=environment.urlAddress+"/api";
  constructor(private http:HttpClient) { }

  getProductsList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Products');
  }

  addProduct(val:any){
    return this.http.post(this.APIUrl+'/Products',val);
  }

  updateProduct(val:any){
    return this.http.put(this.APIUrl+'/Products/'+val.ProductId,val);
  }

  deleteProduct(val:any){
    return this.http.delete(this.APIUrl+'/Products/'+val);
  }
}

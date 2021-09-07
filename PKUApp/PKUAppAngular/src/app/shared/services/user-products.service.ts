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

  getProductsList(search:string, sort:string, asc:boolean, cat:string, page:number):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Products/GetUserProducts'+'?search='+search+'&&'+'sort='+sort+'&&'+'asc='+asc+'&&'+'cat='+cat+'&&'+'page='+page);
  }

  getMealProductsList(search:string, sort:string, asc:boolean, cat:string, page:number, id:number):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Products/GetUserMealProducts'+'?search='+search+'&&'+'sort='+sort+'&&'+'asc='+asc+'&&'+'cat='+cat+'&&'+'page='+page+'&&'+'id='+id);
  }

  getFavProductsList(search:string, sort:string, asc:boolean, cat:string, page:number):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Products/GetUserFavProducts'+'?search='+search+'&&'+'sort='+sort+'&&'+'asc='+asc+'&&'+'cat='+cat+'&&'+'page='+page);
  }

  getOwnProductsList(search:string, sort:string, asc:boolean, cat:string, page:number):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Products/GetUserOwnProducts'+'?search='+search+'&&'+'sort='+sort+'&&'+'asc='+asc+'&&'+'cat='+cat+'&&'+'page='+page);
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

  addFavProduct(val:any){
    return this.http.post(this.APIUrl+'/Products/AddFav/'+val,null);
  }

  deleteFavProduct(val:any){
    return this.http.delete(this.APIUrl+'/Products/DeleteFav/'+val);
  }
  getAllCategoriesNames(){
    return this.http.get<any>(this.APIUrl+'/Products/GetAllCategories');
  }
}

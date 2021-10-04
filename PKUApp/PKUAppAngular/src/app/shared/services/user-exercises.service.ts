import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserExercisesService {
  readonly APIUrl=environment.urlAddress+"/api";
  constructor(private http:HttpClient) { }

  getExercisesList( date:any, search:string, sort:string, asc:boolean, page:number):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Exercises/GetUserExercises'+'?date='+date+'&&'+'search='+search+'&&'+'sort='+sort+'&&'+'asc='+asc+'&&'+'page='+page);
  }

  addExerciseToDay(val:any){
    return this.http.post(this.APIUrl+'/Exercises/AddExerciseToDay',val);
  }

  editExerciseToDay(val:any){
    return this.http.put(this.APIUrl+'/Exercises/EditExerciseToDay',val);
  }

}

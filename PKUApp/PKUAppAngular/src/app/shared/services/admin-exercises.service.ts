import { Injectable } from '@angular/core';
import { environment } from './../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AdminExercisesService {
  readonly APIUrl=environment.urlAddress+"/api";
  constructor(private http:HttpClient) { }

  getExercisesList(search:string, sort:string, asc:boolean, page:number):Observable<any>{
    return this.http.get<any>(this.APIUrl+'/Exercises'+'?search='+search+'&&'+'sort='+sort+'&&'+'asc='+asc+'&&'+'page='+page);
  }

  addExercise(val:any){
    return this.http.post(this.APIUrl+'/Exercises',val);
  }

  updateExercise(val:any){
    return this.http.put(this.APIUrl+'/Exercises/'+val.ExerciseId,val);
  }

  deleteExercise(val:any){
    return this.http.delete(this.APIUrl+'/Exercises/'+val);
  }

}
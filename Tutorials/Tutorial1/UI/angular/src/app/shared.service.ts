  
import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import { Payment } from 'src/payment.model';


@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="http://localhost:44460/api";
readonly PhotoUrl = "http://localhost:44460/Photos/";

  constructor(private http:HttpClient) { }

  formData:Payment=new Payment();
  list: Payment[];

  getDepList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Departments');
  }

  addDepartment(val:any){
    return this.http.post(this.APIUrl+'/Departments',val);
  }

  updateDepartment(val:any){
    return this.http.put(this.APIUrl+'/Departments/'+val.DepartmentId,val);
  }

  deleteDepartment(val:any){
    return this.http.delete(this.APIUrl+'/Departments/'+val);
  }



  getEmpList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Employees');
  }

  addEmployee(val:any){
    return this.http.post(this.APIUrl+'/Employees',val);
  }

  updateEmployee(val:any){
    return this.http.put(this.APIUrl+'/Employees/'+val.EmployeeId,val);
  }

  deleteEmployee(val:any){
    return this.http.delete(this.APIUrl+'/Employees/'+val);
  }



  UploadPhoto(val:any){
    return this.http.post(this.APIUrl+'/Employees/SaveFile',val);
  }

  getAllDepartmentNames():Observable<any[]>{
    return this.http.get<any[]>(this.APIUrl+'/Employees/GetAllDepartmentNames');
  }



  refreshlist(){
    this.http.get((this.APIUrl+'/Payments'))
    .toPromise()
    .then(res=>this.list=res as Payment[]);
  }

  postPayment(){
    return this.http.post(this.APIUrl+'/Payments',this.formData);
  }

  putPayment(){
    return this.http.put(this.APIUrl+'/Payments/'+this.formData.PaymentId,this.formData);
  }

  deletePayment(val:any){
    return this.http.delete(this.APIUrl+'/Payments/'+val);
  }
}
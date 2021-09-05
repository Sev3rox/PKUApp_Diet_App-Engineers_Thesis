import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ErrorHandlerService implements HttpInterceptor {

  constructor(private _router: Router) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(req)
    .pipe(
      catchError((error: HttpErrorResponse) => {
        let errorMessage = this.handleError(error);
        return throwError(errorMessage);
      })
    )
  }

  private handleError = (error: HttpErrorResponse) : string => {
    if(error.status === 404){
      return this.handleNotFound(error);
    }
    else if(error.status === 401) {
      return this.handleUnauthorized(error);
    }
    else if(error.status === 403) {
      return this.handleForbidden(error);
    }
    else {
      return this.handleBadRequest(error);
    }
    
  }
  private handleNotFound = (error: HttpErrorResponse): string => {
    this._router.navigate(['/404']);
    return error.message;
  }

  private handleUnauthorized = (error: HttpErrorResponse) => {
    if(this._router.url.includes('/authentication/login')) {
      return 'Authentication failed. Wrong Email or Password';
    }
    else {
      this._router.navigate(['/authentication/login'], { queryParams: { returnUrl: this._router.url }});
      return error.message;
    }
  }

  private handleForbidden = (error: HttpErrorResponse) => {
    this._router.navigate(["/forbidden"], { queryParams: { returnUrl: this._router.url }});
    return "Forbidden";
  }

  private handleBadRequest = (error: HttpErrorResponse): string => {
    if(this._router.url === '/authentication/register'){
      let message = '';
      const values = Object.values(error.error.Errors);
      values.map((m: any) => {
         message += m + '<br>';
      })
      return message.slice(0, -4);
    }
    else if(this._router.url.includes('/admin-products')){
      let message = '';
      if(error.error.errors!=undefined){
      const values = Object.values(error.error.errors);
      values.map((m: any) => {
         message += m + '<br>';
      })}
      if(error.error.errors===undefined&&error.error.Name!=undefined){
      message+=error.error.Name;
      return message;
      }

      return message.slice(0, -4);
    }
    else if(this._router.url.includes('/own-products')){
      let message = '';
      if(error.error.errors!=undefined){
      const values = Object.values(error.error.errors);
      values.map((m: any) => {
         message += m + '<br>';
      })}
      if(error.error.errors===undefined&&error.error.Name!=undefined){
      message+=error.error.Name;
      return message;
      }

      return message.slice(0, -4);
    }
    else if(this._router.url.includes('/user-plan')){
      let message = '';
      if(error.error.errors!=undefined){
      const values = Object.values(error.error.errors);
      values.map((m: any) => {
         message += m + '<br>';
      })}
      if(error.error.errors===undefined&&error.error.Count!=undefined){
      message+=error.error.Count;
      return message;
      }

      return message.slice(0, -4);
    }
    else
    return error.error ? error.error : error.message;
  }
}

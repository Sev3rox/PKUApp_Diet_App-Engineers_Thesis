import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandlerService } from './shared/services/error-handler.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtModule } from "@auth0/angular-jwt";
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {NgxPaginationModule} from 'ngx-pagination';
import { DatePipe } from '@angular/common';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { HomeComponent } from './home/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegisterUserComponent } from './authentication/register-user/register-user.component';
import { NotFoundComponent } from './error-pages/not-found/not-found.component';
import { LoginComponent } from './authentication/login/login.component';
import { environment } from 'src/environments/environment';
import { ForbiddenComponent } from './forbidden/forbidden.component';
import { AdminProductsComponent } from './admin-products/admin-products.component';
import { ShowProductsComponent } from './admin-products/show-products/show-products.component';
import { AddEditProductComponent } from './admin-products/add-edit-product/add-edit-product.component';
import { DetailsProductComponent } from './admin-products/details-product/details-product.component';
import { DeleteProductComponent } from './admin-products/delete-product/delete-product.component';
import { UserProductsComponent } from './user-products/user-products.component';
import { OwnProductsComponent } from './user-products/own-products/own-products.component';
import { UserDetailsProductComponent } from './user-products/user-details-product/user-details-product.component';
import { UserShowProductsComponent } from './user-products/user-show-products/user-show-products.component';
import { OwnAddEditProductComponent } from './user-products/own-products/own-add-edit-product/own-add-edit-product.component';
import { OwnDeleteProductComponent } from './user-products/own-products/own-delete-product/own-delete-product.component';
import { OwnDetailsProductComponent } from './user-products/own-products/own-details-product/own-details-product.component';
import { OwnShowProductsComponent } from './user-products/own-products/own-show-products/own-show-products.component';
import { ProductsComponent } from './products/products.component';
import { NotlogedShowProductsComponent } from './products/notloged-show-products/notloged-show-products.component';
import { NotlogedDetailsProductComponent } from './products/notloged-details-product/notloged-details-product.component';
import { FavProductsComponent } from './user-products/fav-products/fav-products.component';
import { FavShowProductsComponent } from './user-products/fav-products/fav-show-products/fav-show-products.component';
import { FavDetailsProductsComponent } from './user-products/fav-products/fav-details-products/fav-details-products.component';
import { UserPlanComponent } from './user-plan/user-plan.component';
import { UserMealsComponent } from './user-plan/user-meals/user-meals.component';
import { UserShowMealsComponent } from './user-plan/user-meals/user-show-meals/user-show-meals.component';
import { UserAddEditMealComponent } from './user-plan/user-meals/user-add-edit-meal/user-add-edit-meal.component';
import { UserDeleteMealComponent } from './user-plan/user-meals/user-delete-meal/user-delete-meal.component';
import { UserEditMealComponent } from './user-plan/user-meals/user-edit-meal/user-edit-meal.component';
import { UserMealDetailsProductComponent } from './user-plan/user-meals/user-meal-details-product/user-meal-details-product.component';
import { UserDeleteProductMealComponent } from './user-plan/user-meals/user-delete-product-meal/user-delete-product-meal.component';

export function tokenGetter() {
  return localStorage.getItem("token");
}

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    HomeComponent,
    RegisterUserComponent,
    NotFoundComponent,
    LoginComponent,
    ForbiddenComponent,
    AdminProductsComponent,
    ShowProductsComponent,
    AddEditProductComponent,
    DetailsProductComponent,
    DeleteProductComponent,
    UserProductsComponent,
    OwnProductsComponent,
    UserDetailsProductComponent,
    UserShowProductsComponent,
    OwnAddEditProductComponent,
    OwnDeleteProductComponent,
    OwnDetailsProductComponent,
    OwnShowProductsComponent,
    ProductsComponent,
    NotlogedShowProductsComponent,
    NotlogedDetailsProductComponent,
    FavProductsComponent,
    FavShowProductsComponent,
    FavDetailsProductsComponent,
    UserPlanComponent,
    UserMealsComponent,
    UserShowMealsComponent,
    UserAddEditMealComponent,
    UserDeleteMealComponent,
    UserEditMealComponent,
    UserMealDetailsProductComponent,
    UserDeleteProductMealComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    HttpClientModule,
    NgxPaginationModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: [environment.urlAddress2],
        disallowedRoutes: []
      }
    }),
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      positionClass :'toast-bottom-right'
    })
  ],
  providers: [
    DatePipe,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: ErrorHandlerService,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

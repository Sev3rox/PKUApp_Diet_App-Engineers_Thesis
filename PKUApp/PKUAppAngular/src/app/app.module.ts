import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandlerService } from './shared/services/error-handler.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtModule } from "@auth0/angular-jwt";
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { HomeComponent } from './home/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegisterUserComponent } from './authentication/register-user/register-user.component';
import { NotFoundComponent } from './error-pages/not-found/not-found.component';
import { LoginComponent } from './authentication/login/login.component';
import { environment } from 'src/environments/environment';
import { ProductComponent } from './products/product/product.component';
import { PrivacyComponent } from './privacy/privacy.component';
import { ForbiddenComponent } from './forbidden/forbidden.component';
import { AdminProductsComponent } from './admin-products/admin-products.component';
import { ShowProductsComponent } from './admin-products/show-products/show-products.component';
import { AddEditProductComponent } from './admin-products/add-edit-product/add-edit-product.component';
import { DetailsProductComponent } from './admin-products/details-product/details-product.component';
import { DeleteProductComponent } from './admin-products/delete-product/delete-product.component';

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
    ProductComponent,
    PrivacyComponent,
    ForbiddenComponent,
    AdminProductsComponent,
    ShowProductsComponent,
    AddEditProductComponent,
    DetailsProductComponent,
    DeleteProductComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    HttpClientModule,
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
    {
      provide: HTTP_INTERCEPTORS,
      useClass: ErrorHandlerService,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

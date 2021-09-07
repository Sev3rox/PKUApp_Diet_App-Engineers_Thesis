import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './error-pages/not-found/not-found.component';
import { HomeComponent } from './home/home.component';
import { RegisterUserComponent } from './authentication/register-user/register-user.component';
import { LoginComponent } from './authentication/login/login.component';
import { AuthGuard } from './shared/guards/auth.guard';
import { AdminGuard } from './shared/guards/admin.guard';
import { ForbiddenComponent } from './forbidden/forbidden.component';
import { AdminProductsComponent } from './admin-products/admin-products.component';
import { UserProductsComponent } from './user-products/user-products.component';
import { OwnProductsComponent } from './user-products/own-products/own-products.component';
import { ProductsComponent } from './products/products.component';
import { FavProductsComponent } from './user-products/fav-products/fav-products.component';
import { UserPlanComponent } from './user-plan/user-plan.component';
import { UserEditMealComponent } from './user-plan/user-meals/user-edit-meal/user-edit-meal.component';


const routes: Routes = [
  { path: 'home',component : HomeComponent},
  { path: '404', component : NotFoundComponent},
  { path: 'products', component : ProductsComponent},
  { path: 'admin-products', component: AdminProductsComponent, canActivate: [AuthGuard, AdminGuard] },
  { path: 'user-products', component: UserProductsComponent, canActivate: [AuthGuard] },
  { path: 'own-products', component: OwnProductsComponent, canActivate: [AuthGuard] },
  { path: 'fav-products', component: FavProductsComponent, canActivate: [AuthGuard] },
  { path: 'user-plan', component: UserPlanComponent, canActivate: [AuthGuard] },
  { path: 'user-edit-meal/:id', component: UserEditMealComponent, canActivate: [AuthGuard] },
  { path: 'forbidden', component: ForbiddenComponent },
  { path: 'authentication/register', component : RegisterUserComponent},
  { path: 'authentication/login', component : LoginComponent},
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: '**', redirectTo: '/404', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

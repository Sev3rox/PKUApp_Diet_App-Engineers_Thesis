//Created on Wydział Informatyki Politechniki Białostockiej
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
import { AdminExercisesComponent } from './admin-exercises/admin-exercises.component';
import { UserProductsComponent } from './user-products/user-products.component';
import { UserExercisesComponent } from './user-exercises/user-exercises.component';
import { OwnProductsComponent } from './user-products/own-products/own-products.component';
import { ProductsComponent } from './products/products.component';
import { ExercisesComponent } from './exercises/exercises.component';
import { UserPlanComponent } from './user-plan/user-plan.component';
import { UserExercisePlanComponent } from "./user-exercise-plan/user-exercise-plan.component"
import { UserEditMealComponent } from './user-plan/user-meals/user-edit-meal/user-edit-meal.component';
import { UserDishComponent } from './user-dish/user-dish.component';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { UserChartsComponent } from "./user-charts/user-charts.component"
import { UserExerciseChartComponent } from "./user-exercise-chart/user-exercise-chart.component"
import { UserTrackingComponent } from "./user-tracking/user-tracking.component"


const routes: Routes = [
  { path: 'home',component : HomeComponent},
  { path: '404', component : NotFoundComponent},
  { path: 'products', component : ProductsComponent},
  { path: 'exercises', component : ExercisesComponent},
  { path: 'admin-products', component: AdminProductsComponent, canActivate: [AuthGuard, AdminGuard] },
  { path: 'admin-exercises', component: AdminExercisesComponent, canActivate: [AuthGuard, AdminGuard] },
  { path: 'user-products', component: UserProductsComponent, canActivate: [AuthGuard] },
  { path: 'own-products', component: OwnProductsComponent, canActivate: [AuthGuard] },
  { path: 'user-exercises', component: UserExercisesComponent, canActivate: [AuthGuard] },
  { path: 'user-plan', component: UserPlanComponent, canActivate: [AuthGuard] },
  { path: 'user-exercise-plan', component: UserExercisePlanComponent, canActivate: [AuthGuard] },
  { path: 'user-edit-meal', component: UserEditMealComponent, canActivate: [AuthGuard] },
  { path: 'user-dish', component: UserDishComponent, canActivate: [AuthGuard] },
  { path: 'user-profile', component: UserProfileComponent, canActivate: [AuthGuard] },
  { path: 'user-charts', component: UserChartsComponent, canActivate: [AuthGuard] },
  { path: 'user-exercise-charts', component: UserExerciseChartComponent, canActivate: [AuthGuard] },
  { path: 'user-tracking', component: UserTrackingComponent, canActivate: [AuthGuard] },
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

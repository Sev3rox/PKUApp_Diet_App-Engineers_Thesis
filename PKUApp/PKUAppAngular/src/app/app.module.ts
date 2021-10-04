import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandlerService } from './shared/services/error-handler.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtModule } from "@auth0/angular-jwt";
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {NgxPaginationModule} from 'ngx-pagination';
import { DatePipe } from '@angular/common';
import { NgxChartsModule } from '@swimlane/ngx-charts';

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
import { UserPlanComponent } from './user-plan/user-plan.component';
import { UserMealsComponent } from './user-plan/user-meals/user-meals.component';
import { UserShowMealsComponent } from './user-plan/user-meals/user-show-meals/user-show-meals.component';
import { UserDeleteMealComponent } from './user-plan/user-meals/user-delete-meal/user-delete-meal.component';
import { UserEditMealComponent } from './user-plan/user-meals/user-edit-meal/user-edit-meal.component';
import { UserMealDetailsProductComponent } from './user-plan/user-meals/user-edit-meal/user-meal-details-product/user-meal-details-product.component';
import { UserDeleteProductMealComponent } from './user-plan/user-meals/user-edit-meal/user-delete-product-meal/user-delete-product-meal.component';
import { UserAddEditProductMealComponent } from './user-plan/user-meals/user-edit-meal/user-add-edit-product-meal/user-add-edit-product-meal.component';
import { UserMealSummaryDetailsComponent } from './user-plan/user-meals/user-edit-meal/user-meal-summary-details/user-meal-summary-details.component';
import { UserProductInMealDetailsComponent } from './user-plan/user-meals/user-edit-meal/user-product-in-meal-details/user-product-in-meal-details.component';
import { UserDetailsMealComponent } from './user-plan/user-meals/user-details-meal/user-details-meal.component';
import { UserDishComponent } from './user-dish/user-dish.component';
import { UserAddEditProductDishComponent } from './user-dish/user-add-edit-product-dish/user-add-edit-product-dish.component';
import { UserDeleteProductDishComponent } from './user-dish/user-delete-product-dish/user-delete-product-dish.component';
import { UserDishDetailsProductComponent } from './user-dish/user-dish-details-product/user-dish-details-product.component';
import { UserDishSummaryDetailsComponent } from './user-dish/user-dish-summary-details/user-dish-summary-details.component';
import { UserProductInDishDetailsComponent } from './user-dish/user-product-in-dish-details/user-product-in-dish-details.component';
import { UserDeleteAllProductsDishComponent } from './user-dish/user-delete-all-products-dish/user-delete-all-products-dish.component';
import { UserCreateDishComponent } from './user-dish/user-create-dish/user-create-dish.component';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { EditLimitsComponent } from './user-profile/edit-limits/edit-limits.component';
import { EditUserComponent } from './user-profile/edit-user/edit-user.component';
import { UserDailySummaryComponent } from './user-plan/user-meals/user-edit-meal/user-daily-summary/user-daily-summary.component';
import { UserChartsComponent } from './user-charts/user-charts.component';
import { UserDayAlertsComponent } from './user-plan/user-meals/user-day-alerts/user-day-alerts.component';
import { ResetLimitsComponent } from './user-profile/reset-limits/reset-limits.component';
import { AddEditMedComponent } from './user-profile/add-edit-med/add-edit-med.component';
import { DelMedComponent } from './user-profile/del-med/del-med.component';
import { UserDetailsMedComponent } from './user-plan/user-meals/user-details-med/user-details-med.component';
import { UserTrackingComponent } from './user-tracking/user-tracking.component';
import { AdminExercisesComponent } from './admin-exercises/admin-exercises.component';
import { AddEditExerciseComponent } from './admin-exercises/add-edit-exercise/add-edit-exercise.component';
import { DeleteExerciseComponent } from './admin-exercises/delete-exercise/delete-exercise.component';
import { DetailsExerciseComponent } from './admin-exercises/details-exercise/details-exercise.component';
import { ShowExercisesComponent } from './admin-exercises/show-exercises/show-exercises.component';
import { ExercisesComponent } from './exercises/exercises.component';
import { NotlogedDetailsExerciseComponent } from './exercises/notloged-details-exercise/notloged-details-exercise.component';
import { NotlogedShowExercisesComponent } from './exercises/notloged-show-exercises/notloged-show-exercises.component';
import { UserExercisesComponent } from './user-exercises/user-exercises.component';
import { UserDetailsExerciseComponent } from './user-exercises/user-details-exercise/user-details-exercise.component';
import { UserShowExercisesComponent } from './user-exercises/user-show-exercises/user-show-exercises.component';
import { UserExercisePlanComponent } from './user-exercise-plan/user-exercise-plan.component';
import { UserExercisePlanDetailsExerciseComponent } from './user-exercise-plan/user-exercise-plan-details-exercise/user-exercise-plan-details-exercise.component';
import { UserExercisePlanAddEditExerciseComponent } from './user-exercise-plan/user-exercise-plan-add-edit-exercise/user-exercise-plan-add-edit-exercise.component';
import { UserExercisePlanDeleteExerciseComponent } from './user-exercise-plan/user-exercise-plan-delete-exercise/user-exercise-plan-delete-exercise.component';
import { UserExercisePlanDetailsOnExerciseComponent } from './user-exercise-plan/user-exercise-plan-details-on-exercise/user-exercise-plan-details-on-exercise.component';

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
    UserPlanComponent,
    UserMealsComponent,
    UserShowMealsComponent,
    UserDeleteMealComponent,
    UserEditMealComponent,
    UserMealDetailsProductComponent,
    UserDeleteProductMealComponent,
    UserAddEditProductMealComponent,
    UserMealSummaryDetailsComponent,
    UserProductInMealDetailsComponent,
    UserDetailsMealComponent,
    UserDishComponent,
    UserAddEditProductDishComponent,
    UserDeleteProductDishComponent,
    UserDishDetailsProductComponent,
    UserDishSummaryDetailsComponent,
    UserProductInDishDetailsComponent,
    UserDeleteAllProductsDishComponent,
    UserCreateDishComponent,
    UserProfileComponent,
    EditLimitsComponent,
    EditUserComponent,
    UserDailySummaryComponent,
    UserChartsComponent,
    UserDayAlertsComponent,
    ResetLimitsComponent,
    AddEditMedComponent,
    DelMedComponent,
    UserDetailsMedComponent,
    UserTrackingComponent,
    AdminExercisesComponent,
    AddEditExerciseComponent,
    DeleteExerciseComponent,
    DetailsExerciseComponent,
    ShowExercisesComponent,
    ExercisesComponent,
    NotlogedDetailsExerciseComponent,
    NotlogedShowExercisesComponent,
    UserExercisesComponent,
    UserDetailsExerciseComponent,
    UserShowExercisesComponent,
    UserExercisePlanComponent,
    UserExercisePlanDetailsExerciseComponent,
    UserExercisePlanAddEditExerciseComponent,
    UserExercisePlanDeleteExerciseComponent,
    UserExercisePlanDetailsOnExerciseComponent,

  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    HttpClientModule,
    NgxPaginationModule,
    NgxChartsModule,
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

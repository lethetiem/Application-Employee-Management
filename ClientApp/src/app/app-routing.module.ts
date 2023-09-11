import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CompanyListComponent } from './Pages/Company/company-list/company-list.component';
import { HomeComponent } from './Pages/Home/home/home.component';
import { EmployeeListComponent } from './Pages/Employees/employee-list/employee-list.component';
import { EmployeeAddComponent } from './Pages/Employees/employee-add/employee-add.component';
import { EmployeeUpdateComponent } from './Pages/Employees/employee-update/employee-update.component';
import { LoginFormComponent } from './Pages/Login/login-form/login-form.component';
import { RegisterComponent } from './Pages/Register/register.component';
import { AuthGuard } from './Guards/auth.guard';

const routes: Routes = [
  {
    path: 'Home',
    component: HomeComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'Employees',
    component: EmployeeListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'Company',
    component: CompanyListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'Employees/Add',
    component: EmployeeAddComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'Employees/Update/:id',
    component: EmployeeUpdateComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'login',
    component: LoginFormComponent,
  },
  {
    path: 'signup',
    component: RegisterComponent,
  },
  {
    path: '**',
    redirectTo: 'Home',
    // canActivate: [AuthGuard],
  },
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

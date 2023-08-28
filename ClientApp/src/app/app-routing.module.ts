import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CompanyListComponent } from './Pages/Company/company-list/company-list.component';
import { HomeComponent } from './Pages/Home/home/home.component';
import { EmployeeListComponent } from './Pages/Employees/employee-list/employee-list.component';
import { EmployeeAddComponent } from './Pages/Employees/employee-add/employee-add.component';
import { EmployeeUpdateComponent } from './Pages/Employees/employee-update/employee-update.component';
import { LoginFormComponent } from './Pages/Login/login-form/login-form.component';
import { RegisterComponent } from './Pages/Register/register.component';

const routes: Routes = [
  {
    path: 'Home',
    component: HomeComponent
  },
  {
    path: 'Employees',
    component: EmployeeListComponent
  },
  {
    path: 'Company',
    component: CompanyListComponent
  },
  {
    path: 'Employees/Add',
    component: EmployeeAddComponent
  },
  {
    path: 'Employees/Update/:id',
    component: EmployeeUpdateComponent
  },
  {
    path: '',
    component: LoginFormComponent
  },
  {
    path: 'signup',
    component: RegisterComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

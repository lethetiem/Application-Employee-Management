import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CompanyListComponent } from './Pages/Company/company-list/company-list.component';
import { HomeComponent } from './Pages/Home/home/home.component';
import { EmployeeListComponent } from './Pages/Employees/employee-list/employee-list.component';
import { EmployeeAddComponent } from './Pages/Employees/employee-add/employee-add.component';

const routes: Routes = [
  {
    path: '',
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
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

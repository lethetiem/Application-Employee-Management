import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FooterBuildComponent } from './Containers/Footer/footer-build/footer-build.component';
import { HomeComponent } from './Pages/Home/home/home.component';
import { EmployeeListComponent } from './Pages/Employees/employee-list/employee-list.component';
import { CompanyListComponent } from './Pages/Company/company-list/company-list.component';
import { NavbarComponent } from './Components/Navbar/navbar/navbar.component';
import { EmployeeAddComponent } from './Pages/Employees/employee-add/employee-add.component';
import { EmployeeUpdateComponent } from './Pages/Employees/employee-update/employee-update.component';
import { LoginFormComponent } from './Pages/Login/login-form/login-form.component';
import { RegisterComponent } from './Pages/Register/register.component';
import { DeleteDialogsComponent } from './Pages/Dialogs/delete-dialogs/delete-dialogs.component';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from './app-routing.module';

import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatTableModule } from '@angular/material/table';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatListModule } from '@angular/material/list';
import { MatOptionModule } from '@angular/material/core';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatSelectModule } from '@angular/material/select';
import { MatRadioModule } from '@angular/material/radio';

// import { MatSlideToggleModule } from '@angular/material/slide-toggle';
// import { MatTableModule } from '@angular/material/table';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    EmployeeListComponent,
    CompanyListComponent,
    FooterBuildComponent,
    NavbarComponent,
    EmployeeAddComponent,
    EmployeeUpdateComponent,
    LoginFormComponent,
    RegisterComponent,
    DeleteDialogsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    MatTableModule,
    MatFormFieldModule,
    MatButtonModule,
    MatCardModule,
    MatInputModule,
    MatIconModule,
    MatToolbarModule,
    MatListModule,
    MatOptionModule,
    MatDialogModule,
    MatSnackBarModule,
    MatProgressSpinnerModule,
    MatSelectModule,
    MatRadioModule
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}

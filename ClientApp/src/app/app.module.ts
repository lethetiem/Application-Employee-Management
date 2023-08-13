import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { DxButtonModule } from 'devextreme-angular';
import { DxDrawerModule, DxToolbarModule, DxDropDownButtonModule } from "devextreme-angular";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderBuildComponent } from './Containers/Header/header-build/header-build.component';
import { FooterBuildComponent } from './Containers/Footer/footer-build/footer-build.component';
import { HomeComponent } from './Pages/Home/home/home.component';
import { EmployeeListComponent } from './Pages/Employees/employee-list/employee-list.component';
import { CompanyListComponent } from './Pages/Company/company-list/company-list.component';
import { NavbarComponent } from './Components/Navbar/navbar/navbar.component';
import { BrandComponent } from './Components/Brand/brand/brand.component';
import { FeatureComponent } from './Components/Feature/feature/feature.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from '@angular/common/http';
import { EmployeeAddComponent } from './Pages/Employees/employee-add/employee-add.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';

// import { MatSlideToggleModule } from '@angular/material/slide-toggle';
// import { MatTableModule } from '@angular/material/table';

@NgModule({
  declarations: [
    AppComponent,
    HeaderBuildComponent,
    HomeComponent,
    EmployeeListComponent,
    CompanyListComponent,
    FooterBuildComponent,
    NavbarComponent,
    BrandComponent,
    FeatureComponent,
    EmployeeAddComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    DxButtonModule,
    DxDrawerModule,
    DxToolbarModule,
    DxDropDownButtonModule,
    DxToolbarModule,
    NgbModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatButtonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

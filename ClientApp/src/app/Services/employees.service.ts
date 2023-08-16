import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { Employees } from '../Models/employees.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {
  
  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) {
    
   }

  getAllEmployees(): Observable<Employees[]> {
      return this.http.get<Employees[]>(this.baseApiUrl + '/api/employees')
  }

  addNewEmployee(employees: any): Observable<any>{
    console.log("service: ",employees);
    return this.http.post(`${this.baseApiUrl}/api/employees`, employees);
  }

  deleteEmployee(employeeId: any): Observable<any>{
    console.log("service: ", employeeId);
    return this.http.delete(`${this.baseApiUrl}/api/employees/${employeeId}`);
  }

}

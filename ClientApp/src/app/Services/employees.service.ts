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
}

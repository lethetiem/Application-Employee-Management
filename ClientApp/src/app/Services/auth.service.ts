import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseApiUrl:  string = environment.baseApiUrl;
  constructor(private http: HttpClient) {

   }

   login(loginObj: any): Observable<any>{
    console.log("Service", loginObj);
    return this.http.post<any>(`${this.baseApiUrl}/api/User/login`, {loginObj});
   }

   register(registerObj: any): Observable<any>{
    console.log("Service", registerObj);
    return this.http.post<any>(`${this.baseApiUrl}/api/User/register`, {registerObj});
   }
}
 
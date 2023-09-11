import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient, private router: Router) {}

  login(loginObj: any): Observable<any> {
    return this.http.post<any>(`${this.baseApiUrl}/api/User/login`, loginObj);
  }

  register(registerObj: any) {
    return this.http.post<any>(
      `${this.baseApiUrl}/api/User/register`,
      registerObj
    );
  }

  signOut(){
    localStorage.clear();
    this.router.navigate(['login'])
  }

  storeToken(tokenValue: string) {
    localStorage.setItem('token', tokenValue);
  }

  getToken() {
    return localStorage.getItem('token');
  }

  isLoggedIn(): boolean {
    return !!localStorage.getItem('token');
  }
}

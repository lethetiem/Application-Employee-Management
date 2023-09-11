import { AuthService } from './../../../Services/auth.service';
import { Component } from '@angular/core';


@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})


export class NavbarComponent {
  logo: string = 'assets/ct&p-image.png';
  constructor(private authService: AuthService){}

  logout(){
    this.authService.signOut();
  }
}


import { Component } from '@angular/core';


@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})


export class NavbarComponent {
  logo: string = 'assets/ct&p-image.png';
  toolbarContent = [{
    widget: 'dxButton',
    location: 'before',
    options: {
      icon: 'menu',
      // onClick: () => this.isDrawerOpen = !this.isDrawerOpen,
    },
  }];

  isDrawerOpen: boolean = false;
  buttonOptions: any = {
      icon: "menu",
      onClick: () => {
          this.isDrawerOpen = !this.isDrawerOpen;
      }
  }
}


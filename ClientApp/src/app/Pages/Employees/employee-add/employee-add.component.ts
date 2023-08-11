import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employee-add',
  templateUrl: './employee-add.component.html',
  styleUrls: ['./employee-add.component.css']
})
export class EmployeeAddComponent {
  constructor(private router: Router){}
  goBackToList(): void{
    this.router.navigate(['/Employees'])
  }
}

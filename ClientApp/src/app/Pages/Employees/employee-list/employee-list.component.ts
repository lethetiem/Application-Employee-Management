import { Component, OnInit } from '@angular/core';
import { Employees } from 'src/app/Models/employees.model';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  employees: Employees[] = []
  constructor(){}

  ngOnInit(): void{
    this.employees.push();
  }
}

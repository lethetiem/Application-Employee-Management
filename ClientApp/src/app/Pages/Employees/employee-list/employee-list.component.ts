import { Component, OnInit } from '@angular/core';
import { Employees } from 'src/app/Models/employees.model';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  employees: Employees[] = [
    {
      id: '2132',
      fullName: 'Le The Tiem',
      email: '19522330@gmai.com',
      phoneNumber: 23213,
      staffCode: '4214214214'
    },
    {
      id: '2132',
      fullName: 'Le The Tiem',
      email: '19522330@gmai.com',
      phoneNumber: 23213,
      staffCode: '4214214214'
    },
    {
      id: '2132',
      fullName: 'Le The Tiem',
      email: '19522330@gmai.com',
      phoneNumber: 23213,
      staffCode: '4214214214'
    },
    {
      id: '2132',
      fullName: 'Le The Tiem',
      email: '19522330@gmai.com',
      phoneNumber: 23213,
      staffCode: '4214214214'
    }
  ];
  constructor(){}

  ngOnInit(): void{
    this.employees.push();
  }
}

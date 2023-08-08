import { Component, OnInit } from '@angular/core';
import { Employees } from 'src/app/Models/employees.model';
import { EmployeesService } from 'src/app/Services/employees.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  employees: Employees[] = [];
  constructor(private employeesService: EmployeesService){}

  ngOnInit(): void{
    this.employeesService.getAllEmployees().subscribe({
      next: (employees) => {
        this.employees = employees;
      },
      error: (response) => {
        console.log(response)
      }
    })
  }
}

import { Component, OnInit } from '@angular/core';
import { Employees } from 'src/app/Models/employees.model';
import { EmployeesService } from 'src/app/services/employees.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css'],
})
export class EmployeeListComponent implements OnInit {
  employees: Employees[] = [];
  constructor(private employeesService: EmployeesService) {}

  ngOnInit(): void {
    // this.employeesService.getAllEmployees().subscribe({
    //   next: (employees) => {
    //     this.employees = employees;
    //   },
    //   error: (response) => {
    //     console.log(response)
    //   }
    // })
    this.loadEmployee();
  }

  loadEmployee(): void {
    this.employeesService.getAllEmployees().subscribe({
      next: (employees) => {
        this.employees = employees;
      },
      error: (response) => {
        console.log(response);
      },
    });
  }

  DeleteEmployee(employeeId: string): void {
    if (confirm('Are you sure you want to delete this employee')) {
      this.employeesService.deleteEmployee(employeeId).subscribe({
        next: (employeeId) => {
          console.log('Employee deleted successfully', employeeId);
        },
        error: (response) => {
          console.error('Error deleting employee', response);
        },
      });
    }
  }
}

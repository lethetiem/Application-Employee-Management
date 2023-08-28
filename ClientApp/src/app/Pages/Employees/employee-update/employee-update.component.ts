import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Employees } from 'src/app/Models/employees.model';
import { EmployeesService } from 'src/app/Services/employees.service';

@Component({
  selector: 'app-employee-update',
  templateUrl: './employee-update.component.html',
  styleUrls: ['./employee-update.component.css'],
})
export class EmployeeUpdateComponent implements OnInit {
  employeeForm!: FormGroup;
  employeeId: string;


  constructor(
    private formBuilder: FormBuilder,
    private router: Router,
    private route: ActivatedRoute,
    private employeesService: EmployeesService
  ) {
    this.employeeId = '';
  }

  ngOnInit(): void {
    this.employeeForm = this.formBuilder.group({
      fullName: ['', Validators.required],
      email: ['', Validators.required],
      phoneNumber: ['', Validators.required],
      address: ['', Validators.required],
      companyCategory: ['', Validators.required],
      gender: [null],
    });

    this.route.params.subscribe((params) => {
      this.employeeId = params['id'];
      this.loadEmployeeData(this.employeeId);
    });
  }

  loadEmployeeData(employeeId: string): void {
    this.employeesService.getEmployee(employeeId).subscribe({
      next: (employeeData) => {
        this.employeeForm.setValue(employeeData);
      },
      error: (error) => {
        console.error('Loading data failed!', error);
      },
    });
  }

  goBackToList(): void {
    this.router.navigate(['/Employees']);
  }

  updateEmployee(employeeId: string): void {
    if (confirm('Are you sure you want to edit this employee')) {
      this.employeesService.updateEmployee(employeeId).subscribe({
        next: () => {},
      });
    }
  }
}

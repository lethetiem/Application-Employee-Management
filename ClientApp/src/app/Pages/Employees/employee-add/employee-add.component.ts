import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { EmployeesService } from 'src/app/services/employees.service';
import { Employees } from '../../../Models/employees.model';

@Component({
  selector: 'app-employee-add',
  templateUrl: './employee-add.component.html',
  styleUrls: ['./employee-add.component.css'],
})
export class EmployeeAddComponent {
  employeeForm!: FormGroup;
  employees: Employees[] = [];



  constructor(
    private formBuilder: FormBuilder,
    private router: Router,
    private employeesService: EmployeesService
  ) {}

  ngOnInit(): void {
    this.employeeForm = this.formBuilder.group({
      fullName: ['', Validators.required],
      email: ['', Validators.required],
      phoneNumber: ['', Validators.required],
      address: ['', Validators.required],
      companyCategory: ['', Validators.required],
      // gender: this.formBuilder.array([]),
      gender: [null]
    });
  }

  // genderOptions = [
  //   {
  //     label: 'Male', value: false
  //   },
  //   {
  //     label: 'Female', value: false
  //   }
  // ]

  // getSelectedGenders(): string[] {
  //   return this.genderOptions.filter(gender => gender.value).map(gender => gender.label);
  // }

  goBackToList(): void {
    this.router.navigate(['/Employees']);
  }

  addNewEmployee(): void {
    if (this.employeeForm.invalid) {
      return;
    }

    let employeeData: Employees = this.employeeForm.value;
    employeeData.gender = true;
    // console.log(employeeData);
    this.employeesService.addNewEmployee(employeeData).subscribe({
      next: (employee) => {
        console.log('Employee added successfully');
      },
      error: (error) => {
        console.log('Error adding employee', error);
      },
    });
  }
}

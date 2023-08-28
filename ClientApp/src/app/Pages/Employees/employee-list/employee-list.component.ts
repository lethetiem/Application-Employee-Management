import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { Employees } from 'src/app/Models/employees.model';
import { EmployeesService } from 'src/app/Services/employees.service';
import { DeleteDialogsComponent } from '../../Dialogs/delete-dialogs/delete-dialogs.component';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css'],
})
export class EmployeeListComponent implements OnInit {
  employees: Employees[] = [];
  displayedColumns: string[] = [
    'position',
    'fullName',
    'email',
    'phoneNumber',
    'address',
    'companyCategory',
    'gender',
    'actions',
  ];
  dataSource = new MatTableDataSource<Employees>();
  loading = true;

  constructor(
    private employeesService: EmployeesService,
    public dialog: MatDialog,
    private snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {
    this.loadEmployee();
    setTimeout(()=>{
      this.loading = false;
    }, 2000)
  }

  renderGender(gender: boolean): string {
    return gender ? 'Male' : 'Female';
  }

  loadEmployee(): void {
    this.employeesService.getAllEmployees().subscribe({
      next: (employees) => {
        this.employees = employees;
        this.dataSource.data = this.employees;
      },
      error: (response) => {
        console.log(response);
      },
    });
  }

  openDeleteDialog(employeeId: string, employeeName: string): void {
    const dialogRef = this.dialog.open(DeleteDialogsComponent, {
      width: '300px',
      data: { employeeId, employeeName },
    });

    dialogRef.afterClosed().subscribe((result) => {
      if (result) {
        this.DeleteEmployee(employeeId);
      }
    });
  }

  DeleteEmployee(employeeId: string): void {
    this.employeesService.deleteEmployee(employeeId).subscribe({
      next: (employeeId) => {
        console.log('Employee deleted successfully', employeeId);
        this.loadEmployee();
      },
      error: (response) => {
        console.error('Error deleting employee', response);
      },
    });
    this.snackBar.open(`${employeeId} deleted successfully`, 'Dismiss', {
      duration: 3000,
    });
  }
}

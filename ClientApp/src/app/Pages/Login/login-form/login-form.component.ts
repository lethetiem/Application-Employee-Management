import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import ValidateForm from '../../../Helpers/validateForm';
import { AuthService } from '../../../Services/auth.service';
import { Router } from '@angular/router';
import { NgToastService } from 'ng-angular-popup';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css'],
})
export class LoginFormComponent implements OnInit {
  hidePassword = true;
  password: string = '';
  loginForm!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private authService: AuthService,
    private router: Router,
    private toast: NgToastService
  ) {}

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required],
    });
  }
  togglePasswordVisibility(): void {
    this.hidePassword = !this.hidePassword;
  }

  onLogin() {
    if (this.loginForm.valid) {
      this.authService.login(this.loginForm.value).subscribe({
        next: (response) => {
          this.loginForm.reset();
          this.authService.storeToken(response.token);
          this.toast.success({
            detail: 'SUCCESS',
            summary: response.message,
            duration: 5000,
          });
          this.router.navigate(['Home']);
        },
        error: (err) => {
          if (err && err.error) {
            this.toast.error({
              detail: 'ERROR',
              summary: 'Something when wrong!',
              duration: 5000,
            });
          } else {
            alert('An error occurred during login.');
          }
        },
      });
    } else {
      ValidateForm.validateAllFormField(this.loginForm);
      this.toast.error({
        detail: 'ERROR',
        summary: 'Something when wrong!',
        duration: 5000,
      });
    }
  }
}

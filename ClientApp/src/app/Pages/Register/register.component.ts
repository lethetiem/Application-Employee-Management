import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../../Services/auth.service';
import { Router } from '@angular/router';
import ValidateForm from '../../Helpers/validateForm';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  hidePassword = true;
  password: string = '';
  registerForm!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private authService: AuthService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.registerForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', Validators.required],
      username: ['', Validators.required],
      password: ['', Validators.required],
    });
  }
  togglePasswordVisibility(): void {
    this.hidePassword = !this.hidePassword;
  }

  onRegister() {
    if (this.registerForm.valid) {
      console.log(this.registerForm.value);
      this.authService.register(this.registerForm.value).subscribe({
        next: (response) => {
          alert(response.message);
          this.registerForm.reset();
          this.router.navigate(['']);
        },
        error: (err) => {
          if (err && err.error) {
            alert(err.error.error);
          } else {
            alert('An error occurred during registration.');
          }
        },
      });
    } else {
      ValidateForm.validateAllFormField(this.registerForm);
    }
  }
}

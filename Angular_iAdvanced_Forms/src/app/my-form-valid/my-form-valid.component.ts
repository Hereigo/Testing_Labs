import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { asyncEmailValidator } from './my-email-async.validator';

@Component({
  selector: 'app-my-form',
  templateUrl: './my-form-valid.component.html'
})
export class MyFormComponent implements OnInit {

  // MODEL-DRIVEN_DEVELOPMENT  - start and full implement DEVELOPMENT from creating Model...

  registrationForm: FormGroup;
  firstName: FormControl;
  lastName: FormControl;
  email: FormControl;
  password: FormControl;

  constructor() { }

  ngOnInit() {
    this.createFormControls();
    this.createForm();
  }

  createFormControls() {
    this.firstName = new FormControl('', Validators.required);
    this.lastName = new FormControl('', Validators.required);
    this.email = new FormControl('', Validators.required, asyncEmailValidator);
    this.password = new FormControl('', [Validators.required, Validators.minLength(8)]);
  }

  createForm() {
    this.registrationForm = new FormGroup({
      name: new FormGroup({
        firstName: this.firstName,
        lastName: this.lastName
      }),
      email: this.email,
      password: this.password
    });
  }

  onSubmitMyForm() {

    if (this.registrationForm.valid) {

      console.log(' === Form submitted:');
      console.log(this.registrationForm.value);

    } else {

      console.log('Form not valid!');
    }
  }
}

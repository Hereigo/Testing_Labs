import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { emailValidator } from './email-validator';

@Component({
  selector: 'app-my-form',
  templateUrl: './my-form.component.html',
  styleUrls: ['./my-form.component.css']
})
export class MyFormComponent implements OnInit {

  registrationForm: FormGroup;

  constructor() { }

  // MODEL-DRIVEN_DEVELOPMENT  - nedded to start DEV from creating Model...

  ngOnInit() {

    this.registrationForm = new FormGroup({

      name: new FormGroup({
        firstName: new FormControl('', Validators.required),
        lastName: new FormControl('', Validators.required)
      }),

      email: new FormControl('', [Validators.required, emailValidator]),

      password: new FormControl('', [Validators.required, Validators.minLength(8)])

    });
  }

}

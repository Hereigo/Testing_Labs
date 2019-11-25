import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { TestModel } from '../models/test.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  public test: TestModel = new TestModel();

  constructor(private router: Router) { }

  public HomeCompRouterNavigateTo(test: TestModel) {

    // set default value :
    test.xtraId = test.xtraId === undefined ? 1 : test.xtraId;

    this.router.navigate(
      ['test', test.xtraId],
      {
        queryParams: {
          param1: test.xtraBoo,
        },
      },
    );
  }
}

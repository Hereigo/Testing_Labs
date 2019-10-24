import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  user: { id: number, name: string };

  constructor(private injectedCurrentRoute: ActivatedRoute) { }

  ngOnInit() {

    let nameInsideRoute = this.injectedCurrentRoute.snapshot.params['name'];

    let idInsideRoute = parseInt(this.injectedCurrentRoute.snapshot.params['id']);

    this.user = {
      id: idInsideRoute,
      name: nameInsideRoute == undefined ? 'noname' : nameInsideRoute
    }

  }

}

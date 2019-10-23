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

    // let idInsideRouteParsed = 1;

    // if (this.injectedCurrentRoute.snapshot.params['id']) {

    //   let parsed = 
    //   idInsideRouteParsed = parsed == undefined ? 1 : parsed;
    // }

    let idInsideRoute = parseInt(this.injectedCurrentRoute.snapshot.params['id']);

    this.user = {
      id: idInsideRoute,
      name: 'User_' + idInsideRoute
    }
    //this.user.id = 2; //idInsideRouteParsed;
    // this.oneUser.name = 'User_' + idInsideRouteParsed;

  }

}

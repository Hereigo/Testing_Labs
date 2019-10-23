import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private myRouter: Router) { }

  ngOnInit() {
  }

  onLoadServers() {

    const routerLinkLocal = '/servers';

    this.myRouter.navigate([routerLinkLocal]);
  }

}

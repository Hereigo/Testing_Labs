import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private myRouter: Router, private injectedCurrentRoute: ActivatedRoute) { }

  ngOnInit() {
  }

  onLoadServers() {

    const routerLinkLocal = '/servers';

    this.myRouter.navigate([routerLinkLocal]);
  }

  onPageReload() {

    const routerLinkLocal = '/home';

    // ERROR : can't find route 'home/home' (because of injected-CurrentRoute!)
    this.myRouter.navigate([routerLinkLocal], { relativeTo: this.injectedCurrentRoute });
  }

}

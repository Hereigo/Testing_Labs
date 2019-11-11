import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ItemComponent implements OnInit {

  constructor(private route: ActivatedRoute) { }

  routeSnapshotId: number;

  subscriptParamsId: number;
  private subscription: Subscription;

  routeSwitchMapId: number;

  ngOnInit() {
    // get ID from route - works for FIRST TIME only !
    this.routeSnapshotId = parseInt(this.route.snapshot.params['id']);

    // to get ID dynamically should SUBSCRIBE for ID changes :
    this.subscription = this.route.params.subscribe(routeParams => this.subscriptParamsId = routeParams['id'])

    // OR use Observable<ParamMap> :
    this.route.paramMap.pipe(switchMap(routeParams => routeParams.get('id'))).subscribe(paramsGetId => this.routeSwitchMapId = +paramsGetId);
    // route.paramMap - is Observable<ParamMap> object.
    // ParamMap - is map of Route-parameters & QueryString-parameters.


    // Get QueryParams :

    this.querySubscription = this.route.queryParams.subscribe(
      (query: any) => {
        this.queryParam1 = query['param1'];
        this.queryParam2 = parseInt(query['param2']);
      });
  }

  private querySubscription: Subscription;
  queryParam1: boolean;
  queryParam2: number;

}

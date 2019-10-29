import { AfterContentInit, Component, DoCheck, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-with-ng-content',
  template: `
    <h3>Sub Component : </h3>
    <ng-content></ng-content>` // Projecting CONTENT here from PARENT via <app-with-ng-content> tag
})
export class NgContentComponent implements OnInit, OnChanges, DoCheck, AfterContentInit {

  @Input() elementInputToUseInApp: string;

  constructor() { console.log('Element-LifeCycle : constructor call.'); }

  ngOnChanges(simpleChanges: SimpleChanges): void {
    //Called before any other lifecycle hook. Use it to inject dependencies, but avoid any serious work here.
    //Add '${implements OnChanges}' to the class.
    console.log('Element-LifeCycle : ngOnChanges() call (see below).');
    console.log(simpleChanges);
  }

  ngOnInit(): void {
    console.log('Element-LifeCycle : ngOnInit() call.');
  }

  ngDoCheck() {
    console.log('Element-LifeCycle : ngDoCheck() call.');
  }

  ngAfterContentInit() {
    console.log('Element-LifeCycle : ngAfterContentInit() call.');
  }

}

import { Component, Input, OnInit, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-one-element',
  template: `
    <div class="panel panel-default">
    	<div class="panel-heading">{{ element.name }}</div>
    	<div class="panel-body">{{ element.name }} is created. ({{textToFirstChangeByApp}})</div>
    </div>`
})
export class ElementComponent implements OnInit, OnChanges {

  @Input() textToFirstChangeByApp: string = '...';

  // Make element is public and visible for another Components (via Alias) :
  @Input('elementAlias') element: { content: string };

  constructor() { console.log('Element-LifeCycle : constructor call.'); }

  ngOnChanges(changes: SimpleChanges): void {
    //Called before any other lifecycle hook. Use it to inject dependencies, but avoid any serious work here.
    //Add '${implements OnChanges}' to the class.
    console.log('Element-LifeCycle : ngOnChanges() call (see below).');
    console.log(changes);
  }

  ngOnInit(): void {
    console.log('Element-LifeCycle : ngOnInit() call.');
  }
}

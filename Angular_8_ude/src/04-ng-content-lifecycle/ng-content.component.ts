import {
  AfterContentChecked,
  AfterContentInit,
  AfterViewChecked,
  AfterViewInit,
  Component,
  DoCheck,
  ElementRef,
  Input,
  OnChanges,
  OnDestroy,
  OnInit,
  SimpleChanges,
  ViewChild
} from '@angular/core';

@Component({
  selector: 'app-with-ng-content',
  template: `
    <div class="panel panel-default" #templPanelRef>
    	<div class="panel-body">
    		<ng-content></ng-content>
    	</div>
    </div>`
  // Projecting CONTENT from PARENT via <app-with-ng-content> into <ng-content></ng-content>
})
export class NgContentComponent implements OnDestroy, OnInit, OnChanges, DoCheck, AfterContentInit, AfterContentChecked, AfterViewInit, AfterViewChecked {

  // This reference not allowed UNTIL ngAfterViewInit() !
  @ViewChild('templPanelRef', { static: false }) templateReference: ElementRef;

  @Input() elementInputOfNgComponent: string = 'TEST';

  constructor() { console.log('Comp.LifeCycle : constructor call.'); }

  ngOnChanges(simpleChanges: SimpleChanges): void {
    // Called before any other lifecycle hook. Use it to inject dependencies, but avoid any serious work here.
    console.log('Comp.LifeCycle : ngOnChanges() call (see below).');
    console.log(simpleChanges);
    // console.log(this.templateReference.nativeElement); - ERROR !
  }

  ngOnInit(): void {
    console.log('Comp.LifeCycle : ngOnInit() call.');
    // console.log(this.templateReference.nativeElement); - ERROR !
  }

  ngDoCheck() {
    console.log('Comp.LifeCycle : ngDoCheck() call.');
    // console.log(this.templateReference.nativeElement); - ERROR !
  }

  ngAfterContentInit() {
    console.log('Comp.LifeCycle : ngAfterContentInit() call.');
    // console.log(this.templateReference.nativeElement); - ERROR !
  }

  ngAfterContentChecked(): void {
    console.log('Comp.LifeCycle : ngAfterContentChecked() call.');
    // console.log(this.templateReference.nativeElement); - ERROR !
  }

  ngAfterViewInit() {
    console.log('Comp.LifeCycle : ngAfterViewInit() call.');
    console.log(this.templateReference.nativeElement.textContent + ' (templ.Ref. available!)');
  }

  ngAfterViewChecked() {
    console.log('Comp.LifeCycle : ngAfterViewChecked() call.');
  }

  ngOnDestroy() {
    console.log('Comp.LifeCycle : ngOnDestroy() call.');
  }
}

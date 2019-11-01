import { Component, ElementRef, ViewChild } from '@angular/core';
import { ChildComponent } from './child.component';

@Component({
  selector: 'app-root',
  template: `
    <div>
    	<h3 #appComponentHeader>: # APP COMPONENT :</h3>
    	<hr/>
    	<app-child-component #childComponentRef>
    		<h4 #appHeaderInsideChildRef style="border:solid 2px orange">: # App Header inside of ChildComponent Content :</h4>
      </app-child-component>
      <br>
      <button (click)="childComponentRef.changeTextCase()">Change Childs via LocalRef</button>
      &nbsp;
    	<button (click)="callChildsFunction()">Change Child via @ViewChild</button>
    	<hr/>
    	<button (click)="changeAppComponentHeader()">App self-Change via @ViewChild ( #locRef )</button>
    </div>`
})
export class AppComponent {

  @ViewChild(ChildComponent, { static: false })
  private viewChildComponent: ChildComponent;

  callChildsFunction() {
    this.viewChildComponent.changeTextCase();
  }

  // App self-Change via @ViewChild ( #locRef )

  @ViewChild("appComponentHeader", { static: false })
  private appHeaderRef: ElementRef;

  isUpperCase: boolean = true;

  changeAppComponentHeader() {
    this.appHeaderRef.nativeElement.innerText = this.isUpperCase ?
      this.appHeaderRef.nativeElement.innerText.toLowerCase() :
      this.appHeaderRef.nativeElement.innerText.toUpperCase();
    this.isUpperCase = !this.isUpperCase;
  }
}

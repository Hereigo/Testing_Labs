import { Component, ContentChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-child-component',
  template: `
    <div style="border:solid 1px blue;padding:0 10px 10px">
    	<h3>: # Child Component :</h3>
    	<hr/>
    	<ng-content></ng-content>
    	<hr/>
    	<p>{{childsText}}</p>
    	<hr/>
    	<button (click)="changeAppHeaderInsideChild()">Change AppHeader in ChildContent</button>
    </div>`
})
export class ChildComponent {

  childsText: string = "ChildComponent's Property.";

  isLowerText: boolean = true;

  changeTextCase() {
    this.childsText = this.isLowerText ? this.childsText.toUpperCase() : this.childsText.toLowerCase();
    this.isLowerText = !this.isLowerText;
  }

  @ContentChild('appHeaderInsideChildRef', { static: false })
  appHeadInChild: ElementRef;

  isLowerHeader: boolean = true;

  changeAppHeaderInsideChild() {
    this.appHeadInChild.nativeElement.innerText = this.isLowerHeader ?
      this.appHeadInChild.nativeElement.innerText.toUpperCase() :
      this.appHeadInChild.nativeElement.textContent.toLowerCase();
    this.isLowerHeader = !this.isLowerHeader;
  }
}

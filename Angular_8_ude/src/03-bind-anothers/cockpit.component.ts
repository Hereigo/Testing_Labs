import { Component, EventEmitter, ElementRef, Output, ViewChild } from '@angular/core';

@Component({
  selector: 'app-cockpit',
  templateUrl: './cockpit.component.html'
})
export class CockpitComponent {

  // <app-cockpit (eventEmittedFromCockpit)="onElementAdded($event)">
  // Call function from Html to emit Event with { elementName: string } inside.
  @Output() eventEmittedFromCockpit = new EventEmitter<{ elementName: string }>();

  // 1.
  // [(ngModel)]="htmlInput_NgModel" :
  htmlInput_NgModel = '';

  onAddElement_NgModel() {
    this.eventEmittedFromCockpit.emit({
      elementName: this.htmlInput_NgModel
    });
  }

  // 2.
  // Process HTMLInputElement incoming as parameter.
  onAddElement_LocalRef(incomingHtmlInput: HTMLInputElement) {
    this.eventEmittedFromCockpit.emit({ elementName: incomingHtmlInput.value });
  }

  // 3.
  // ViewChild by local ref - can be marked as { static: true } == static in this Component class :
  @ViewChild('htmlInputReferenceForViewChild', { static: false }) serverInputByLocalRef: ElementRef;
  // @ViewChild(ViewChildComponent) ...
  // also allowed to get by the FIRST occurence of Component in the APP_COMPONENT.

  onAddElement_LocRef_ViewCh() {
    // BAD PRACTICE :
    this.serverInputByLocalRef.nativeElement.value = 'Text has replaced with bad practice.';
    // Do NOT modify html DOM directly! - Use INTERPOLATION or Property-BINDING.

    this.eventEmittedFromCockpit.emit({
      elementName: this.serverInputByLocalRef.nativeElement.value
    });
  }
}

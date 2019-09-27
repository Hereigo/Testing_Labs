import { Component, ElementRef, ViewChild } from "@angular/core";
import { ChildComponent } from "./child.component";

// TEMPLATE'S VARIABLES :

// #childBinder is INSIDE <child-comp>, thus - BINDED to CHILD!

@Component({
  selector: "my-app",
  template: `
    <child-comp #childBinder></child-comp>
    <p>
    	<button (click)="childBinder.increment()">+</button>
    	<button (click)="childBinder.decrement()">-</button>
    </p>
    <p>
    	<button (click)="incrementParent()">+</button>
    	<button (click)="decrementParent()">-</button>
    </p>
    <hr>
    	<p #paragrafBinder>{{localVar}}</p>
    	<p>{{paragrafBinder.textContent}}</p>
    	<button (click)="change()">Изменить</button>`
})
export class AppComponent {

  // @ViewChild - DECORATOR to Create CHILD's Ref. & Bind its functionality. (ChildComponents must be IMPORTED!)
  @ViewChild(ChildComponent, { static: false })

  private childsRef: ChildComponent;

  incrementParent() { this.childsRef.increment(); }
  decrementParent() { this.childsRef.decrement(); }

  // @ViewChild DECORATOR with ElementRef - Ref. to a #TEMPLATE_VARIABLE & Bind it. (ElementRef must be IMPORTED!)

  @ViewChild("paragrafBinder", { static: false }) pfBind: ElementRef;
  // <p #paragrafBinder>{{localVar}}</p>
  localVar: string = "Old Value";
  // {{localVar}} = x.nativeElement.textContent
  change() {
    this.pfBind.nativeElement.textContent = "New Value";
  }

}

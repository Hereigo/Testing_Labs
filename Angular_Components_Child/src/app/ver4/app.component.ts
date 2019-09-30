import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `
    <p #bindParent>&lt;
    	<strong>child-component</strong>-tag binded with a
    	<strong>#bindParent</strong>-var &gt; - make a child to able to use it by  @ContentChild('bindParent', ...: ElementRef event.
    </p>
    <div id='chld-place'>
    	<p>: PARENT CONTENT BELOW :</p>
    	<child-comp-place>
    		<h4 #bindParent>
    			<strong>{{parentLocalVar}}</strong>.
    		</h4>
    	</child-comp-place>
    </div>`,
  styles: [`
    #chld-place {
        border: 2px solid red
    }`]
})
export class AppComponent {

  parentLocalVar: string = "PARENT local var";
}
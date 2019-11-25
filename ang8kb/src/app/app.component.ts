import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  styles: [`
		.active a {
		  color: red;
		  font-weight: bold;
		}
		.output{
		  border-radius: 10px;
		  border: solid 1px blue;
		  margin: 1em;
		  padding: 1em;
    }`],
  templateUrl: './app.component.html',
})
export class AppComponent { }

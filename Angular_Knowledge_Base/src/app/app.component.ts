import { Component } from '@angular/core';

@Component({
	selector: 'app-root',
	template: `
        <div class="row">
        	<div class="col-xs-12 col-sm-10 col-md-8 col-sm-offset-1 col-md-offset-2">
        		<ul class="nav nav-tabs">
        			<!-- any path has a slash, but only single slash ('/') means HOME-route .... {exact:true} -->
        			<li role="presentation" routerLinkActive="active" [routerLinkActiveOptions]="{exact:true}">
        				<a [routerLink]="[ '/' ]">= Home page =</a>
        			</li>
        			<li role="presentation" routerLinkActive="active">
        				<a [routerLink]="[ '/pageTwo' ]">= Page Two =</a>
        			</li>
        			<li role="presentation" routerLinkActive="active">
        				<a [routerLink]="[ '/pageThree' ]">= Page Three =</a>
        			</li>
        			<!-- nav bar ended-->
        		</ul>
        	</div>
        </div>
        <hr/>
        <div class="row">
        	<div class="col-xs-12 col-sm-10 col-md-8 col-sm-offset-1 col-md-offset-2">
        		<!-- all childs components place -->
        		<router-outlet></router-outlet>
        		<!-- all childs components place -->
        	</div>
        </div>`
})
export class AppComponent { }

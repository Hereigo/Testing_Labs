import { Component } from '@angular/core';

@Component({
	selector: 'app-root',
	template: `
        <div class="row">
        	<div class="col-xs-12 col-sm-10 col-md-8 col-sm-offset-1 col-md-offset-2">
        		<ul class="nav nav-tabs">
        			<!-- any path has a slash, but only single slash ('/') means HOME-route .... {exact:true} -->
        			<li role="presentation" routerLinkActive="active" [routerLinkActiveOptions]="{exact:true}">
        				<a [routerLink]="[ '' ]">= Home page =</a>
        			</li>
        			<li role="presentation" routerLinkActive="active" [routerLinkActiveOptions]="{exact:true}">
        				<a [routerLink]="[ '/item' ]">= Item's page =</a>
        			</li>
        			<li role="presentation" routerLinkActive="active">
        				<a [routerLink]="['item', 5]">Goto item 5</a>
        			</li>
        			<li role="presentation" routerLinkActive="active">
        				<a [routerLink]="['item', 7]">Goto item 7</a>
        			</li>
        			<li role="presentation" routerLinkActive="active">
        				<a [routerLink]="['item', 7]" [queryParams]="{'param1':true, 'param2': 12345}">Goto 7 (query str)</a>
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

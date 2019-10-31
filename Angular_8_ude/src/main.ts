import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

// SELECT ONE APP.MODULE TO RUN SELECTED APPLICATION :

// import { AppModule } from './01-ng-directives/app.module';
// import { AppModule } from './02-recipe-book/app.module';
// import { AppModule } from './03-bind-anothers/app.module';
// import { AppModule } from './04-ng-content-lifecycle/app.module';
import { AppModule } from './05-content-child/app.module';

platformBrowserDynamic()
  .bootstrapModule(AppModule)
  .catch(err => console.error(err));

import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

// SELECT MAIN APP.MODULE TO RUN SELECTED APPLICATION :

// import { AppModule } from './01-ng-directives/app.module';
import { AppModule } from './02-recipe-book/app.module';

platformBrowserDynamic()
  .bootstrapModule(AppModule)
  .catch(err => console.error(err));

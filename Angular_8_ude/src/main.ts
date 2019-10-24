import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule_01 } from './01-ng-directives/app.module';

platformBrowserDynamic()
  .bootstrapModule(AppModule_01)
  .catch(err => console.error(err));

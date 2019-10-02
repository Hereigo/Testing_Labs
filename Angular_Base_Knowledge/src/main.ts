import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/1_NgModel/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
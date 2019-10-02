import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/NgModel/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
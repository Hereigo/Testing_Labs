import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/Z_TEST/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
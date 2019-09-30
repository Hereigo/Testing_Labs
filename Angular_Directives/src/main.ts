import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/v1/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
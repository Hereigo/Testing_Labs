import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/ver1/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
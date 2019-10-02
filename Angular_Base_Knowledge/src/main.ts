import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/3_ngStyle_ngClass_host/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
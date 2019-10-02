import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/3_ngStyle_ngClass/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
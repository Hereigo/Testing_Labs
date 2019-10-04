import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/pipes_aka_filters/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
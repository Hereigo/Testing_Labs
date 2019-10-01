import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/ViewChild/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
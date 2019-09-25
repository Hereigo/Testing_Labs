import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { MainAppModule } from './app/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(MainAppModule);
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/structural_directives/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
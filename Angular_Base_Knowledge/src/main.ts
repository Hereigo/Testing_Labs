import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/4_directive_params/app.module';

const platform = platformBrowserDynamic();

platform.bootstrapModule(AppModule);
# Sample

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 8.3.8.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).

# To use BOOTSTRAP :

1. `npm install bootstrap@3.3.7 --save`

(--save param - to add reference to the `package.json`)

2. Add reference to `"node_modules/bootstrap/dist/css/bootstrap.min.css"` in the `angular.json` or `.angular.cli.json` file in to `"styles"`-section.

OR add `@import "../node_modules/bootstrap/dist/css/bootstrap.min.css";` inside of main `styles.css`

(to allow bootstrap styles for all our application components)

3. Generate new Component - `ng g c my-form` => my-form.component.ts



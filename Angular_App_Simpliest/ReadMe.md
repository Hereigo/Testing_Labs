
> **Node.js** with **npm** REQUIRED.

## In the root project dir :

* **Type-Script =>** **``tsc --init``** - ( create ``.\tsconfig.json`` )

* **TS Config =>** ``.\tsconfig.json``

--------------------------------------

* **Config Ng-App Dependencies =>** ``.\package.json``

* **Restore Dependencies =>** **``npm install``** - ( added ``.\node_modules\`` )

--------------------------------------

* **App Start Point =>** ``.\src\main.ts`` ( platform . bootstrapModule( AppModule ) )

* **Default Root AppModule =>** ``.\src\app\app.module.ts`` - @NgModule decorates AppModule class **to make it a Module.**

* **AppModule use MyNGComponent =>** ``.\src\app\app.component.ts``

* **NG-Components =>** are UI views managed reusable parts. Module must have **at least one Component!**

* **Polyfills are needed for Angular =>** ``.\src\polyfills.ts``

* **To combine all .ts files into single =>** ``.\webpack.config.js`` ()

* **Simple Html page for App =>** ``index.html``

--------------------------------------

* **Local Run =>** **``npm run dev``**

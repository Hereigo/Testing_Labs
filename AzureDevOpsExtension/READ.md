## How to start :

https://docs.microsoft.com/en-us/azure/devops/extend/get-started/node?view=azure-devops&viewFallbackFrom=vsts#create-a-directory-and-manifest

1. `npm install -g tfx-cli` - to install the extension packaging tool (TFX).

2. `npm init -y` - to  initialize a new NPM package manifest.

3. `npm install vss-web-extension-sdk --save` - to install the VSS Web Exten.SDK package & save it to manifest.

4. Create `vss-extension.json` by the example on the page linked over.

5. Create `my-hub.html` by the example on the page linked over.

6. Sign In to [Marketplace management portal](https://aka.ms/vsmarketplace-manage).

7. Define Publisher ID in `vss-extension.json`.

8. `tfx extension create` - to Pack an Extension into `Publisher.Extension-1.0.0.vsix` file.

9. Publish on [Marketplace management portal](https://aka.ms/vsmarketplace-manage) via + New Extension -> Azure DevOps.

10. Share your Extension with your Organization on ADO.

11. Then `View Extension` and press button `Get it Free` and then `Install`.

12. Now you find it in ADO `Repos`.

13. Add `"baseUri": "https://localhost:44300"` into `vss-extension.json` - to DEBUG it locally.

14. To DEBUG it locally - repeat steps 8-12.

import { ElementBase } from './element-base';
import { ElementOptions } from './element-options';

export class TextBoxElement extends ElementBase<string> {

    controlType = 'textbox';

    // additional property (not existed in ElementBase)
    type: string;

    constructor(elemOptions: ElementOptions = {}) {
        super(elemOptions);

        this.type = elemOptions['type'] || 'text';
    }
}

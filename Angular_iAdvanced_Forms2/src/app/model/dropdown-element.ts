import { ElementBase } from './element-base';
import { ElementOptions } from './element-options';

export class DropDownElement extends ElementBase<string> {

    controlType = 'dropdown';

    // additional property (not existed in ElementBase)
    options: { key: string; value: string }[] = []; // INITAILIZ NEEEEEEEEEEEEEEEDED ????????????????

    constructor(elemOptions: ElementOptions = {}) {
        super(elemOptions);

        this.options = elemOptions['options'] || [];
    }
}

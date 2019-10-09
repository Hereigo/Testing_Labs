import { ElementOptions } from './element-options';

// BASE-CLASS for TextBox - Element & DropDown - Elements :

export class ElementBase<T> {

  controlType: string;
  key: string;
  label: string;
  order: number;
  required: boolean;
  value: T; // GENERIC TYPE for ElementType on Form

  // Assign OPTIONS-data to ELEMENT_BASE-data :

  constructor(options: ElementOptions = {}) {

    this.controlType = options.controlType || '';
    this.key = options.key || '';
    this.label = options.label || '';
    this.order = options.order === undefined ? 1 : options.order;
    this.required = !!options.required;
    this.value = options.value;
  }
}

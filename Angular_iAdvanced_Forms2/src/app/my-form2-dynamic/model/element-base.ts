import { ElementOptions } from './element-options';

// BASE-CLASS for TextBox - Element & DropDown - Elements :

export class ElementBase<T> {

  controlType: string;
  key: string;
  label: string;
  order: number;
  required: boolean;
  value: T;

  // Assign OPTIONS-data to ELEMENT_BASE-data :

  constructor(elemOptions: ElementOptions = {}) {

    this.controlType = elemOptions.controlType || '';
    this.key = elemOptions.key || '';
    this.label = elemOptions.label || '';
    this.order = elemOptions.order === undefined ? 1 : elemOptions.order;
    this.required = !!elemOptions.required;
    this.value = elemOptions.value;
  }
}

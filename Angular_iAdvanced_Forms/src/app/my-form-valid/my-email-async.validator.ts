import { FormControl } from '@angular/forms';

export function asyncEmailValidator(control: FormControl) {

    console.log('start validating');

    // TO VALIDATE ON SERVER SIDE SHOULD USE ASYNC WITH PROMISES :

    return new Promise(

        resolve => { // return from Promise

            setTimeout(() => {

                const emailRegex = /[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}/i;

                const value = control.value;

                const result = emailRegex.test(value);

                if (result) {

                    console.log(' === validated =)');
                    resolve(null);

                } else {

                    console.log(' === validation error');
                    resolve({ asyncEmailValidator: { valid: false, message: 'Not valid email value!' } });
                }
            }, 3000);
        }
    );
}

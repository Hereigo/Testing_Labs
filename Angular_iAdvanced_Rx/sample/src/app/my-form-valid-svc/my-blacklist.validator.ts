import { MyBlackListService } from './my-blacklist.service';
import { FormControl } from '@angular/forms';

export function blackListValidator(blacklistService: MyBlackListService) {

    return (control: FormControl) => {

        return new Promise((promiseResolve) => {

            blacklistService.checkEmail(control.value).then(

                (serverResponse) => {

                    if (serverResponse) {
                        promiseResolve({ blackListValidator: { blocked: true } });
                    } else {
                        promiseResolve(null);
                    }
                },
                () => { console.log('Error loading black list!'); }
            );
        });
    };
}

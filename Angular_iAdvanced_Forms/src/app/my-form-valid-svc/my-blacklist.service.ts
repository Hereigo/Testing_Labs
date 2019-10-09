import { Injectable } from '@angular/core';

@Injectable()
export class MyBlackListService {

    private blockedEmails: string[] = [
        'test@test.com',
        'test@gmail.com',
        'test@online.ua'
    ];

    public getBlackListFromServer(): string[] {
        return this.blockedEmails;
    }

    public checkEmail(emailToCheck: string): Promise<boolean> {

        return new Promise(

            promiseResole => {

                setTimeout(() => {

                    const isBlocked = this.blockedEmails.find(e => e === emailToCheck) !== undefined;

                    promiseResole(isBlocked);

                }, 2000);
            }
        );
    }
}

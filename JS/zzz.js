// AUTO MAPPING FIELDS - WHEN CREATE NEW [] OR {} :

let { age, name } = { test: false, name: "John", age: 23 };

console.log(name); // John

let [x, y, z] = [1, 2, 3, 4, 5];

console.log(z); // 3

// JSON :

let string = JSON.stringify({ squirrel: false, events: ["weekend"] });

console.log(string);  // {"squirrel":false,"events":["weekend"]};

console.log(JSON.parse(string).events);  // ['weekend']

// ==========

var test = {
    "id": 1,
    "changedFields": {
        "System.State": "Active",
        "System.Reason": "Approved",
        "System.AssignedTo": "",
        "Microsoft.VSTS.Common.ActivatedBy": "Plakhtiy Andrew <plakhtiy.andrew@hotmail.com>",
        "Microsoft.VSTS.Common.ActivatedDate": {
            "type": 1
        },
        "Microsoft.VSTS.Common.ClosedDate": null,
        "Microsoft.VSTS.Common.ResolvedBy": "",
        "Microsoft.VSTS.Common.ResolvedDate": null,
        "Microsoft.VSTS.Common.ResolvedReason": "",
        "Microsoft.VSTS.Common.StateChangeDate": {
            "type": 1,
            "value": "2019-12-02T10:08:55.267Z"
        },
        "Microsoft.VSTS.Common.ClosedBy": ""
    }
};

console.log(test.changedFields['Microsoft.VSTS.Common.StateChangeDate']['value']);
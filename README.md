[Sms Alert C# Library For Sms Services](https://smsalert.co.in/)

## Parameters information

* apikey : Api Key(This key is unique for every user, youo can obtain it from your smsalert account)

* number : single or multiple mobile numbers(seperated by comma) (10 digit numbers)

* message : Message Content to be sent

* senderid : Receiver will see this as sender's ID

* route : route name, allocated to your account.


## How to use  

Smsalert obj = new Smsalert("API_KEY");
obj.sendsms("CVTECH", "9999XXXXXX", "test sms", "ROUTE_NAME");

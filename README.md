[Sms Alert C# Library For Sms Services](https://smsalert.co.in/)

## Parameters information

* apikey : Api Key(This key is unique for every user, youo can obtain it from your smsalert account)

* username : Your SMS Alert account username.

* password : Your SMS Alert account password.

* mobileno : single or multiple mobile numbers(seperated by comma) (10 digit numbers)

* message : Message Content to be sent

* senderid : Receiver will see this as sender's ID

* route : route name, allocated to your account.


## How to use  
 If you want to authenticate using API key.
```cs
 Smsalert obj = new Smsalert("API_KEY");
```

 If you want to authenticate using Username and Password.
```cs
 Smsalert obj = new Smsalert("SMSALERT_USERNAME", "SMSALERT_PASSWORD");
```

 To send SMS.
```cs
 obj.sendsms("CVTECH", "9999XXXXXX", "test sms", "ROUTE_NAME");
```

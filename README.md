[Sms Alert C# Api For Sms Services](https://smsalert.co.in/)

## These are following strings should be required for send sms

* apikey : Api Key(This key is unique for every user)

* number : single mobile number (10 digit numbers)

* message : Message Content to send

* senderid : Receiver will see this as sender's ID

* route : If your operator supports multiple routes then give one route name.


## How to use  

//Use Follwing Library into Smsalert.cs file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;


// for creating auth key
		private string authkey;
		public Smsalert(string authkey)
		{
			this.authkey = authkey;
		}

//send to single number
		public string sendsms(string senderid, string mobileno, string text, string route) 
		{
			WebClient client = new WebClient();
			string apiurl = "http://www.smsalert.co.in/api/push.json?apikey=" + this.authkey + "&sender=" + senderid + "&mobileno=" + mobileno + "&text=" + text + "&route=" + route ;
			Stream data = client.OpenRead(apiurl);
			StreamReader reader = new StreamReader(data);
			string response = reader.ReadToEnd();
			data.Close();
			return response;
		}


## License

  [CVT](LICENSE)

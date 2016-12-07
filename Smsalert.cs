using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Smsalert
{
    private string authkey;

	public Smsalert(string authkey)
	{
        this.authkey = authkey;
	}

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
}
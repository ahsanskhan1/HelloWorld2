using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;


namespace HelloWorld.BO
{
	public class ConsumeAPI
	{
		public void GetHelloWorld()  
		{
			using (var client = new WebClient()) //WebClient  
			{
				client.Headers.Add("Content-Type:application/json"); //Content-Type  
				client.Headers.Add("Accept:application/json");
				var result = client.DownloadString(ConfigurationSettings.AppSettings.Get("HelloWorldURI")); //URI  
				Console.WriteLine(Environment.NewLine + result);
			}
		}

		//Get All Products  
		public void GetAKProduts() 
		{
			using (var client = new WebClient()) //WebClient  
			{
				client.Headers.Add("Content-Type:application/json"); //Content-Type  
				client.Headers.Add("Accept:application/json");
				var result = client.DownloadString(ConfigurationSettings.AppSettings.Get("GetAKProdutsURI")); //URI  
				Console.WriteLine(Environment.NewLine + result);
			}
		}

	}
}

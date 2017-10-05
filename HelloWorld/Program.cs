using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.BO;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsumeAPI objAPI = new ConsumeAPI();
			objAPI.GetHelloWorld();
			//objAPI.GetAKProduts();

			WriteToConsole();
			//WriteToFile();
			//WriteToDB();

			Console.ReadKey(); // to prevent screen from shutting down
		}



		static void WriteToConsole()
		{

			List<WriteObj> col = new List<WriteObj>();
			col.AddRange(new WriteObj[1] { new WriteObj { Obj1 = "Hello World Console Param 1", Obj2 = "Hello World Console Param 2" } });

			IWriter a =  new ConsoleWriter();
			a.Write(col);
		}

		static void WriteToFile()
		{
			List<WriteObj> col = new List<WriteObj>();
			col.AddRange(new WriteObj[1] { new WriteObj { Obj1 = "Hello World File Param 1", Obj2 = "Hello World File Param 2" } });

			IWriter b = new FileWriter();
			b.Write(col);
		}
		static void WriteToDB()
		{
			List<WriteObj> col = new List<WriteObj>();
			col.AddRange(new WriteObj[1] { new WriteObj { Obj1 = "Hello World DB Param 1", Obj2 = "Hello World DB Param 2" } });

			IWriter c = new DatabaseWriter();
			c.Write(col);
		}
	}
	
}

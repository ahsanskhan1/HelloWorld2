using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.BO
{
	public class ConsoleWriter : IWriter
	{
		public void Write(List<WriteObj> writeObjList)
		{
			foreach (WriteObj obj in writeObjList)
			{
				Console.WriteLine("Console Writer, Param: " + obj.Obj1);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.BO
{
	public class FileWriter : IWriter
	{
		public void Write(List<WriteObj> writeObjList)
		{
			foreach (WriteObj obj in writeObjList)
			{
				Console.WriteLine("File Writer, Param: " + obj.Obj1);
			}
		}
	}
}

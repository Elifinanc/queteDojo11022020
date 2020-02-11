using System;
using System.Linq;

namespace TestDojo
{

	public class Student : Person
	{
		public List<Single> Notes { get; set; }

		public double Mean()
		{
			Notes.Average();
		}
	}

}

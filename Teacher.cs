using System;
using System.Collections.Generic;
using System.Linq;

public class Teacher : Person
{
	public IEnumerable<Student> Students { get; set; }

	public double Mean()
	{
		double SumMean = 0;

		foreach (Student currentStudent in Students)
        {
			SumMean =  SumMean + currentStudent.Mean();
		}
		return SumMean/Students.Count ;
	}
}

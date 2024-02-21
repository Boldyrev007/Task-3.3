using System;
namespace fpgiuh
{
	class Week:IPrinter
	{
		void IPrinter.Print()
		{
			Console.WriteLine("Понедельник, вторник, среда, четверг, пятница, суббота, воскресенье");
		}
	}
}


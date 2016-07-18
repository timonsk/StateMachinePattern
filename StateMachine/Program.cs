using System;
using Models;

namespace StateMachine
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("State machine pattern");
			var father = new Father();
			father.FindOutMood(Mark.Five);
			father.FindOutMood(Mark.Two);
			father.FindOutMood(Mark.Five);
			father.FindOutMood(Mark.Two);
			father.FindOutMood(Mark.Five);
			father.FindOutMood(Mark.Two);
			father.FindOutMood(Mark.Two);
			father.FindOutMood(Mark.Five);
			father.FindOutMood(Mark.Five);
			father.FindOutMood(Mark.Two);
			father.FindOutMood(Mark.Two);
			father.FindOutMood(Mark.Two);
			Console.ReadKey();
		}
	}
}

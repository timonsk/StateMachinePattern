using System;
using Models;

namespace States
{
	internal class AngerState: AbstractEmotionState
	{
		public AngerState()
		{
			Scold();
		}

		protected override void ChangeState(Father father, Mark mark)
		{
			switch (mark)
			{
				case Mark.Five:
					{
						father.State = new StrongJoyState();
						break;
					}
				case Mark.Two:
					{
						father.State = new StrongAngerState();
						break;
					}
			}
		}

		private void Scold()
		{
			Console.WriteLine("Father is angry that sone got a bad mark");
		}
	}
}


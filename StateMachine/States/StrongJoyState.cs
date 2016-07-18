using System;
using Models;

namespace States
{
	internal class StrongJoyState: AbstractEmotionState
	{
		public StrongJoyState()
		{
			Exult();
		}

		protected override void ChangeState(Father father, Mark mark)
		{
			switch (mark)
			{
				case Mark.Five:
					{
						father.State = new JoyState();
						break;
					}
				case Mark.Two:
					{
						father.State = new PityState();
						break;
					}
			}
		}

		private void Exult()
		{
			Console.WriteLine("Father is happy that sone got a good mark");
		}
	}
}


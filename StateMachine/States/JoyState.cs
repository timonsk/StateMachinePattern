using System;
using Models;

namespace States
{
	internal class JoyState: AbstractEmotionState
	{
		public JoyState()
		{
			Joy();
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
						father.State = new PityState();
						break;
					}
			}
		}

		private void Joy()
		{
			Console.WriteLine("Father is enjoyed that sone got a good mark");
		}
	}
}


using System;
using Models;

namespace States
{
	internal class NeutralState : AbstractEmotionState
	{
		public NeutralState()
		{
			Hope();
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

		private void Hope()
		{
			Console.WriteLine("Father is hopping that sone will get a good mark");
		}
	}
}


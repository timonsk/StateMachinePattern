using System;
using Models;

namespace States
{
	internal class StrongAngerState: AbstractEmotionState
	{
		public StrongAngerState()
		{
			BeatBelt();
		}

		protected override void ChangeState(Father father, Mark mark)
		{
			switch (mark)
			{
				case Mark.Five:
					{
						father.State = new NeutralState();
						break;
					}
				case Mark.Two:
					{
						father.State = new StrongAngerState();
						break;
					}
			}
		}

		private void BeatBelt()
		{
			Console.WriteLine("Father is disappointed that sone got a bad mark");
		}
	}
}


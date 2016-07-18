using System;
using Models;

namespace States
{
	internal class PityState: AbstractEmotionState
	{
		public PityState()
		{
			Calm();
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
						father.State = new AngerState();
						break;
					}
			}
		}

		private void Calm()
		{
			Console.WriteLine("Father is calm that sone got a bad mark");
		}
	}
}


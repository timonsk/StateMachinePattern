using System;
using Models;

namespace States
{
	internal abstract class AbstractEmotionState
	{
		protected abstract void ChangeState(Father father, Mark mark);
		internal virtual void HandleMark(Father father, Mark mark)
		{
			ChangeState(father, mark);
		}
	}
}


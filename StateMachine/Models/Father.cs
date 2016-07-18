using States;

namespace Models
{
	public class Father
	{
		internal AbstractEmotionState State;

		public Father()
		{
			State = new NeutralState();
		}

		public void FindOutMood(Mark mark) 
		{
			State.HandleMark(this, mark);
		}
	}
}


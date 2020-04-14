using System;

namespace Remote
{
	public class Hottub
	{

		internal bool on_Conflict;
		internal int temperature;

		public Hottub()
		{
		}

		public virtual void on()
		{
			on_Conflict = true;
		}

		public virtual void off()
		{
			on_Conflict = false;
		}

		public virtual void bubblesOn()
		{
			if (on_Conflict)
			{
				Console.WriteLine("Hottub is bubbling!");
			}
		}

		public virtual void bubblesOff()
		{
			if (on_Conflict)
			{
				Console.WriteLine("Hottub is not bubbling");
			}
		}

		public virtual void jetsOn()
		{
			if (on_Conflict)
			{
				Console.WriteLine("Hottub jets are on");
			}
		}

		public virtual void jetsOff()
		{
			if (on_Conflict)
			{
				Console.WriteLine("Hottub jets are off");
			}
		}

		public virtual int Temperature
		{
			set
			{
				this.temperature = value;
			}
		}

		public virtual void heat()
		{
			temperature = 105;
			Console.WriteLine("Hottub is heating to a steaming 105 degrees");
		}

		public virtual void cool()
		{
			temperature = 98;
			Console.WriteLine("Hottub is cooling to 98 degrees");
		}

	}

}
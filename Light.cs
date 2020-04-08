using System;

namespace Remote
{
    ////Receiver class
    public class Light
	{
		internal string location;
		internal int level;

		public Light(string location)
		{
			this.location = location;
		}

		public virtual void on()
		{
			level = 100;
			Console.WriteLine("Light is on");
		}

		public virtual void off()
		{
			level = 0;
			Console.WriteLine("Light is off");
		}

		public virtual void dim(int level)
		{
			this.level = level;
			if (level == 0)
			{
				off();
			}
			else
			{
				Console.WriteLine("Light is dimmed to " + level + "%");
			}
		}

		public virtual int Level
		{
			get
			{
				return level;
			}
		}
	}

}
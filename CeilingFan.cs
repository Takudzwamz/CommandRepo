using System;

namespace Remote
{
    ////Receiver class
    public class CeilingFan
	{
		public const int HIGH = 3;
		public const int MEDIUM = 2;
		public const int LOW = 1;
		public const int OFF = 0;
		internal string location;
		internal int speed;

		public CeilingFan(string location)
		{
			this.location = location;
			speed = OFF;
		}

		public virtual void high()
		{
            // turns the ceiling fan on to high
            speed = HIGH;
			Console.WriteLine(location + " ceiling fan is on high");
		}

		public virtual void medium()
		{
            // turns the ceiling fan on to medium
            speed = MEDIUM;
			Console.WriteLine(location + " ceiling fan is on medium");
		}

		public virtual void low()
		{
            // turns the ceiling fan on to low
            speed = LOW;
			Console.WriteLine(location + " ceiling fan is on low");
		}

		public virtual void off()
		{
            // turns the ceiling fan off
            speed = OFF;
			Console.WriteLine(location + " ceiling fan is off");
		}

		public virtual int Speed
		{
			get
			{
				return speed;
			}
		}
	}

}
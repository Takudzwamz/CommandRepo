using System;

namespace Remote
{
	public class Stereo
	{
		internal string location;

		public Stereo(string location)
		{
			this.location = location;
		}

		public virtual void on()
		{
			Console.WriteLine(location + " stereo is on");
		}

		public virtual void off()
		{
			Console.WriteLine(location + " stereo is off");
		}

		public virtual void setCD()
		{
			Console.WriteLine(location + " stereo is set for CD input");
		}

		public virtual void setDVD()
		{
			Console.WriteLine(location + " stereo is set for DVD input");
		}

		public virtual void setRadio()
		{
			Console.WriteLine(location + " stereo is set for Radio");
		}

		public virtual int Volume
		{
			set
			{
				// code to set the value
				// valid range: 1-11 (after all 11 is better than 10, right?)
				Console.WriteLine(location + " Stereo volume set to " + value);
			}
		}
	}

}
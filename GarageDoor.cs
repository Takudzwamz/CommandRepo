using System;

namespace Remote
{
	public class GarageDoor
	{
		internal string location;

		public GarageDoor(string location)
		{
			this.location = location;
		}

		public virtual void up()
		{
			Console.WriteLine(location + " garage Door is Up");
		}

		public virtual void down()
		{
			Console.WriteLine(location + " garage Door is Down");
		}

		public virtual void stop()
		{
			Console.WriteLine(location + " garage Door is Stopped");
		}

		public virtual void lightOn()
		{
			Console.WriteLine(location + " garage light is on");
		}

		public virtual void lightOff()
		{
			Console.WriteLine(location + " garage light is off");
		}
	}

}
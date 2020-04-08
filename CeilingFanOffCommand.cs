namespace Remote
{
    //Concrete Command
    public class CeilingFanOffCommand : Command
	{
		internal CeilingFan ceilingFan;
		internal int prevSpeed;

		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		public virtual void execute()
		{
			prevSpeed = ceilingFan.Speed;
			ceilingFan.off();
		}

		public virtual void undo()
		{
			if (prevSpeed == CeilingFan.HIGH)
			{
				ceilingFan.high();
			}
			else if (prevSpeed == CeilingFan.MEDIUM)
			{
				ceilingFan.medium();
			}
			else if (prevSpeed == CeilingFan.LOW)
			{
				ceilingFan.low();
			}
			else if (prevSpeed == CeilingFan.OFF)
			{
				ceilingFan.off();
			}
		}
	}

}
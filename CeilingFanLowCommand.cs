namespace Remote
{
    //Concrete Command
    public class CeilingFanLowCommand : Command
	{
		internal CeilingFan ceilingFan;
		internal int prevSpeed;

		public CeilingFanLowCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		public virtual void execute()
		{
			prevSpeed = ceilingFan.Speed;
			ceilingFan.low();
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
        public void redo()
        {
            execute();
        }
    }

}
namespace Remote
{
    ////Concrete Command
    public class CeilingFanHighCommand : Command
	{
		internal CeilingFan ceilingFan;
		internal int prevSpeed;

		public CeilingFanHighCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		public virtual void execute()
		{
			prevSpeed = ceilingFan.Speed;
			ceilingFan.high();
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
﻿namespace Remote
{
	public class StereoOnWithCDCommand : Command
	{
		internal Stereo stereo;

		public StereoOnWithCDCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		public virtual void execute()
		{
			stereo.on();
			stereo.setCD();
			stereo.Volume = 11;
		}

        public void redo()
        {
            execute();
        }

        public void undo()
        {
            stereo.off();
            
        }
    }

}
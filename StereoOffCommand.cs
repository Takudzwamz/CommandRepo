namespace Remote
{
	public class StereoOffCommand : Command
	{
		internal Stereo stereo;

		public StereoOffCommand(Stereo stereo)
		{
			this.stereo = stereo;
		}

		public virtual void execute()
		{
			stereo.off();
		}

        public void redo()
        {
            execute();
        }

        public void undo()
        {
            stereo.on();
        }
    }

}
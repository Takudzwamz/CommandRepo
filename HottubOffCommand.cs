namespace Remote
{
	public class HottubOffCommand : Command
	{
		internal Hottub hottub;

		public HottubOffCommand(Hottub hottub)
		{
			this.hottub = hottub;
		}

		public virtual void execute()
		{
			hottub.cool();
			hottub.off();
		}

        public void redo()
        {
            execute();
        }

        public void undo()
        {
            hottub.heat();
            hottub.on();
        }
    }

}
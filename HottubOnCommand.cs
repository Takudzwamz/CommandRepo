namespace Remote
{
	public class HottubOnCommand : Command
	{
		internal Hottub hottub;

		public HottubOnCommand(Hottub hottub)
		{
			this.hottub = hottub;
		}

		public virtual void execute()
		{
			hottub.on();
			hottub.heat();
			hottub.bubblesOn();
		}

        public void redo()
        {
            execute();
        }

        public void undo()
        {
            hottub.off();
            hottub.cool();
            hottub.bubblesOff();
        }
    }

}
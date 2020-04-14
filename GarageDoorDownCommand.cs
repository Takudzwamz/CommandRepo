namespace Remote
{
	public class GarageDoorDownCommand : Command
	{
		internal GarageDoor garageDoor;

		public GarageDoorDownCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		public virtual void execute()
		{
			garageDoor.down();
		}

        public void redo()
        {
            execute();
        }

        public void undo()
        {
            garageDoor.up();
        }
    }

}
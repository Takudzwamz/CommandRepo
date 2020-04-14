namespace Remote
{
	public class GarageDoorUpCommand : Command
	{
		internal GarageDoor garageDoor;

		public GarageDoorUpCommand(GarageDoor garageDoor)
		{
			this.garageDoor = garageDoor;
		}

		public virtual void execute()
		{
			garageDoor.up();
		}

        public void redo()
        {
            execute();
        }

        public void undo()
        {
            garageDoor.down();
        }
    }

}
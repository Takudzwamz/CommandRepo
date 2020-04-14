namespace Remote
{
    ////Concrete Command
    public class LightOnCommand : Command
	{
		internal Light light;
		internal int level;
		public LightOnCommand(Light light)
		{
			this.light = light;
		}

		public virtual void execute()
		{
			level = light.Level;
			light.on();
		}

		public virtual void undo()
		{
			light.dim(level);
		}
        public void redo()
        {
            execute();
        }
    }

}
namespace Remote
{
    //Concrete Command
    public class DimmerLightOnCommand : Command
	{
		internal Light light;
		internal int prevLevel;

		public DimmerLightOnCommand(Light light)
		{
			this.light = light;
		}

		public virtual void execute()
		{
			prevLevel = light.Level;
			light.dim(75);
		}

		public virtual void undo()
		{
			light.dim(prevLevel);
		}
        public void redo()
        {
            execute();
        }
    }

}
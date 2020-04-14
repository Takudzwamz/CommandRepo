namespace Remote
{
    ////Concrete Command
    public class DimmerLightOffCommand : Command
	{
		internal Light light;
		internal int prevLevel;

		public DimmerLightOffCommand(Light light)
		{
			this.light = light;
			prevLevel = 100;
		}

		public virtual void execute()
		{
			prevLevel = light.Level;
			light.off();
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
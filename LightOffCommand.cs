namespace Remote
{
    ////Concrete Command
    public class LightOffCommand : Command
	{
		internal Light light;
		internal int level;
		public LightOffCommand(Light light)
		{
			this.light = light;
		}

		public virtual void execute()
		{
			level = light.Level;
			light.off();
		}

		public virtual void undo()
		{
			light.dim(level);
		}
	}

}
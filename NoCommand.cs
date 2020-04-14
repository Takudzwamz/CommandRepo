namespace Remote
{
	public class NoCommand : Command
	{
		public virtual void execute()
		{
		}
		public virtual void undo()
		{
		}
        public void redo()
        {           
        }
    }
    
}
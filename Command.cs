namespace Remote
{
    //command interface

    public interface Command
	{
		void execute();
		void undo();
        void redo();
	}

   
}
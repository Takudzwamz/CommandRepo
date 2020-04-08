using System.Text;

namespace Remote
{
	//
	// This is the invoker
	//
	public class RemoteControlWithUndo
	{
      
        // This time around the remote is going to handle seven On and
        //Off Commands which we will hold in the corresponding array and the undocommand.
        
		internal Command[] onCommands;
		internal Command[] offCommands;
		internal Command undoCommand;

		public RemoteControlWithUndo()
		{
            /*In the constructor all we need to do is instantiate the on and off arrays.*/

            onCommands = new Command[7];
			offCommands = new Command[7];

			Command noCommand = new NoCommand();
			for (int i = 0;i < 7;i++)
			{
				onCommands[i] = noCommand;
				offCommands[i] = noCommand;
			}
			undoCommand = noCommand;
		}

         /*The setCommand() method takes a slot position and an On and Off command to be stored commands in the On and Off array for later use*/
        public virtual void setCommand(int slot, Command onCommand, Command offCommand)
		{
			onCommands[slot] = onCommand;
			offCommands[slot] = offCommand;
		}

		public virtual void onButtonWasPushed(int slot)
		{
			onCommands[slot].execute();
			undoCommand = onCommands[slot];
		}

       /* When an On or a Off button is pressed, the hardware takes care of calling the corresponding methods OnButtonWasPushed() or OffButtonWasPushed().*/
		public virtual void offButtonWasPushed(int slot)
		{
			offCommands[slot].execute();
			undoCommand = offCommands[slot];
		}

		public virtual void undoButtonWasPushed()
		{
			undoCommand.undo();
		}

        //Used for testing.
        public override string ToString()
		{
			StringBuilder stringBuff = new StringBuilder();
			stringBuff.Append("\n------ Remote Control -------\n");
			for (int i = 0; i < onCommands.Length; i++)
			{

				stringBuff.Append("[slot " + i + "] " + onCommands[i].GetType().FullName + "    " + offCommands[i].GetType().FullName + "\n");
			}

			stringBuff.Append("[undo] " + undoCommand.GetType().FullName + "\n");
			return stringBuff.ToString();
		}
	}

}
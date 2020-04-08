using System;

namespace Remote
{
    //Client
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            Light livingRoomLight = new Light("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();
            remoteControl.offButtonWasPushed(0);
            remoteControl.onButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();

            CeilingFan ceilingFan = new CeilingFan("Living Room");

            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remoteControl.setCommand(0, ceilingFanMedium, ceilingFanOff);
            remoteControl.setCommand(1, ceilingFanHigh, ceilingFanOff);

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(1);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();
        }
    }
}

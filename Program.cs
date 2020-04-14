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
            remoteControl.redoButtonWasPushed();
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

            remoteControl.setCommand(1, ceilingFanMedium, ceilingFanOff);
            remoteControl.setCommand(2, ceilingFanHigh, ceilingFanOff);

            remoteControl.onButtonWasPushed(1);
            remoteControl.redoButtonWasPushed();
            remoteControl.offButtonWasPushed(1);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();

            remoteControl.onButtonWasPushed(2);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();

            GarageDoor garageDoor = new GarageDoor("Garage");
            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);
            remoteControl.setCommand(3, garageDoorUp, garageDoorDown);
            remoteControl.onButtonWasPushed(3);
            Console.WriteLine(remoteControl);
            remoteControl.redoButtonWasPushed();
            remoteControl.offButtonWasPushed(3);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();

            Stereo stereo = new Stereo("Living Room");
            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            remoteControl.setCommand(4, stereoOnWithCD, stereoOff);
            remoteControl.onButtonWasPushed(4);
            remoteControl.redoButtonWasPushed();
            remoteControl.offButtonWasPushed(4);
            Console.WriteLine(remoteControl);
            remoteControl.undoButtonWasPushed();
        }
    }
}

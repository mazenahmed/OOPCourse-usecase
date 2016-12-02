using System;
using static System.Console;

namespace UseCase
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Testing MobilePhone
			MobilePhone mobile1 = new MobilePhone ();
			WriteLine(mobile1.checkStatus ());

			mobile1.turnOff ();
			WriteLine(mobile1.checkStatus ());

			WriteLine(mobile1.getVolume ());
			mobile1.decreaseVolume ();

			mobile1.turnOn ();

			WriteLine(mobile1.getVolume ());
			mobile1.increaseVolume ();
			mobile1.increaseVolume ();
			mobile1.increaseVolume ();
			mobile1.increaseVolume ();
			WriteLine(mobile1.getVolume ());
			WriteLine ();

			//Polymorphic Lines
			Device d;
			d = mobile1;
			WriteLine (d.getVolume ());
			WriteLine ();

			//Testing PC
			PC pc1 = new PC ();
			pc1.input ("Typing...!!");
			WriteLine (pc1.output ());

			//Polymorphic Lines
			d = pc1;
			WriteLine (d.getVolume ());
			WriteLine ();

			//Testsing Factory
			DeviceFactoryPattern dfp = new DeviceFactoryPattern ();
			IInteractive pc2 = dfp.getInstance ("MObilePhonE");
			pc2.input ("Hi!");
			WriteLine (pc2.output ());

		}
	}
}
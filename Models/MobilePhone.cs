using System;

namespace UseCase
{
	public class MobilePhone:Device,IInteractive
	{
		public MobilePhone ()
		{
			Console.WriteLine ("Mobile is Starting...");
			base.on = true;
		}

		public void input(string c){
			base.inputValue = c;
		}
		public string output(){
			return base.inputValue;
		}

		public override void increaseVolume ()
		{
			if (!on) {
				Console.WriteLine ("Your Mobile is Off");
				return;
			}
				
			base.increaseVolume ();
			base.volumeLevel = (base.volumeLevel >= 10) ? 10 : base.volumeLevel;
		}

		public override void decreaseVolume ()
		{
			if (!on) {
				Console.WriteLine ("Your Mobile is Off");
				return;
			}

			base.decreaseVolume ();
			base.volumeLevel = (base.volumeLevel <= 0) ? 0 : base.volumeLevel;
		}

	}
}
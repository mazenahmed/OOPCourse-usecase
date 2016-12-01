using System;

namespace UseCase
{
	public class PC:Device,IInteractive
	{
		public PC ()
		{
			Console.WriteLine("PC is Starting.....");
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
				Console.WriteLine ("Your PC is Off");
				return;
			}
			base.volumeLevel = (base.volumeLevel >= 100) ? 100 : base.volumeLevel+1;
		}

		public override void decreaseVolume ()
		{
			if (!on) {
				Console.WriteLine ("Your PC is Off");
				return;
			}
			base.volumeLevel = (base.volumeLevel <= 0) ? 0 : base.volumeLevel-1;
		}


	}
}


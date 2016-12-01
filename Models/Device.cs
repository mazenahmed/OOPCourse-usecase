using System;

namespace UseCase
{
	public class Device
	{
		public Device ()
		{
			this.on = false;
			this.volumeLevel = 0;
			inputValue = "";
		}

		protected int volumeLevel;
		protected bool on;
		protected string inputValue;

		public void turnOn(){
			on = true;
		}

		public void turnOff(){
			on = false;
		}

		public virtual void increaseVolume(){
			volumeLevel++;
		}

		public virtual void decreaseVolume(){
			volumeLevel--;
		}

		public bool checkStatus(){
			return on == true;
		}
			

		public int getVolume(){
			return volumeLevel;
		}
			
	}
}


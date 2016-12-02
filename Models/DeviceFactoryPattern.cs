using System;

namespace UseCase
{
	public class DeviceFactoryPattern
	{
		public IInteractive getInstance(string s){
			if (s.ToLower().Equals ("mobilephone"))
				return new MobilePhone ();		
			else if (s.ToLower().Equals("pc"))
				return new PC ();
			return null;
		}
	}
}


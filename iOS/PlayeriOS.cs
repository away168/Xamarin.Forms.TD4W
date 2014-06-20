using System;
using MonoTouch.AudioToolbox;
using MonoTouch.AVFoundation;
using MonoTouch.Foundation;
using System.IO;

[assembly: Xamarin.Forms.Dependency (typeof (TD4WApp.iOS.PlayeriOS)) ]

namespace TD4WApp.iOS
{
	public class PlayeriOS : IPlayer
	{
		AVAudioPlayer player;

		public PlayeriOS()
		{

		}

		public void Play(int selector)
		{
			string fileName;
			if (selector == 0)
			{
				fileName = "TD4WShort.mp3";
			}
			else 
			{
				fileName = "ATeamShort.mp3";
			}
			string localUrl = Path.Combine (NSBundle.MainBundle.BundlePath, fileName);
			player = AVAudioPlayer.FromUrl (NSUrl.FromFilename (localUrl));
			player.Play ();
		}
	}
}


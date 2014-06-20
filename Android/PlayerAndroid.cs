using System;
using Android.Media;
using Xamarin.Forms;
using Java.IO;

[assembly: Xamarin.Forms.Dependency (typeof(TD4WApp.Android.PlayerAndroid))]

namespace TD4WApp.Android {

	public class PlayerAndroid : Java.Lang.Object, IPlayer {

		MediaPlayer player;

		public PlayerAndroid () {
			player = new MediaPlayer ();
			player.Prepared += (s, e) => player.Start();
		}

		public async void Play(int selector)
		{
			player.Reset();
			global::Android.Content.Res.AssetFileDescriptor fd;
			if (selector == 0) {
				fd = Forms.Context.Assets.OpenFd ("TD4WShort.mp3");
			}
			else
			{
				fd = Forms.Context.Assets.OpenFd ("ATeamShort.mp3");
			}
			await player.SetDataSourceAsync (fd.FileDescriptor, fd.StartOffset, fd.Length);
			player.PrepareAsync ();
		}
	}
}


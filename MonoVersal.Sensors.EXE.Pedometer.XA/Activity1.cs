using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MonoVersal.Sensors.EXE.Pedometer.XA
{
	[Activity(Label = "MonoVersal.Sensors.EXE.Pedometer.XA", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 
		: 
		  Activity
		, Android.Hardware.ISensorEventListener
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			_sensorManager = (Android.Hardware.SensorManager)GetSystemService(Context.SensorService);
			_sensorTextView = FindViewById<TextView>(Resource.Id.accelerometer_text);

			return;
		}






		protected override void OnResume()
		{
			base.OnResume();
			_sensorManager.RegisterListener
								(
								  this
								, _sensorManager.GetDefaultSensor(Android.Hardware.SensorType.Accelerometer)
								, Android.Hardware.SensorDelay.Ui
								);
		}


		// http://docs.xamarin.com/recipes/android/os_device_resources/accelerometer/get_accelerometer_readings
		private Android.Hardware.SensorManager _sensorManager; 
		private TextView _sensorTextView; 
		private static readonly object _syncLock = new object();

		public void OnAccuracyChanged
					(
					  Android.Hardware.Sensor sensor
					, Android.Hardware.SensorStatus accuracy
					)
		{
			// We don't want to do anything here.
		}

		public void OnSensorChanged(Android.Hardware.SensorEvent e)
		{
			lock (_syncLock)
			{
				var text = new System.Text.StringBuilder("x = ")
					.Append(e.Values[0])
					.Append(", y=")
					.Append(e.Values[1])
					.Append(", z=")
					.Append(e.Values[2]);
				_sensorTextView.Text = text.ToString();
			}
		}
	}
}


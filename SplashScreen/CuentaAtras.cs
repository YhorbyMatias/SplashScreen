using System;
using Android.OS;
using Android.App;

namespace SplashScreen
{
	public class CuentaAtras : CountDownTimer
	{
		private Activity _Actividad;
		private Activity _Lanzar;

		public CuentaAtras (long miliSegundos, long cuentaAtras, Activity actividad,
			Activity lanzar):base (miliSegundos, cuentaAtras)
		{
			_Actividad = actividad;
			_Lanzar = lanzar;
		}

		public override void OnFinish ()
		{
			_Actividad.StartActivity (_Lanzar.GetType());
			_Actividad.Finish ();
		}

		public override void OnTick (long miliSegundos)
		{

		}

	}
}


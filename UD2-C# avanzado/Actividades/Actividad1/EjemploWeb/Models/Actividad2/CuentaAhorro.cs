namespace ConsolaWeb.Models.Actividad2
{
	public class CuentaAhorro : Cuenta
	{
		float cuotaMantenimiento;

		public CuentaAhorro()
		{
		}

		public CuentaAhorro(string nom, string cue, double sal, double tipo, float cuotaMantenimiento) : base(nom, cue, sal, tipo)
		{
			CuotaMantenimiento = cuotaMantenimiento;
		}

		public float CuotaMantenimiento
		{
			get => cuotaMantenimiento;
			set
			{
				if (value >= 0)
				{
					this.cuotaMantenimiento	= value;
				}
			}
		}

		public override void reintegro(double cantidad)
		{
			if (this.saldo > 1500 && this.tipoDeInterés >= 3.5)
			{
				base.reintegro(cantidad);
			}
		}

		public override string CuantoVoyAGanarEnXAnhos(int anhos)
		{
			string infoCuenta;

			infoCuenta = "En " + anhos + "la cuenta va a generar " + (this.saldo * this.tipoDeInterés/100) * anhos * 2;

			return infoCuenta;
		}
	}
}

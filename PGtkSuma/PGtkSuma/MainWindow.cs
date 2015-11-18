using System;
using Gtk;
public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		Decimal primero = Decimal.Parse(entry3.Text);
		Decimal segundo = Decimal.Parse(entry4.Text);
		Decimal resultado = primero + segundo;
		label8.Text = resultado.ToString ();
	}

	protected void OnButton3Clicked (object sender, EventArgs e)
	{
		Decimal primero = Decimal.Parse(entry3.Text);
		Decimal segundo = Decimal.Parse(entry4.Text);
		Decimal resultado = primero - segundo;
		label2.Text = resultado.ToString ();
	}

	protected void OnButton5Clicked (object sender, EventArgs e)
	{
		Decimal primero = Decimal.Parse(entry3.Text);
		Decimal segundo = Decimal.Parse(entry4.Text);
		Decimal resultado = primero * segundo;
		label3.Text = resultado.ToString ();
	}

	protected void OnButton6Clicked (object sender, EventArgs e)
	{
		Decimal primero = Decimal.Parse(entry3.Text);
		Decimal segundo = Decimal.Parse(entry4.Text);
		Decimal resultado = primero / segundo;
		label4.Text = resultado.ToString ();
	}

	protected void OnButton7Clicked (object sender, EventArgs e)
	{
		//Decimal primero = Decimal.Parse(entry3.Text);
		//Decimal segundo = Decimal.Parse(entry4.Text);
		//Decimal resultado = Math.exp(primero, segundo);
		//label5.Text = resultado.ToString ();
	}

	protected void OnButton8Clicked (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}
}

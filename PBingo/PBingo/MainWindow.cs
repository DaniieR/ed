using System;
using Gtk;
using System.Diagnostics;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{	
	private Random random; 
	private readonly Gdk.Color GREEN_COLOR = new Gdk.Color(0, 255, 0);
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		random = new Random ();
		Table table = new Table (9 , 10, true);
		List<Button> buttons = new List<Button> ();
		List<int> numeros = new List<int> ();
		for (uint index = 0; index < 90; index++){
			Button button = new Button ();
			int numero = (int)index + 1;
			button.Label = numero.ToString();
			button.Visible = true;
			uint row= index / 10;
			uint column=index % 10;
			table.Attach (button, column, column + 1 ,row ,row + 1);
			buttons.Add (button);
			numeros.Add (numero);
		}
		//		//Opción 2
		//		for (uint row = 0; row < 9; row++)
		//			for (uint column=0; column < 10; column++) {
		//				uint index = row * 10 + column;
		//				Button button = new Button ();
		//				button.Label = (index + 1).ToString();
		//				button.Visible = true;
		//				table.Attach (button, column, column + 1, row, row + 1);
		//			}
		table.Visible = true;
		vbox1.Add (table);
		buttonnumero.Clicked += delegate {
			int indexAleatorio = random.Next (numeros.Count);
			int numero = numeros [indexAleatorio];
			labelnumero.Text=numero.ToString();
			numeros.RemoveAt(indexAleatorio);
			indexAleatorio++;
			Button button = buttons [numero-1];
			button.ModifyBg (StateType.Normal, GREEN_COLOR);
			Process.Start ("espeak", "-v es " + (indexAleatorio+1));
			buttonnumero.Sensitive = buttons.Count>0;
		};
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}

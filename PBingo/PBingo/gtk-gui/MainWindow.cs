
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.VBox vbox3;
	private global::Gtk.HBox hbox9;
	private global::Gtk.Label label9;
	private global::Gtk.Label labelnumero;
	private global::Gtk.Button buttonnumero;
	private global::Gtk.Button button12;
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.HBox hbox2;
	private global::Gtk.HBox hbox3;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox ();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero");
		this.hbox9.Add (this.label9);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.label9]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.labelnumero = new global::Gtk.Label ();
		this.labelnumero.Name = "labelnumero";
		this.labelnumero.LabelProp = global::Mono.Unix.Catalog.GetString ("...");
		this.hbox9.Add (this.labelnumero);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.labelnumero]));
		w2.Position = 1;
		// Container child hbox9.Gtk.Box+BoxChild
		this.buttonnumero = new global::Gtk.Button ();
		this.buttonnumero.CanFocus = true;
		this.buttonnumero.Name = "buttonnumero";
		this.buttonnumero.UseStock = true;
		this.buttonnumero.UseUnderline = true;
		this.buttonnumero.Label = "gtk-go-forward";
		this.hbox9.Add (this.buttonnumero);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.buttonnumero]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox3.Add (this.hbox9);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox9]));
		w4.Position = 0;
		w4.Expand = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.button12 = new global::Gtk.Button ();
		this.button12.CanFocus = true;
		this.button12.Name = "button12";
		this.button12.UseUnderline = true;
		this.button12.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.vbox3.Add (this.button12);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.button12]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w6.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w7.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w8.Position = 2;
		this.vbox3.Add (this.vbox1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox1]));
		w9.Position = 2;
		this.Add (this.vbox3);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 402;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}

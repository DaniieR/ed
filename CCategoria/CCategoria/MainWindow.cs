using System;
using Gtk;
using System.Data;
using MySql.Data.MySqlClient;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();


		treeView.AppendColumn ("id", new CellRendererText (), "text", 0);
		treeView.AppendColumn ("nombre", new CellRendererText (), "text", 1);
		ListStore listStore = new ListStore (typeof(long), typeof(string));
		treeView.Model = listStore;
		//listStore.AppendValues (33L, "Treinta y tres");

		IDbConnection dbConnection = new MySqlConnection ("Database=dbprueba;user=root;password=sistemas");
		dbConnection.Open ();

		//Las Operaciones que toquen

		//IDbCommand insertdbCommand = dbConnection.CreateCommand ();
		//insertdbCommand.CommandText = "insert into categoria (nombre) values ('categoria 4')";
		//insertdbCommand.ExecuteNonQuery ();

		IDbCommand dbCommand = dbConnection.CreateCommand();
		dbCommand.CommandText = "select * from categoria";
		IDataReader dataReader = dbCommand.ExecuteReader ();
		while (dataReader.Read()) {
			//Console.WriteLine ("id={0} nombre={1}", dataReader ["id"], dataReader ["nombre"]);
			listStore.AppendValues (dataReader ["id"], dataReader ["nombre"]);
		}
		dataReader.Close ();


		newAction.Activated += delegate {
			CategoriaView categoriaView = new CategoriaView();
		};

		//dbConnection.Close ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnNewActionActivated (object sender, EventArgs e)
	{
		Console.WriteLine ("HOLA");
	}
}

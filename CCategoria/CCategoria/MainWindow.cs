using System;
using Gtk;
using System.Data;
using MySql.Data.MySqlClient;
using CCategoria;
public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();


		treeView.AppendColumn ("id", new CellRendererText (), "text", 0);
		treeView.AppendColumn ("nombre", new CellRendererText(), "text", 1);

		ListStore liststore = new ListStore(typeof(long), typeof(string));
		treeView.Model = liststore;

		//liststore.AppendValues (33L, "Treinta y tres");

		App.Instance.DbConnection = new MySqlConnection ("Database=dbprueba;user=root;password=sistemas");
		App.Instance.DbConnection.Open ();

		//operaciones (insert, select...) 

		//IDbCommand insertDbCommand = dbConnection.CreateCommand ();
		//insertDbCommand.CommandText = "insert into categoria (nombre) values ('categoria 2')";
		//insertDbCommand.ExecuteNonQuery ();

		//Las operaciones que toquen

		IDbCommand dbcommand = App.Instance.DbConnection.CreateCommand ();
		dbcommand.CommandText = "select * from categoria";
		IDataReader dataReader = dbcommand.ExecuteReader ();
		while (dataReader.Read()) {
			//Console.WriteLine ("id={0} nombre={1}", dataReader ["id"], dataReader ["nombre"]);
			liststore.AppendValues (dataReader ["id"], dataReader ["nombre"]);
		}
		dataReader.Close ();
		newAction.Activated += delegate {
			CCategoria.CategoriaView categoriaView = new CCategoria.CategoriaView(); 
		};

		deleteAction.Activated += delegate {
			Console.WriteLine ("deleteAction Activated");
			TreeIter treeIter;
			treeView.Selection.GetSelected(out treeIter);
			object id=liststore.GetValue(treeIter, 0);
			Console.WriteLine ("deleteAction Activated id = {0}", id);
		};

		treeView.Selection.Changed += delegate {
			Console.WriteLine ("TreeView Selection Changed CountSelectedRows()={0}",
			treeView.Selection.CountSelectedRows());
			refreshAction();
	};
		//dbConnection.Close ();
	}

	private void refreshAction(){
		deleteAction.Sensitive = treeView.Selection.CountSelectedRows() > 0;
	}
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}


	protected void OnNewActionActivated (object sender, EventArgs e)
	{

	}
}
package com.mycompany.acategoria;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.provider.BaseColumns;

/**
 * Created by mati on 25/05/16.
 */
public class DbPruebaOpenHelper extends SQLiteOpenHelper {
    private static final String DATABASE_NAME = "dbprueba.db";
    private static final int DATABASE_VERSION = 1;
    public static abstract class TablaCategoria implements BaseColumns{
        public static final String NAME = "Categoria";
        public static final String COLUMN_NOMBRE = "nombre";
    }
    private static final String CREATE_TABLE_CATEGORIA ="Create table " + TablaCategoria.NAME + "("
            + TablaCategoria._ID+ "integer primary key, "+ TablaCategoria.COLUMN_NOMBRE + "Text" + ");";

    public DbPruebaOpenHelper(Context context) {
        super(context,DATABASE_NAME, null, DATABASE_VERSION);
    }

    public void onCreate(SQLiteDatabase db){
        db.execSQL(CREATE_TABLE_CATEGORIA);
    }
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion){

    }
}

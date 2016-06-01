package com.mycompany.acategoria;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.provider.BaseColumns;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by mati on 25/05/16.
 */
public class DbPruebaOpenHelper extends SQLiteOpenHelper {
    private static final String DATABASE_NAME = "dbprueba.db";
    private static final int DATABASE_VERSION = 3;

    private static Context context;
    public static void init(Context context){
        DbPruebaOpenHelper.context = context;
    }

    private static DbPruebaOpenHelper instance;
    public static DbPruebaOpenHelper getInstance() {
        if (instance==null)
            instance = new DbPruebaOpenHelper(context);
        return instance;
    }

    public static abstract class TablaCategoria implements BaseColumns{
        public static final String NAME = "Categoria";
        public static final String COLUMN_NOMBRE = "nombre";
    }

    private static final String CREATE_TABLE_CATEGORIA ="Create table " + TablaCategoria.NAME + " ("
            + TablaCategoria._ID + " integer primary key, "+ TablaCategoria.COLUMN_NOMBRE + " Text" + ");";
    private static final String DROP_TABLE_CATEGORIA = "drop table if exists "+ TablaCategoria.NAME;

    public DbPruebaOpenHelper(Context context) {
        super(context,DATABASE_NAME, null, DATABASE_VERSION);
    }

    public void onCreate(SQLiteDatabase db){

        db.execSQL(CREATE_TABLE_CATEGORIA);
    }
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion){
        db.execSQL(DROP_TABLE_CATEGORIA);
        onCreate(db);
    }
    public long insertCategoria (String nombre){
        SQLiteDatabase sqLiteDatabase = getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(TablaCategoria.COLUMN_NOMBRE, nombre);
        return sqLiteDatabase.insert(TablaCategoria.NAME, null, contentValues);
    }

    public List<Categoria> getCategorias(){
        SQLiteDatabase sqLiteDatabase = getReadableDatabase();
        String[] columns = new String[]{
                TablaCategoria._ID,
                TablaCategoria.COLUMN_NOMBRE,
        };
        Cursor cursor = sqLiteDatabase.query(
                TablaCategoria.NAME,
                columns,
                null,
                null,
                null,
                null,
                null
        );
        List<Categoria> categorias = new ArrayList<>();

        while (cursor.moveToNext())
            categorias.add(new Categoria(cursor.getLong(0),cursor.getString(1)));
        cursor.close();

        return categorias;
    }
}

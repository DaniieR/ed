package com.mycompany.acategoria;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        DbPruebaOpenHelper.init(this);
        //DbPruebaOpenHelper.getInstance().insertCategoria("Categoria 1");
        //DbPruebaOpenHelper.getInstance().insertCategoria("Categoria 2");
        //DbPruebaOpenHelper.getInstance().insertCategoria("Categoria 3");
        //DbPruebaOpenHelper.getInstance().insertCategoria("Categoria 4");

        ListView listView = (ListView) findViewById(R.id.listView);
        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(
                this,
                android.R.layout.simple_list_item_1,
                new String[] {"Uno", "Dos"}
        );
        listView.setAdapter(arrayAdapter);
    }
}

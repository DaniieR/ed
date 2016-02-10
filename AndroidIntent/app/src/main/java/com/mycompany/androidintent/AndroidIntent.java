package com.mycompany.androidintent;

import android.net.Uri;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.gms.appindexing.Action;
import com.google.android.gms.appindexing.AppIndex;
import com.google.android.gms.common.api.GoogleApiClient;

public class AndroidIntent extends AppCompatActivity {
    private EditText oper1, oper2;
    private TextView resultadoTextView;
    /**
     * ATTENTION: This was auto-generated to implement the App Indexing API.
     * See https://g.co/AppIndexing/AndroidStudio for more information.
     */
    private GoogleApiClient client;

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_android_intent);
        oper1 = (EditText) findViewById(R.id.editText);
        oper2 = (EditText) findViewById(R.id.editText2);
        resultadoTextView = (TextView) findViewById(R.id.textView4);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.
        client = new GoogleApiClient.Builder(this).addApi(AppIndex.API).build();
    }

    public void sumar(View v) {
//convertimos a número los valores introducidos y operamos
        double n1 = Double.parseDouble(oper1.getText().toString());
        double n2 = Double.parseDouble(oper2.getText().toString());
        double sum = n1 + n2;
        mostrar(sum);
    }

    public void restar(View v) {
//convertimos a número los valores introducidos y operamos
        double n1 = Double.parseDouble(oper1.getText().toString());
        double n2 = Double.parseDouble(oper2.getText().toString());
        double res = n1 - n2;
        mostrar(res);
    }

    public void multiplicar(View v) {
//convertimos a número los valores introducidos y operamos
        double n1 = Double.parseDouble(oper1.getText().toString());
        double n2 = Double.parseDouble(oper2.getText().toString());
        double mul = n1 * n2;
        mostrar(mul);
    }

    public void dividir(View v) {
//convertimos a número los valores introducidos y operamos
        double n1 = Double.parseDouble(oper1.getText().toString());
        double n2 = Double.parseDouble(oper2.getText().toString());
        double div = n1 / n2;
        mostrar(div);
    }
    private void mostrar(double res) {
/*mostramos resultado en un Toast
        Object Resultado;
        Toast.makeText(this, "Resultado: " + res, Toast.LENGTH_LONG).show();*/
        resultadoTextView.setText(String.valueOf(res));
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @Override
    public void onStart() {
        super.onStart();

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.
        client.connect();
        Action viewAction = Action.newAction(
                Action.TYPE_VIEW, // TODO: choose an action type.
                "AndroidIntent Page", // TODO: Define a title for the content shown.
                // TODO: If you have web page content that matches this app activity's content,
                // make sure this auto-generated web page URL is correct.
                // Otherwise, set the URL to null.
                Uri.parse("http://host/path"),
                // TODO: Make sure this auto-generated app deep link URI is correct.
                Uri.parse("android-app://com.mycompany.androidintent/http/host/path")
        );
        AppIndex.AppIndexApi.start(client, viewAction);
    }

    @Override
    public void onStop() {
        super.onStop();

        // ATTENTION: This was auto-generated to implement the App Indexing API.
        // See https://g.co/AppIndexing/AndroidStudio for more information.
        Action viewAction = Action.newAction(
                Action.TYPE_VIEW, // TODO: choose an action type.
                "AndroidIntent Page", // TODO: Define a title for the content shown.
                // TODO: If you have web page content that matches this app activity's content,
                // make sure this auto-generated web page URL is correct.
                // Otherwise, set the URL to null.
                Uri.parse("http://host/path"),
                // TODO: Make sure this auto-generated app deep link URI is correct.
                Uri.parse("android-app://com.mycompany.androidintent/http/host/path")
        );
        AppIndex.AppIndexApi.end(client, viewAction);
        client.disconnect();
    }
}

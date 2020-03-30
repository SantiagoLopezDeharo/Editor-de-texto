using System;
using Gtk;
using System.IO;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
    protected void mayusculas(object sender, EventArgs e)
    {
        textview1.Buffer.Text = textview1.Buffer.Text.ToUpper();
    }

    protected void minusculas(object sender, EventArgs e)
    {
        textview1.Buffer.Text = textview1.Buffer.Text.ToLower();
    }

    protected void borrar(object sender, EventArgs e)
    {
        textview1.Buffer.Text = "";
    }

    protected void guardar(object sender, EventArgs e)
    {
        string a = entry1.Text;
        if (a == "")
        {
            a = "Texto_Prueba.txt";
        }
        StreamWriter texto = new StreamWriter(a);
        texto.WriteLine(textview1.Buffer.Text);
        texto.Dispose();
        texto.Close();

    }

    protected void cargar(object sender, EventArgs e)
    {
        string a = entry1.Text;
        if (File.Exists(a))
            {
            StreamReader reader = new StreamReader(a);
            textview1.Buffer.Text = reader.ReadToEnd();
            reader.Dispose();
            reader.Close();
            }
        else
        {
            textview1.Buffer.Text = "{ERROR: ARCHIVO NO EXISTE}";
        }
    }

    protected void delete(object sender, EventArgs e)
    {
        string a = entry1.Text;
        if (File.Exists(a))
            {
            File.Delete(a);
            }
        else
        {
            textview1.Buffer.Text = "{ERROR: ARCHIVO NO EXISTE}";
        }
    }

    protected void existance(object sender, EventArgs e)
    {
        string a = entry1.Text;
        if (File.Exists(a))
            {
            textview1.Buffer.Text = "Archivo existe.";
            }
        else
        {
            textview1.Buffer.Text = "ARCHIVO NO EXISTE.";
        }
    }
}

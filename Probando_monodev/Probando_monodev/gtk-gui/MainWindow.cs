
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Alignment alignment1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Button button2;

	private global::Gtk.Button button3;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Button button5;

	private global::Gtk.Button button6;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Button button7;

	private global::Gtk.Button button8;

	private global::Gtk.Button button9;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textview1;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Label label1;

	private global::Gtk.Entry entry1;

	private global::Gtk.HButtonBox hbuttonbox1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.alignment1 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("Mayusculas");
		this.hbox1.Add(this.button2);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button2]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Minusculas");
		this.hbox1.Add(this.button3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button3]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.button5 = new global::Gtk.Button();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString("Borrar todo");
		this.hbox3.Add(this.button5);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.button5]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.button6 = new global::Gtk.Button();
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString("Guardar");
		this.hbox3.Add(this.button6);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.button6]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.button7 = new global::Gtk.Button();
		this.button7.CanFocus = true;
		this.button7.Name = "button7";
		this.button7.UseUnderline = true;
		this.button7.Label = global::Mono.Unix.Catalog.GetString("Cargar");
		this.hbox5.Add(this.button7);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.button7]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.button8 = new global::Gtk.Button();
		this.button8.CanFocus = true;
		this.button8.Name = "button8";
		this.button8.UseUnderline = true;
		this.button8.Label = global::Mono.Unix.Catalog.GetString("Eliminar archivo");
		this.hbox5.Add(this.button8);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.button8]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.button9 = new global::Gtk.Button();
		this.button9.CanFocus = true;
		this.button9.Name = "button9";
		this.button9.UseUnderline = true;
		this.button9.Label = global::Mono.Unix.Catalog.GetString("Comprobar existencia");
		this.hbox5.Add(this.button9);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.button9]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.hbox3.Add(this.hbox5);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.hbox5]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		this.hbox1.Add(this.hbox3);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox3]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox1.Add(this.hbox1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow.Add(this.textview1);
		this.vbox1.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w12.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre para el archivo:");
		this.hbox4.Add(this.label1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label1]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.MaxLength = 45;
		this.entry1.InvisibleChar = '•';
		this.hbox4.Add(this.entry1);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entry1]));
		w14.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox();
		this.hbuttonbox1.Name = "hbuttonbox1";
		this.hbox4.Add(this.hbuttonbox1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbuttonbox1]));
		w15.Position = 2;
		this.vbox1.Add(this.hbox4);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
		w16.Position = 2;
		w16.Expand = false;
		w16.Fill = false;
		this.alignment1.Add(this.vbox1);
		this.Add(this.alignment1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 735;
		this.DefaultHeight = 408;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler(this.mayusculas);
		this.button3.Clicked += new global::System.EventHandler(this.minusculas);
		this.button5.Clicked += new global::System.EventHandler(this.borrar);
		this.button6.Clicked += new global::System.EventHandler(this.guardar);
		this.button7.Clicked += new global::System.EventHandler(this.cargar);
		this.button8.Clicked += new global::System.EventHandler(this.delete);
		this.button9.Clicked += new global::System.EventHandler(this.existance);
	}
}

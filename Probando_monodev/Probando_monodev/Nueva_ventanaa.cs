using System;
namespace Probando_monodev
{
    public partial class Nueva_ventanaa : Gtk.Window
    {
        public Nueva_ventanaa() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}

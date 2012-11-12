using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DictionaryPlatform
{
    public partial class MainWindow : Form
    {
        ClipboardMonitor cm;
        Hotkey hk;
        public MainWindow()
        {
            InitializeComponent();
            cm = new ClipboardMonitor();
            cm.ClipboardChanged += cm_ClipboardChanged;



            hk = new Hotkey();
            hk.KeyCode = Keys.D1;
            hk.Windows = false;
            hk.Control = true;
            hk.Pressed += delegate { Console.WriteLine("Windows+1 pressed!"); };

            if (!hk.GetCanRegister(this))
            {
                Console.WriteLine("Whoops, looks like attempts to register will fail or throw an exception, show an error/visual user feedback");
            }
            else
            {
                hk.Register(this);
            }

            //// .. later, at some point
            //if (hk.Registered)
            //{ hk.Unregister(); }

        }

        void cm_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
        {
            Console.WriteLine(e.ClipboardContent);
        }
    }
}

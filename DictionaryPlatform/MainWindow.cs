﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
            cm = new ClipboardMonitor();
            cm.ClipboardChanged += cm_ClipboardChanged;
        }

        void cm_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
        {
            Console.WriteLine(e.ClipboardContent);
        }
    }
}

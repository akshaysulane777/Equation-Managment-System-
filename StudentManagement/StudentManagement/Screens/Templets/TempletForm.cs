using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManagement.Screens.Templets
{
    public partial class TempletForm : Form
    {
        public TempletForm()
        {
            InitializeComponent();
        }
        public bool IsUpdate { get; set; }
    }
}

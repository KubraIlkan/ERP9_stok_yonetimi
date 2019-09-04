using Sy.Forms.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sy.Core.Entities;
using Sy.Businees.Repository;
using Sy.Core.ComplexTypes;

namespace Sy.Forms
{
    public partial class Form1 : Form
    {
        private Repository<Product, Guid> _productRepo;

        public bool UserInfo { get; private set; }

        public Form1()
        {
            _productRepo = new Repository<Product, Guid>();
            InitializeComponent();
        }

        private void lblHosgeldiniz_Click(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            if (StockSettings.UserInfo == null)
            {
                gbGiris.Visible = true;
                lblHosgeldiniz.Visible = false;
            }
            else
            {
                gbGiris.Visible = false;
                lblHosgeldiniz.Visible = true;
                lblHosgeldiniz.Text = StockSettings.UserInfo.Display;
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }
    }
}

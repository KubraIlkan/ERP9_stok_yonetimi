using Sy.Businees.Repository;
using Sy.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sy.Core.Abstracts;
using Sy.Core.ViewModels;
using Sy.Core.Enums;

namespace Sy.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private readonly IRepository<Client, int> _clientRepository;

        public RegisterForm()
        {
            InitializeComponent();
            _clientRepository = new Repository<Client, int>();
        }

        

      

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            var model = new RegisterViewModel()
            {
                Email = txtEmail.Text,
                Name = txtAd.Text,
                Surname = txtSoyad.Text,
                Password = txtSifre.Text
            };

            var kontrol = _clientRepository
                .Query(x => x.Email == model.Email).Any();
            if (kontrol)
            {
                MessageBox.Show(text: "Bu email adresi kullanılmaktadır!");
                return;
            }
            _clientRepository.Insert(new Client()
            {
                Email = model.Email,
                Surname = model.Surname,
                Password = model.Password,
                Name = model.Name
            });
            MessageBox.Show(text: $"Kayıt işleminiz başarılıdır.\n{model.Name} {model.Surname}");
            this.Close();
        }
    }
}
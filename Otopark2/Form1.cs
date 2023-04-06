using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Otopark2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void SearchProducts(string key)
        {
            var results = _productDal.GetAll().Where(p => p.Plaka.Contains(key)).ToList();
            dgwProducts.DataSource = results;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

                AracDoluluk();

                LoadProducts();
            
        }

        private void AracDoluluk()
        {

            



            int i = Convert.ToInt32(txtYer.Text);

            
            

            if (i == 1)
            {
                if(lblN1.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN1.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 2)
            {
                if (lblN2.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN2.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 3)
            {
                if (lblN3.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN3.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 4)
            {
                if (lblN4.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN4.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 5)
            {
                if (lblN5.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN5.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 6)
            {
                if (lblN6.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN6.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 7)
            {
                if (lblN7.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN7.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 8)
            {
                if (lblN8.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN8.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 9)
            {
                if (lblN9.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN9.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 10)
            {
                if (lblN10.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN10.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 11)
            {
                if (lblN11.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN11.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 12)
            {
                if (lblN12.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN12.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 13)
            {
                if (lblN13.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN13.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 14)
            {
                if (lblN14.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN14.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 15)
            {
                if (lblN15.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN15.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 16)
            {
                if (lblN16.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN16.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 17)
            {
                if (lblN17.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN17.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 18)
            {
                if (lblN18.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN18.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 19)
            {
                if (lblN19.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN19.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }
            else if (i == 20)
            {
                if (lblN20.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Add(new table
                    {
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN20.BackColor = Color.Red;
                    MessageBox.Show("Eklendi");
                }
            }

            //else
            //{
            //    MessageBox.Show("Hatalı sayı girdiniz.");
            //}
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            int i = Convert.ToInt32(txtYer.Text);

            if (i == 1)
            {
                if (lblN1.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN1.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 2)
            {
                if (lblN2.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN2.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 3)
            {
                if (lblN3.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN3.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 4)
            {
                if (lblN4.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN4.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 5)
            {
                if (lblN5.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN5.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 6)
            {
                if (lblN6.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN6.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 7)
            {
                if (lblN7.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN7.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi");
                }
            }
            else if (i == 8)
            {
                if (lblN8.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN8.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 9)
            {
                if (lblN9.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN9.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 10)
            {
                if (lblN10.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN10.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 11)
            {
                if (lblN11.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN11.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 12)
            {
                if (lblN12.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN12.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 13)
            {
                if (lblN13.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN13.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 14)
            {
                if (lblN14.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN14.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 15)
            {
                if (lblN15.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN15.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 16)
            {
                if (lblN16.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN16.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 17)
            {
                if (lblN17.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN17.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 18)
            {
                if (lblN18.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN18.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 19)
            {
                if (lblN19.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN19.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }
            else if (i == 20)
            {
                if (lblN20.BackColor == Color.Red)
                {
                    MessageBox.Show("Park yeri dolu.");
                }
                else
                {
                    _productDal.Update(new table
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        Name = txtAdSoyad.Text,
                        Plaka = txtPlaka.Text,
                        Marka = txtMarka.Text,
                        Renk = txtRenk.Text,
                        Telefon = (char)Convert.ToDouble(txtTelefon.Text),
                        GirisTarihi = Convert.ToDateTime(dtpGirisTarihi.Value),
                        GirisSaati = Convert.ToDateTime(txtGirişSaati.Text),
                        CikisTarihi = DateTime.Now,
                        Ücret = (int)Convert.ToDouble(txtUcret.Text),
                        Yer = Convert.ToInt32(txtYer.Text)
                    });
                    lblN20.BackColor = Color.Red;
                    MessageBox.Show("Güncellendi.");
                }
            }




            LoadProducts();
            
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdSoyad.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtPlaka.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtMarka.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            txtRenk.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            txtTelefon.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();
            dtpGirisTarihi.Text = dgwProducts.CurrentRow.Cells[6].Value.ToString();
            txtGirişSaati.Text = dgwProducts.CurrentRow.Cells[7].Value.ToString();
            txtCikisTarihi.Text = dgwProducts.CurrentRow.Cells[8].Value.ToString();
            txtUcret.Text = dgwProducts.CurrentRow.Cells[9].Value.ToString();
            txtYer.Text = dgwProducts.CurrentRow.Cells[10].Value.ToString();

            //int günlükUcret = (int)Convert.ToDouble(txtUcret.Text) * 10;

            //TimeSpan fark = Convert.ToDateTime(txtÇıkışSaati.Text) - Convert.ToDateTime(txtGirişSaati.Text);
            //int fark1 = Convert.ToInt32(fark.TotalDays);
            //DateTime.Now.Day.ToString();

            //if ((fark1 * (-1)) == fark1) fark1 -= 1;

            //else fark1 += 1;

            //lblGeçenSüre.Text = "Ay : " + fark1 / 30 + "\nGün : " + fark1.ToString() + "\nSaat : " + (fark1 * 60).ToString() + "\nDakika : " + (fark1 * 60) * 60;

            DateTime trh1 = Convert.ToDateTime(dtpGirisTarihi.Text + " ");
            DateTime trh2 = Convert.ToDateTime(txtCikisTarihi.Text + " ");
            TimeSpan sonuc = trh2 - trh1; // Büyük tarihten küçük tarihi çıkardık
            lblKalınanSüre.Text = "Kalınan Süre: " + sonuc.ToString();



        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtAra.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtYer.Text);

            DialogResult cikis = new DialogResult();

            cikis = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (cikis == DialogResult.Yes)
            {
                
                LoadProducts();
                MessageBox.Show("Çıkış yapıldı.");
                //Application.Exit();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Çıkış yapılmadı.");
            }



            if (i == 1)
            {
                
                lblN1.BackColor = Color.Green;
            }
            else if (i == 2)
            {
                lblN2.BackColor = Color.Green;
            }
            if (i == 3)
            {
                lblN3.BackColor = Color.Green;
            }
            if (i == 4)
            {
                lblN4.BackColor = Color.Green;
            }
            if (i == 5)
            {
                lblN5.BackColor = Color.Green;
            }
            if (i == 6)
            {
                lblN6.BackColor = Color.Green;
            }
            if (i == 7)
            {
                lblN7.BackColor = Color.Green;
            }
            if (i == 8)
            {
                lblN8.BackColor = Color.Green;
            }
            if (i == 9)
            {
                lblN9.BackColor = Color.Green;
            }
            if (i == 10)
            {
                lblN10.BackColor = Color.Green;
            }
            if (i == 11)
            {
                lblN11.BackColor = Color.Green;
            }
            if (i == 12)
            {
                lblN12.BackColor = Color.Green;
            }
            if (i == 13)
            {
                lblN13.BackColor = Color.Green;
            }
            if (i == 14)
            {
                lblN14.BackColor = Color.Green;
            }
            if (i == 15)
            {
                lblN15.BackColor = Color.Green;
            }
            if (i == 16)
            {
                lblN16.BackColor = Color.Green;
            }
            if (i == 17)
            {
                lblN17.BackColor = Color.Green;
            }
            if (i == 18)
            {
                lblN18.BackColor = Color.Green;
            }
            if (i == 19)
            {
                lblN19.BackColor = Color.Green;
            }
            if (i == 20)
            {
                lblN20.BackColor = Color.Green;
            }
            



        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtYer.Text);

            DialogResult sil = new DialogResult();

            sil = MessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (sil == DialogResult.Yes)
            {
                _productDal.Delete(new table
                {
                    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                });
                LoadProducts();
                MessageBox.Show("Silindi."); 
                //Application.Exit();
            }
            if (sil == DialogResult.No)
            {
                MessageBox.Show("Kayıt silinmedi.");
            }

            if (i == 1)
            {

                lblN1.BackColor = Color.Green;
            }
            else if (i == 2)
            {
                lblN2.BackColor = Color.Green;
            }
            if (i == 3)
            {
                lblN3.BackColor = Color.Green;
            }
            if (i == 4)
            {
                lblN4.BackColor = Color.Green;
            }
            if (i == 5)
            {
                lblN5.BackColor = Color.Green;
            }
            if (i == 6)
            {
                lblN6.BackColor = Color.Green;
            }
            if (i == 7)
            {
                lblN7.BackColor = Color.Green;
            }
            if (i == 8)
            {
                lblN8.BackColor = Color.Green;
            }
            if (i == 9)
            {
                lblN9.BackColor = Color.Green;
            }
            if (i == 10)
            {
                lblN10.BackColor = Color.Green;
            }
            if (i == 11)
            {
                lblN11.BackColor = Color.Green;
            }
            if (i == 12)
            {
                lblN12.BackColor = Color.Green;
            }
            if (i == 13)
            {
                lblN13.BackColor = Color.Green;
            }
            if (i == 14)
            {
                lblN14.BackColor = Color.Green;
            }
            if (i == 15)
            {
                lblN15.BackColor = Color.Green;
            }
            if (i == 16)
            {
                lblN16.BackColor = Color.Green;
            }
            if (i == 17)
            {
                lblN17.BackColor = Color.Green;
            }
            if (i == 18)
            {
                lblN18.BackColor = Color.Green;
            }
            if (i == 19)
            {
                lblN19.BackColor = Color.Green;
            }
            if (i == 20)
            {
                lblN20.BackColor = Color.Green;
            }


            //_productDal.Delete(new table
            //{
            //    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            //});
            //LoadProducts();
            //MessageBox.Show("Silindi.");
        }
    }
}

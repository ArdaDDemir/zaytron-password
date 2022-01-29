using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;


namespace Zaytron_Password
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ArdaDDemir");

        }

        //Şifre değiştirme kısmı
        public void ChangePassword(string new_password)
        {
            try
            {
                new DirectoryEntry("WinNT://" + Environment.MachineName.ToString()).Children.Find(Environment.UserName).Invoke("SetPassword", (object)new_password);
                int num = (int)MessageBox.Show("Şifreniz başarıyla değiştirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Şifreniz değiştirilirken bir hata meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        //Şifre değiştirme Bitiş
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtPasswd.Text) || string.IsNullOrWhiteSpace(this.txtPasswdAgain.Text))
            {
                int num1 = (int)MessageBox.Show("Alanlar boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (this.txtPasswd.Text != this.txtPasswdAgain.Text)
            {
                int num2 = (int)MessageBox.Show("Şifreler uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (this.txtPasswd.Text.Length < 6)
            {
                int num3 = (int)MessageBox.Show("Yeni şifre 6 karakterden kısa olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
                this.ChangePassword(this.txtPasswdAgain.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Credenciales : Form
    {
        public Credenciales()
        {
            InitializeComponent();
        }

        private void Credenciales_Load(object sender, EventArgs e)
        {
            bcrear.Enabled = false;
            bcont.Enabled = false;
            created.Visible = false;
            sesion.Visible = false;
            blogin.Visible = false;
            loguser.Visible = false;
            logpass.Visible = false;
            logname.Visible = false;
            blogin.Enabled = false;
        }

        private void controlGeneral()
        {
            if (usuario.Text.Trim() != string.Empty & password.Text.Trim() != string.Empty)
            {
                bcrear.Enabled = true;
            }
            else
            {
                bcrear.Enabled = false;
            }
            if (loguser.Text.Trim() != string.Empty & logpass.Text.Trim() != string.Empty)
            {
                blogin.Enabled = true;
            }
            else
            {
                blogin.Enabled = false;
            }

        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            controlGeneral();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            controlGeneral();
        }

        private void bcrear_Click(object sender, EventArgs e)
        {

            if (usuario.Text.Length >= 14)
            {
                errorProvider1.SetError(usuario, "El nombre otorgado es demasiado largo.");
            }
            else if (usuario.Text.Any(Char.IsSymbol))
            {
                errorProvider1.SetError(usuario, "El nombre no puede contener caracteres especiales.");
            }
            else
            {
                errorProvider1.SetError(usuario, "");
                created.Visible = true;
                bcont.Enabled = true;
                bcrear.Enabled = false;

            }
            if (created.Visible == true)
            {
                usuario.Enabled = false;
                password.Enabled = false;
            }

        }

        private void bcont_Click(object sender, EventArgs e)
        {
            blogin.Visible = true;
            loguser.Visible = true;
            logpass.Visible = true;
            logname.Visible = true;
            created.Visible = false;
            bcrear.Visible = false;
            bcont.Visible = false;
            regname.Visible = false;
        }

        private void loguser_TextChanged(object sender, EventArgs e)
        {
            controlGeneral();
        }

        private void logpass_TextChanged(object sender, EventArgs e)
        {
            controlGeneral();
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            if (loguser.Text == usuario.Text && logpass.Text == password.Text)
            {
                blogin.Enabled = false;
                loguser.Enabled = false;
                logpass.Enabled = false;
                sesion.Visible = true;
                errorProvider2.SetError(blogin, "");
                System.Diagnostics.Process.Start("https://hentaila.com/");
            }
            else
            {
                errorProvider2.SetError(blogin, "Los datos son incorrectos, intentelo de nuevo.");
            }
        }
    }
}

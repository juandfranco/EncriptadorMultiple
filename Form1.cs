using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncriptadorMultiple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            tbUsuarioEncriptadoMD5.Text = HelperMD5.GetMd5Str(tbUsuario.Text);
            tbUsuarioEncriptadoSHA256.Text = HelperSHA256.GetSHA256Str(tbUsuario.Text);
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048);

            var HelperRSA = new HelperRSA(RSA);

            tbPasswordEncriptado.Text = HelperRSA.GetRSAStr(tbPassword.Text);


            string GetRSAPublicKeyXMLStr = HelperRSA.GetRSAPublicKeyXMLStr();
            string GetRSAPrivateKeyXMLStr = HelperRSA.GetRSAPrivateKeyXMLStr();

            tbLlavePublica.Text = GetRSAPublicKeyXMLStr;
            tbLlavePrivada.Text = GetRSAPrivateKeyXMLStr;

            tbPasswordDesencriptado.Text = HelperRSA.DecryptionBase64WithXMLPublicKey(tbPasswordEncriptado.Text, GetRSAPrivateKeyXMLStr, false);

            


        }

        private void tbLlavePrivada_TextChanged(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048);

            string textoDesencriptado = new HelperRSA(RSA).DecryptionBase64WithXMLPublicKey(tbPasswordEncriptado.Text, tbLlavePrivada.Text, false);

            tbPasswordDesencriptado.Text = textoDesencriptado;
        }
    }
}

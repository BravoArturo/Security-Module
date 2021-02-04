using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CONTROLADORA;
using CONTROLADORA.STATE;
using CONTROLADORA.INFORME;
using MODELO;
using VISTA;
using MessageBox = System.Windows.Forms.MessageBox;

namespace GUI
{
    /// <summary>
    /// Lógica de interacción para logIn.xaml
    /// </summary>
    public partial class logIn : Window
    {
        public logIn()
        {
            InitializeComponent();
        }

        //private void btnLOGIN_Click(object sender, RoutedEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtUSUARIO.Text))
        //    {
        //        lblINCORRECTO.IsEnabled = true;
        //        lblINCORRECTO.Content = "Ingrese un usuario.";
        //        return;
        //    }
        //    if (string.IsNullOrEmpty(txtPASS.Text))
        //    {
        //        lblINCORRECTO.IsEnabled = true;
        //        lblINCORRECTO.Content = "Ingrese una clave";
        //        return;
        //    }
        //    usuarioModel usuario = new usuarioModel();
        //    var validarLogin = usuario.loginUsuario(txtUSUARIO.Text, MODELO.crypPassword.cryp.Encrypt(txtPASS.Text, true));
        //    if (validarLogin == true)
        //    {
        //        usuarioContext oUsuarioContext = new usuarioContext();
        //        if (loginCache.estado == "ACTIVO")
        //        {
        //            oUsuarioContext.State = new usuarioActivo();
        //            oUsuarioContext.estado();
        //            pagePrincipal PagePrincipal = pagePrincipal.obtenerInstancia();
        //            PagePrincipal.Show();
        //            PagePrincipal.FormClosed += logOut;
        //            this.Hide();
        //            MessageBox.Show(oUsuarioContext.State.mensaje);
        //            informeCache.login = DateTime.Now;
        //        }
        //        else if (loginCache.estado == "INACTIVO")
        //        {
        //            oUsuarioContext.State = new usuarioInactivo();
        //            oUsuarioContext.estado();
        //            MessageBox.Show(oUsuarioContext.State.mensaje);
        //        }

        //    }
        //    if (validarLogin == false)
        //    {
        //        lblINCORRECTO.IsEnabled = true;
        //        lblINCORRECTO.Content = "Usuario o contraseña invalido.";
        //        return;
        //    }
        //}
        //private void logOut(object sender, FormClosedEventArgs e)
        //{
        //    txtUSUARIO.Clear();
        //    txtPASS.Clear();
        //    this.Show();
        //    txtUSUARIO.Focus();
        //}
    }
}

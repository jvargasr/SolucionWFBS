using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WFBS.Negocio;

namespace MasterPages.Page
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>

    public partial class Page1 : System.Windows.Controls.Page
    {

        Usuario us;

        public Page1()
        {
            InitializeComponent();
            Logger.filePath = @"c:\log.txt";
            
        }


        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            us = new Usuario();

            us.Rut = txtUser.Text;
            us.Password = (string)txtPass.Password;
            try
            {

                if (txtUser.Text.Length > 0 && txtPass.Password.Length > 0)
                {
                    string xml = us.Serializar();
                    WFBS.Presentacion.ServicioWCF.ServicioWFBSClient servicio = new WFBS.Presentacion.ServicioWCF.ServicioWFBSClient();

                    if (servicio.ValidarUsuario(xml))
                    {
                        us.Read();
                        if (servicio.Desactivado(xml))
                        {
                            Global.RutUsuario = us.Rut;
                            Global.NombreUsuario = us.Nombre;
                            Global.AreaInvestigacion = "Por definir";
                            Global.JefeUsuario = us.Jefe;
                            Logger.log("Inicio de sesi�n exitoso");
                            NavigationService navService = NavigationService.GetNavigationService(this);
                            Page2 nextPage = new Page2();
                            navService.Navigate(nextPage);
                        }
                        else
                        {
                            MessageBox.Show("La cuenta utilizada se encuentra Desactivada", "Alerta");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Rut o contrase�a inv�lidos. Aseg�rese de entrar con perfil de administrador al sistema.", "Error!");
                        Logger.log("Login fallido por datos invalidos");
                    }
                }
                else
                {
                    Logger.log("Login fallido por falta de datos");
                    MessageBox.Show("Debe ingresar su RUT y contrase�a", "Alerta");
                }
            }
            catch (Exception)
            {
                Logger.log("Error Login");
                MessageBox.Show("Surgieron inconvenientes al conectarse","Alerta");
            }

        }
    }
}
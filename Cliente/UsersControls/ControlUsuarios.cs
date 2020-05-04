using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Entities;

namespace Cliente.UsersControls
{
    public partial class ControlUsuarios : UserControl
    {
        public ControlUsuarios()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Nombre = txt_Name.Text,
                ApellidoPaterno = txt_LastName1.Text,
                ApellidoMaterno = txt_LastName2.Text,
                NombreUsuario = txt_User.Text,
                Contrasena = txt_Pass.Text,


                Activo = true
            };

            new UserDomain().insertNewUser(ref user);
            Tools.Alert("Usuario Registrado!", Form_Alert.enumType.Success);
        }
    }
}


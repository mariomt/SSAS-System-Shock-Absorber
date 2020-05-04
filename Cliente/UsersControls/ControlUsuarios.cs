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
        IEnumerable<Rol> roles;
        public ControlUsuarios()
        {
            InitializeComponent();
            loadCbRol();
        }

        private void loadCbRol()
        {
            roles = new RolDomain().getAll();
            cb_Rol.Items.Clear();
            foreach(var rol in roles)
            {
                cb_Rol.Items.Add(rol);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(cb_Rol.SelectedIndex < 0)
            {
                Tools.Alert("No se seleccionó un rol", Form_Alert.enumType.Error);
                return;
            }


            if (txt_Name.Text.Trim().Length<2 || txt_LastName1.Text.Trim().Length < 2 || txt_LastName2.Text.Trim().Length < 2 || txt_User.Text.Trim().Length < 2 || txt_Pass.Text.Trim().Length < 2)
            {
                Tools.Alert("Asegurece de llenar correctamente los campos", Form_Alert.enumType.Error);
                return;
            }


            User user = new User()
            {
                Nombre = txt_Name.Text,
                ApellidoPaterno = txt_LastName1.Text,
                ApellidoMaterno = txt_LastName2.Text,
                NombreUsuario = txt_User.Text,
                Contrasena = txt_Pass.Text,
                rol = (Rol)cb_Rol.SelectedItem,
                Activo = true
            };

            new UserDomain().insertNewUser(ref user);
            Tools.Alert("Usuario Registrado!", Form_Alert.enumType.Success);
        }
    }
}


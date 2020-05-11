﻿using System;
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
        int UsuarioSeleccionado;
        public ControlUsuarios()
        {
            InitializeComponent();
            loadCbRol();
            consultarUsuarios("-1");
        }

        private void loadCbRol()
        {
            roles = new RolDomain().getAll();
            cb_Rol.Items.Clear();

            Dictionary<int, string> rolDictionary = new Dictionary<int, string>();
            rolDictionary.Add(-1, "");
            foreach (var rol in roles)
            {
                rolDictionary.Add(rol.RolId, rol.Descripcion);
            }
            cb_Rol.DataSource = new BindingSource(rolDictionary, null);
            cb_Rol.DisplayMember = "Value";
            cb_Rol.ValueMember = "Key";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Agregar")
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
                Rol rol = new Rol()
                {
                    RolId = Int32.Parse(cb_Rol.SelectedValue.ToString()),
                    Descripcion = cb_Rol.SelectedText
                };

                User user = new User()
                {
                    Nombre = txt_Name.Text,
                    ApellidoPaterno = txt_LastName1.Text,
                    ApellidoMaterno = txt_LastName2.Text,
                    NombreUsuario = txt_User.Text,
                    Contrasena = txt_Pass.Text,
                    rol = rol,
                    Activo = true
                };

                new UserDomain().insertNewUser(ref user);
                Tools.Alert("Usuario Registrado!", Form_Alert.enumType.Success);
                
            }
            else
            {
                Rol rol = new Rol()
                {
                    RolId = Int32.Parse(cb_Rol.SelectedValue.ToString()),
                    Descripcion = cb_Rol.SelectedText
                };
                User user = new User()
                {
                    UsuarioID = UsuarioSeleccionado,
                    Nombre = txt_Name.Text,
                    ApellidoPaterno = txt_LastName1.Text,
                    ApellidoMaterno = txt_LastName2.Text,
                    NombreUsuario = txt_User.Text,
                    Contrasena = txt_Pass.Text,
                    rol = rol
                };

                new UserDomain().updateUserByID(ref user);
                Tools.Alert("Usuario Actualizado!", Form_Alert.enumType.Success);
            }
            consultarUsuarios("-1");
            cleanForm();
        }

        private void consultarUsuarios(string pUsuario)
        {
            userGv.Rows.Clear();
            UserDomain userDomain = new UserDomain();
            var usuarios = userDomain.searchUsers(ref pUsuario);
            foreach (var eachUsuario in usuarios)
            {
                DataGridViewRow celda = new DataGridViewRow();
                celda.CreateCells(userGv);
                celda.Cells[0].Value = eachUsuario.UsuarioID;
                celda.Cells[1].Value = eachUsuario.Nombre;
                celda.Cells[2].Value = eachUsuario.ApellidoPaterno;
                celda.Cells[3].Value = eachUsuario.ApellidoMaterno;
                celda.Cells[4].Value = eachUsuario.NombreUsuario;
                celda.Cells[5].Value = eachUsuario.Contrasena;
                celda.Cells[6].Value = eachUsuario.rol.Descripcion;
                celda.Cells[7].Value = eachUsuario.rol.RolId;
                userGv.Rows.Add(celda);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                consultarUsuarios(txtBuscar.Text);
            }
            else
            {
                consultarUsuarios("-1");
            }
        }

        private void userGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Visible = true;
            DataGridViewCellCollection usuarioSeleccionado = userGv.Rows[e.RowIndex].Cells;

            var id  = usuarioSeleccionado[0].Value;
            this.UsuarioSeleccionado = Int32.Parse(id.ToString());

            txt_Name.Text = usuarioSeleccionado[1].Value.ToString();
            txt_User.Text = usuarioSeleccionado[4].Value.ToString();
            txt_Pass.Text = usuarioSeleccionado[5].Value.ToString();
            txt_LastName1.Text = usuarioSeleccionado[2].Value.ToString();
            txt_LastName2.Text = usuarioSeleccionado[3].Value.ToString();
            cb_Rol.SelectedValue = 1;

            button3.Text = "Actualizar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void cleanForm()
        {
            txt_Name.Text = "";
            txt_User.Text = "";
            txt_Pass.Text = "";
            txt_LastName1.Text = "";
            txt_LastName2.Text = "";
            cb_Rol.SelectedValue = -1;

            button3.Text = "Agregar";
            button1.Visible = false;
        }
    }
}


using Domain;
using Entities;
using System;
using System.Windows.Forms;

namespace Cliente
{
    public class Cancellation : IDisposable
    {
        private string reason = "";
        private InputForm input = null;
        private EnumTypeOperation cancellationAttr;
        private BitacoraOperaciones bitacora;
        private bool saveReason = false;
        public bool isSaved { get { return saveReason; } }

        #region Constuctors
        /// <summary>
        /// The default message that will be shown to the user is "Ingresa el motivo de desactivación:".
        /// The default title is "Desactivar"
        /// </summary>
        public Cancellation(EnumTypeOperation type) : this(type, "Ingrese motivo de desactivación:")
        {

        }

        /// <summary>
        /// The default title is "Desactivar"
        /// </summary>
        /// <param name="message">Message displayed to the user</param>
        public Cancellation(EnumTypeOperation type, string message) : this(type, message, "Desactivar")
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">Message to be shown to the user</param>
        public Cancellation(EnumTypeOperation type, string message, string title)
        {
            cancellationAttr = type;
            input = new InputForm(message);
            input.Text = title;
            input.btnAceptar.Click += new EventHandler(handlerCancellationAceptar);
            input.textBox1.TextChanged += new EventHandler(handlerTypedMotivo);
            input.btnCancelar.Click += new EventHandler(handlerCancellBtn);
        }

        #endregion


        private void handlerCancellationAceptar(object sender, EventArgs e)
        {
            string message = "Está seguro de desactivar el ";
            if (cancellationAttr == EnumTypeOperation.DisableService)
                message += "Servicio?";
            else
                message += "Producto?";

            DialogResult result = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bitacora = new BitacoraOperaciones()
                {
                    UsuarioID = MainInformation.user.UsuarioID,
                    TipoID = (int)cancellationAttr,
                    Comentario = reason,
                    FechaHora = DateTime.Now
                };
                input.Hide();
            }
        }

        private void handlerCancellBtn(object sender, EventArgs e)
        {
            input.Hide();
        }
        private void handlerTypedMotivo(object sender, EventArgs e)
        {
            reason = ((TextBox)sender).Text;
        }

        public BitacoraOperaciones showDialog(UserControl form)
        {
            input.ShowDialog(form);
            return bitacora;
        }

        #region disposing
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (input != null)
                    input.Dispose();

                input = null;

            }
        }

        #endregion

    }
}

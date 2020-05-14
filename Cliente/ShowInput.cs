using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public class ShowInput : IDisposable
    {
        string text = "";
        private InputForm input = null;

        ShowInput(string message, string title = "Input")
        {
            input = new InputForm(message);
            input.Text = title;
            input.btnAceptar.Click += new EventHandler(handlerAceptar);
            input.btnCancelar.Click += new EventHandler(handlerCancelar);
            input.textBox1.TextChanged += new EventHandler(handlerTypedText);
        }
        private void handlerTypedText(object sender, EventArgs e)
        {
            text = ((TextBox)sender).Text;
        }

 
        private void handlerAceptar(object sender, EventArgs e)
        {
            input.Hide();
        }

        private void handlerCancelar(object sender, EventArgs e)
        {
            text = "cancelled";
            input.Hide();
        }

        private string getMessage(UserControl parent)
        {
            input.ShowDialog(parent);
            return text;
        }

        /// <summary>
        /// Muestra un input dialog para que el usuario ingrese datos
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <returns>Si el usuario preciona cancelar el mensaje contendrá el mensaje cancellated</returns>
        public static string ShowDialog(UserControl parent,string message, string title = "Input")
        {
            return new ShowInput(message, title).getMessage(parent);
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

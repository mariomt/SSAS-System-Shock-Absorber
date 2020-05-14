
using System.Windows.Forms;

namespace Cliente
{
    public class Tools
    {
        public static void Alert(string msg, Form_Alert.enumType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public static void AlertInToApp(string msg, Form_Alert.enumType type)
        {
            Form_Alert frm = new Form_Alert() { TopLevel = false, TopMost = true };
            MainInformation.mainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.showAlertInPanel(msg, type,MainInformation.mainPanel);
        }

    }
}

﻿
namespace Cliente
{
    public class Tools
    {
        public static void Alert(string msg, Form_Alert.enumType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

    }
}

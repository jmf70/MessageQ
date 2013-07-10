/*
 * http://msdn.microsoft.com/es-es/library/6d4270b7.aspx
 * Ejemplo cogido de http://msdn.microsoft.com/es-es/library/72td0547.aspx
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MessageQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            System.Messaging.Message theMessage = new System.Messaging.Message(txtMessage.Text);
            theMessage.Label = txtName.Text;
            if (highPriority.Checked)
                theMessage.Priority = System.Messaging.MessagePriority.Highest;
            else
                theMessage.Priority = System.Messaging.MessagePriority.Normal;
            helpRequestQueue.Send(theMessage);
            DisplayMessages();
        }

        private void DisplayMessages()
        {
            DataTable messageTable = new DataTable();

            messageTable.Columns.Add("Name");
            messageTable.Columns.Add("Message");
            messageTable.Columns.Add("Priority");
            
            System.Messaging.Message[] messages;

            messages=helpRequestQueue.GetAllMessages();

            System.Messaging.XmlMessageFormatter stringFormatter;
            stringFormatter=new System.Messaging.XmlMessageFormatter(new string[] {"System.String"});

            for(int index=0;index<messages.Length;index++)
            {
                messages[index].Formatter = stringFormatter;
                messageTable.Rows.Add(new String[]{
                    messages[index].Label,
                    messages[index].Body.ToString(),
                    messages[index].Priority.ToString()
                });
            }
            messageGrid.DataSource = messageTable;
        }

        private void refreshMessages_Click(object sender, EventArgs e)
        {
            DisplayMessages();
        }

        private void purgeMessages_Click(object sender, EventArgs e)
        {

            helpRequestQueue.Purge();
            DisplayMessages();
        }
    }
}

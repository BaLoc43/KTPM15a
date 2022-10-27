using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMQ_Sender
{
    public partial class F_MessageSender : Form
    {
        MessageQueue queue = null;

        public F_MessageSender()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            string path = @".\private$\phongkehoach";
            if (MessageQueue.Exists(path))
            {
                queue = new MessageQueue(path, QueueAccessMode.Send);
            }
            else
                queue = MessageQueue.Create(path, true);
            queue.Label = "Queue cho phong ke hoach";
        }
        private void btnSendText_Click(object sender, EventArgs e)
        {
            string message = richTextBox.Text;
            MessageQueueTransaction tran = new MessageQueueTransaction();
            tran.Begin();
            queue.Send(message, tran);
            tran.Commit();


        }

        private void btnSendObject_Click(object sender, EventArgs e)
        {
            Student st = new Student(1011L, "Nguyen Ba Loc", new DateTime(1999, 10, 14));
            MessageQueueTransaction tran = new MessageQueueTransaction();
            tran.Begin();
            queue.Send(st, tran);
            tran.Commit();

        }
    }
}

namespace MSMQ_Sender
{
    partial class F_MessageSender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnSendText = new System.Windows.Forms.Button();
            this.btnSendObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(276, 168);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // btnSendText
            // 
            this.btnSendText.Location = new System.Drawing.Point(12, 194);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(107, 38);
            this.btnSendText.TabIndex = 1;
            this.btnSendText.Text = "SendText";
            this.btnSendText.UseVisualStyleBackColor = true;
            // 
            // btnSendObject
            // 
            this.btnSendObject.Location = new System.Drawing.Point(153, 194);
            this.btnSendObject.Name = "btnSendObject";
            this.btnSendObject.Size = new System.Drawing.Size(113, 38);
            this.btnSendObject.TabIndex = 2;
            this.btnSendObject.Text = "SendObject";
            this.btnSendObject.UseVisualStyleBackColor = true;
            // 
            // F_MessageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.btnSendObject);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.richTextBox);
            this.Name = "F_MessageSender";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.Button btnSendObject;
    }
}


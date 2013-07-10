namespace MessageQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpRequestQueue = new System.Messaging.MessageQueue();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.sendMessage = new System.Windows.Forms.Button();
            this.refreshMessages = new System.Windows.Forms.Button();
            this.purgeMessages = new System.Windows.Forms.Button();
            this.highPriority = new System.Windows.Forms.CheckBox();
            this.messageGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.messageGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // helpRequestQueue
            // 
            this.helpRequestQueue.MessageReadPropertyFilter.LookupId = true;
            this.helpRequestQueue.MessageReadPropertyFilter.Priority = true;
            this.helpRequestQueue.Path = "FormatName:DIRECT=OS:pcgestpart\\private$\\helprequest";
            this.helpRequestQueue.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(415, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(98, 66);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(415, 65);
            this.txtMessage.TabIndex = 3;
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(38, 188);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(93, 23);
            this.sendMessage.TabIndex = 4;
            this.sendMessage.Text = "Enviar Mensaje";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // refreshMessages
            // 
            this.refreshMessages.Location = new System.Drawing.Point(194, 188);
            this.refreshMessages.Name = "refreshMessages";
            this.refreshMessages.Size = new System.Drawing.Size(152, 23);
            this.refreshMessages.TabIndex = 5;
            this.refreshMessages.Text = "Actualizar lista de mensajes";
            this.refreshMessages.UseVisualStyleBackColor = true;
            this.refreshMessages.Click += new System.EventHandler(this.refreshMessages_Click);
            // 
            // purgeMessages
            // 
            this.purgeMessages.Location = new System.Drawing.Point(409, 188);
            this.purgeMessages.Name = "purgeMessages";
            this.purgeMessages.Size = new System.Drawing.Size(104, 23);
            this.purgeMessages.TabIndex = 6;
            this.purgeMessages.Text = "Eliminar mensajes";
            this.purgeMessages.UseVisualStyleBackColor = true;
            this.purgeMessages.Click += new System.EventHandler(this.purgeMessages_Click);
            // 
            // highPriority
            // 
            this.highPriority.AutoSize = true;
            this.highPriority.Location = new System.Drawing.Point(38, 148);
            this.highPriority.Name = "highPriority";
            this.highPriority.Size = new System.Drawing.Size(87, 17);
            this.highPriority.TabIndex = 7;
            this.highPriority.Text = "Prioridad alta";
            this.highPriority.UseVisualStyleBackColor = true;
            // 
            // messageGrid
            // 
            this.messageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageGrid.Location = new System.Drawing.Point(38, 228);
            this.messageGrid.Name = "messageGrid";
            this.messageGrid.Size = new System.Drawing.Size(475, 199);
            this.messageGrid.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 439);
            this.Controls.Add(this.messageGrid);
            this.Controls.Add(this.highPriority);
            this.Controls.Add(this.purgeMessages);
            this.Controls.Add(this.refreshMessages);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.messageGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Messaging.MessageQueue helpRequestQueue;
        private System.Windows.Forms.DataGridView messageGrid;
        private System.Windows.Forms.CheckBox highPriority;
        private System.Windows.Forms.Button purgeMessages;
        private System.Windows.Forms.Button refreshMessages;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


namespace RabbitMq.Publisher.Example
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtQueueName = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConect = new System.Windows.Forms.Button();
            this.txtSendText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendText = new System.Windows.Forms.Button();
            this.txtReceveidText = new System.Windows.Forms.TextBox();
            this.txtReturnQueueName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da fila:";
            // 
            // txtQueueName
            // 
            this.txtQueueName.Location = new System.Drawing.Point(15, 69);
            this.txtQueueName.Name = "txtQueueName";
            this.txtQueueName.Size = new System.Drawing.Size(482, 20);
            this.txtQueueName.TabIndex = 1;
            this.txtQueueName.Text = "queue";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(15, 25);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(482, 20);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servidor do RabbitMQ:";
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(422, 138);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(75, 23);
            this.btnConect.TabIndex = 3;
            this.btnConect.Text = "Conectar";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // txtSendText
            // 
            this.txtSendText.Location = new System.Drawing.Point(15, 166);
            this.txtSendText.Name = "txtSendText";
            this.txtSendText.Size = new System.Drawing.Size(482, 20);
            this.txtSendText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Texto à enviar:";
            // 
            // btnSendText
            // 
            this.btnSendText.Location = new System.Drawing.Point(422, 192);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(75, 23);
            this.btnSendText.TabIndex = 5;
            this.btnSendText.Text = "Enviar";
            this.btnSendText.UseVisualStyleBackColor = true;
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // txtReceveidText
            // 
            this.txtReceveidText.Location = new System.Drawing.Point(12, 221);
            this.txtReceveidText.Multiline = true;
            this.txtReceveidText.Name = "txtReceveidText";
            this.txtReceveidText.ReadOnly = true;
            this.txtReceveidText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceveidText.Size = new System.Drawing.Size(485, 241);
            this.txtReceveidText.TabIndex = 9;
            // 
            // txtReturnQueueName
            // 
            this.txtReturnQueueName.Location = new System.Drawing.Point(15, 112);
            this.txtReturnQueueName.Name = "txtReturnQueueName";
            this.txtReturnQueueName.Size = new System.Drawing.Size(482, 20);
            this.txtReturnQueueName.TabIndex = 24;
            this.txtReturnQueueName.Text = "rpc_queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nome da fila de retorno:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 474);
            this.Controls.Add(this.txtReturnQueueName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReceveidText);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSendText);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQueueName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RabbitMQ Example Publisher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQueueName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.TextBox txtSendText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.TextBox txtReceveidText;
        private System.Windows.Forms.TextBox txtReturnQueueName;
        private System.Windows.Forms.Label label4;
    }
}


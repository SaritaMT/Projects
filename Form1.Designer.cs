namespace ClientApplication
{
    partial class Form1
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSendServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDeliveryOption = new System.Windows.Forms.ComboBox();
            this.labelDestinationClientName = new System.Windows.Forms.Label();
            this.textBoxDestinationClientName = new System.Windows.Forms.TextBox();
            this.labelServerData = new System.Windows.Forms.Label();
            this.textBoxDataFromServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(381, 66);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(138, 23);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Register to Server";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Register Name";
            // 
            // textBoxRegister
            // 
            this.textBoxRegister.Location = new System.Drawing.Point(205, 63);
            this.textBoxRegister.Name = "textBoxRegister";
            this.textBoxRegister.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegister.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the Message";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(205, 160);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(119, 20);
            this.textBoxMessage.TabIndex = 4;
            // 
            // buttonSendServer
            // 
            this.buttonSendServer.Location = new System.Drawing.Point(381, 206);
            this.buttonSendServer.Name = "buttonSendServer";
            this.buttonSendServer.Size = new System.Drawing.Size(138, 23);
            this.buttonSendServer.TabIndex = 5;
            this.buttonSendServer.Text = "Send To Server";
            this.buttonSendServer.UseVisualStyleBackColor = true;
            this.buttonSendServer.Click += new System.EventHandler(this.buttonSendServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Delivery Option";
            // 
            // comboBoxDeliveryOption
            // 
            this.comboBoxDeliveryOption.FormattingEnabled = true;
            this.comboBoxDeliveryOption.Items.AddRange(new object[] {
            "option1",
            "option2"});
            this.comboBoxDeliveryOption.Location = new System.Drawing.Point(205, 208);
            this.comboBoxDeliveryOption.Name = "comboBoxDeliveryOption";
            this.comboBoxDeliveryOption.Size = new System.Drawing.Size(119, 21);
            this.comboBoxDeliveryOption.TabIndex = 7;
            this.comboBoxDeliveryOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeliveryOption_SelectedIndexChanged);
            // 
            // labelDestinationClientName
            // 
            this.labelDestinationClientName.AutoSize = true;
            this.labelDestinationClientName.Enabled = false;
            this.labelDestinationClientName.Location = new System.Drawing.Point(27, 269);
            this.labelDestinationClientName.Name = "labelDestinationClientName";
            this.labelDestinationClientName.Size = new System.Drawing.Size(109, 13);
            this.labelDestinationClientName.TabIndex = 8;
            this.labelDestinationClientName.Text = "Enter the client Name";
            // 
            // textBoxDestinationClientName
            // 
            this.textBoxDestinationClientName.Enabled = false;
            this.textBoxDestinationClientName.Location = new System.Drawing.Point(205, 266);
            this.textBoxDestinationClientName.Name = "textBoxDestinationClientName";
            this.textBoxDestinationClientName.Size = new System.Drawing.Size(119, 20);
            this.textBoxDestinationClientName.TabIndex = 9;
            // 
            // labelServerData
            // 
            this.labelServerData.AutoSize = true;
            this.labelServerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerData.Location = new System.Drawing.Point(202, 9);
            this.labelServerData.Name = "labelServerData";
            this.labelServerData.Size = new System.Drawing.Size(106, 15);
            this.labelServerData.TabIndex = 10;
            this.labelServerData.Text = "Connection Status";
            // 
            // textBoxDataFromServer
            // 
            this.textBoxDataFromServer.Location = new System.Drawing.Point(205, 367);
            this.textBoxDataFromServer.Name = "textBoxDataFromServer";
            this.textBoxDataFromServer.Size = new System.Drawing.Size(119, 20);
            this.textBoxDataFromServer.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter the data to send to server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data received from Server";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(381, 9);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(144, 23);
            this.buttonDisconnect.TabIndex = 17;
            this.buttonDisconnect.Text = "Disconnect and Close";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDataFromServer);
            this.Controls.Add(this.labelServerData);
            this.Controls.Add(this.textBoxDestinationClientName);
            this.Controls.Add(this.labelDestinationClientName);
            this.Controls.Add(this.comboBoxDeliveryOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSendServer);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegister);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSendServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDeliveryOption;
        private System.Windows.Forms.Label labelDestinationClientName;
        private System.Windows.Forms.TextBox textBoxDestinationClientName;
        private System.Windows.Forms.Label labelServerData;
        private System.Windows.Forms.TextBox textBoxDataFromServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}


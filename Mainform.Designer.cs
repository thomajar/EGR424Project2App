namespace EGR424Project2App
{
    partial class Mainform
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
            this.cmboComPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.btnRefreshComPorts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCharToSend = new System.Windows.Forms.TextBox();
            this.btnSendChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmboComPorts
            // 
            this.cmboComPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboComPorts.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboComPorts.FormattingEnabled = true;
            this.cmboComPorts.Location = new System.Drawing.Point(122, 19);
            this.cmboComPorts.Name = "cmboComPorts";
            this.cmboComPorts.Size = new System.Drawing.Size(121, 27);
            this.cmboComPorts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serial Port: ";
            // 
            // btnComOpen
            // 
            this.btnComOpen.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComOpen.Location = new System.Drawing.Point(249, 16);
            this.btnComOpen.Name = "btnComOpen";
            this.btnComOpen.Size = new System.Drawing.Size(79, 32);
            this.btnComOpen.TabIndex = 2;
            this.btnComOpen.Text = "Open";
            this.btnComOpen.UseVisualStyleBackColor = true;
            this.btnComOpen.Click += new System.EventHandler(this.btnComOpen_Click);
            // 
            // btnRefreshComPorts
            // 
            this.btnRefreshComPorts.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshComPorts.Location = new System.Drawing.Point(334, 16);
            this.btnRefreshComPorts.Name = "btnRefreshComPorts";
            this.btnRefreshComPorts.Size = new System.Drawing.Size(79, 32);
            this.btnRefreshComPorts.TabIndex = 3;
            this.btnRefreshComPorts.Text = "Refresh";
            this.btnRefreshComPorts.UseVisualStyleBackColor = true;
            this.btnRefreshComPorts.Click += new System.EventHandler(this.btnRefreshComPorts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Char to Send:";
            // 
            // txtCharToSend
            // 
            this.txtCharToSend.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharToSend.Location = new System.Drawing.Point(143, 72);
            this.txtCharToSend.Name = "txtCharToSend";
            this.txtCharToSend.Size = new System.Drawing.Size(100, 28);
            this.txtCharToSend.TabIndex = 5;
            // 
            // btnSendChar
            // 
            this.btnSendChar.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendChar.Location = new System.Drawing.Point(253, 70);
            this.btnSendChar.Name = "btnSendChar";
            this.btnSendChar.Size = new System.Drawing.Size(79, 32);
            this.btnSendChar.TabIndex = 6;
            this.btnSendChar.Text = "Send";
            this.btnSendChar.UseVisualStyleBackColor = true;
            this.btnSendChar.Click += new System.EventHandler(this.btnSendChar_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 525);
            this.Controls.Add(this.btnSendChar);
            this.Controls.Add(this.txtCharToSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefreshComPorts);
            this.Controls.Add(this.btnComOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboComPorts);
            this.Name = "Mainform";
            this.Text = "Project 2 Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboComPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.Button btnRefreshComPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCharToSend;
        private System.Windows.Forms.Button btnSendChar;
    }
}


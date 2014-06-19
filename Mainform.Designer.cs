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
            this.btnSendDemoImage = new System.Windows.Forms.Button();
            this.txtDemoImageWidth = new System.Windows.Forms.TextBox();
            this.txtDemoImageValue = new System.Windows.Forms.TextBox();
            this.txtDemoImageHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImageBrowseAndSend = new System.Windows.Forms.Button();
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
            // btnSendDemoImage
            // 
            this.btnSendDemoImage.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendDemoImage.Location = new System.Drawing.Point(16, 128);
            this.btnSendDemoImage.Name = "btnSendDemoImage";
            this.btnSendDemoImage.Size = new System.Drawing.Size(183, 32);
            this.btnSendDemoImage.TabIndex = 7;
            this.btnSendDemoImage.Text = "Send Demo Image";
            this.btnSendDemoImage.UseVisualStyleBackColor = true;
            this.btnSendDemoImage.Click += new System.EventHandler(this.btnSendDemoImage_Click);
            // 
            // txtDemoImageWidth
            // 
            this.txtDemoImageWidth.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemoImageWidth.Location = new System.Drawing.Point(122, 220);
            this.txtDemoImageWidth.Name = "txtDemoImageWidth";
            this.txtDemoImageWidth.Size = new System.Drawing.Size(100, 28);
            this.txtDemoImageWidth.TabIndex = 8;
            // 
            // txtDemoImageValue
            // 
            this.txtDemoImageValue.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemoImageValue.Location = new System.Drawing.Point(122, 177);
            this.txtDemoImageValue.Name = "txtDemoImageValue";
            this.txtDemoImageValue.Size = new System.Drawing.Size(100, 28);
            this.txtDemoImageValue.TabIndex = 9;
            // 
            // txtDemoImageHeight
            // 
            this.txtDemoImageHeight.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemoImageHeight.Location = new System.Drawing.Point(122, 254);
            this.txtDemoImageHeight.Name = "txtDemoImageHeight";
            this.txtDemoImageHeight.Size = new System.Drawing.Size(100, 28);
            this.txtDemoImageHeight.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Y";
            // 
            // btnImageBrowseAndSend
            // 
            this.btnImageBrowseAndSend.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageBrowseAndSend.Location = new System.Drawing.Point(16, 320);
            this.btnImageBrowseAndSend.Name = "btnImageBrowseAndSend";
            this.btnImageBrowseAndSend.Size = new System.Drawing.Size(227, 32);
            this.btnImageBrowseAndSend.TabIndex = 14;
            this.btnImageBrowseAndSend.Text = "Browse and Send Image";
            this.btnImageBrowseAndSend.UseVisualStyleBackColor = true;
            this.btnImageBrowseAndSend.Click += new System.EventHandler(this.btnImageBrowseAndSend_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 525);
            this.Controls.Add(this.btnImageBrowseAndSend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDemoImageHeight);
            this.Controls.Add(this.txtDemoImageValue);
            this.Controls.Add(this.txtDemoImageWidth);
            this.Controls.Add(this.btnSendDemoImage);
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
        private System.Windows.Forms.Button btnSendDemoImage;
        private System.Windows.Forms.TextBox txtDemoImageWidth;
        private System.Windows.Forms.TextBox txtDemoImageValue;
        private System.Windows.Forms.TextBox txtDemoImageHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImageBrowseAndSend;
    }
}


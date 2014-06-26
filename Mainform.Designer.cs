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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.cmboComPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.btnRefreshComPorts = new System.Windows.Forms.Button();
            this.btnStartVideoStream = new System.Windows.Forms.Button();
            this.btnStopVideoStream = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseVideoLocation = new System.Windows.Forms.Button();
            this.txtVideoLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.btnRefreshComPorts.Size = new System.Drawing.Size(113, 32);
            this.btnRefreshComPorts.TabIndex = 3;
            this.btnRefreshComPorts.Text = "Refresh";
            this.btnRefreshComPorts.UseVisualStyleBackColor = true;
            this.btnRefreshComPorts.Click += new System.EventHandler(this.btnRefreshComPorts_Click);
            // 
            // btnStartVideoStream
            // 
            this.btnStartVideoStream.Image = ((System.Drawing.Image)(resources.GetObject("btnStartVideoStream.Image")));
            this.btnStartVideoStream.Location = new System.Drawing.Point(46, 128);
            this.btnStartVideoStream.Name = "btnStartVideoStream";
            this.btnStartVideoStream.Size = new System.Drawing.Size(90, 90);
            this.btnStartVideoStream.TabIndex = 15;
            this.btnStartVideoStream.UseVisualStyleBackColor = true;
            this.btnStartVideoStream.Click += new System.EventHandler(this.btnStartVideoStream_Click);
            // 
            // btnStopVideoStream
            // 
            this.btnStopVideoStream.Enabled = false;
            this.btnStopVideoStream.Image = ((System.Drawing.Image)(resources.GetObject("btnStopVideoStream.Image")));
            this.btnStopVideoStream.Location = new System.Drawing.Point(177, 128);
            this.btnStopVideoStream.Name = "btnStopVideoStream";
            this.btnStopVideoStream.Size = new System.Drawing.Size(90, 90);
            this.btnStopVideoStream.TabIndex = 16;
            this.btnStopVideoStream.UseVisualStyleBackColor = true;
            this.btnStopVideoStream.Click += new System.EventHandler(this.btnStopVideoStream_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseVideoLocation);
            this.groupBox1.Controls.Add(this.txtVideoLocation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnStartVideoStream);
            this.groupBox1.Controls.Add(this.btnStopVideoStream);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 234);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Stream Controls";
            // 
            // btnBrowseVideoLocation
            // 
            this.btnBrowseVideoLocation.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseVideoLocation.Location = new System.Drawing.Point(25, 41);
            this.btnBrowseVideoLocation.Name = "btnBrowseVideoLocation";
            this.btnBrowseVideoLocation.Size = new System.Drawing.Size(261, 32);
            this.btnBrowseVideoLocation.TabIndex = 19;
            this.btnBrowseVideoLocation.Text = "Browse Video Location";
            this.btnBrowseVideoLocation.UseVisualStyleBackColor = true;
            this.btnBrowseVideoLocation.Click += new System.EventHandler(this.btnBrowseVideoLocation_Click);
            // 
            // txtVideoLocation
            // 
            this.txtVideoLocation.Font = new System.Drawing.Font("Lucida Sans", 10.2F);
            this.txtVideoLocation.Location = new System.Drawing.Point(161, 91);
            this.txtVideoLocation.Name = "txtVideoLocation";
            this.txtVideoLocation.Size = new System.Drawing.Size(125, 28);
            this.txtVideoLocation.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Video Location";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefreshComPorts);
            this.Controls.Add(this.btnComOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboComPorts);
            this.Name = "Mainform";
            this.Text = "Project 2 Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboComPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.Button btnRefreshComPorts;
        private System.Windows.Forms.Button btnStartVideoStream;
        private System.Windows.Forms.Button btnStopVideoStream;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseVideoLocation;
        private System.Windows.Forms.TextBox txtVideoLocation;
        private System.Windows.Forms.Label label6;
    }
}


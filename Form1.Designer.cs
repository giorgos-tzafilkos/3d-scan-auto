
namespace thesis_2nd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_stepper = new System.Windows.Forms.GroupBox();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.textBoxZaxis = new System.Windows.Forms.TextBox();
            this.textBoxXaxis = new System.Windows.Forms.TextBox();
            this.textBoxYaxis = new System.Windows.Forms.TextBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.label_home = new System.Windows.Forms.Label();
            this.groupBox_Homming = new System.Windows.Forms.GroupBox();
            this.groupBox_COM = new System.Windows.Forms.GroupBox();
            this.button_COM = new System.Windows.Forms.Button();
            this.comboBox_com = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_stepper.SuspendLayout();
            this.groupBox_Homming.SuspendLayout();
            this.groupBox_COM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_stepper
            // 
            this.groupBox_stepper.Controls.Add(this.buttonTable);
            this.groupBox_stepper.Controls.Add(this.buttonZ);
            this.groupBox_stepper.Controls.Add(this.buttonY);
            this.groupBox_stepper.Controls.Add(this.buttonX);
            this.groupBox_stepper.Controls.Add(this.label4);
            this.groupBox_stepper.Controls.Add(this.label3);
            this.groupBox_stepper.Controls.Add(this.label2);
            this.groupBox_stepper.Controls.Add(this.label1);
            this.groupBox_stepper.Controls.Add(this.textBoxTable);
            this.groupBox_stepper.Controls.Add(this.textBoxZaxis);
            this.groupBox_stepper.Controls.Add(this.textBoxXaxis);
            this.groupBox_stepper.Controls.Add(this.textBoxYaxis);
            this.groupBox_stepper.Location = new System.Drawing.Point(12, 12);
            this.groupBox_stepper.Name = "groupBox_stepper";
            this.groupBox_stepper.Size = new System.Drawing.Size(427, 319);
            this.groupBox_stepper.TabIndex = 0;
            this.groupBox_stepper.TabStop = false;
            this.groupBox_stepper.Text = "Stepper Control";
            this.groupBox_stepper.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonTable
            // 
            this.buttonTable.Location = new System.Drawing.Point(259, 205);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(102, 23);
            this.buttonTable.TabIndex = 11;
            this.buttonTable.Text = "set Table";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(259, 151);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(102, 23);
            this.buttonZ.TabIndex = 10;
            this.buttonZ.Text = "Set Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.buttonZ_Click);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(259, 102);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(102, 23);
            this.buttonY.TabIndex = 9;
            this.buttonY.Text = "Set Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(259, 53);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(102, 23);
            this.buttonX.TabIndex = 8;
            this.buttonX.Text = "Set X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Table °";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = " Z axis °";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y axis mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X axis mm";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(112, 202);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(100, 20);
            this.textBoxTable.TabIndex = 3;
            this.textBoxTable.Text = "120";
            // 
            // textBoxZaxis
            // 
            this.textBoxZaxis.Location = new System.Drawing.Point(112, 153);
            this.textBoxZaxis.Name = "textBoxZaxis";
            this.textBoxZaxis.Size = new System.Drawing.Size(100, 20);
            this.textBoxZaxis.TabIndex = 2;
            this.textBoxZaxis.Text = "30";
            // 
            // textBoxXaxis
            // 
            this.textBoxXaxis.Location = new System.Drawing.Point(112, 55);
            this.textBoxXaxis.Name = "textBoxXaxis";
            this.textBoxXaxis.Size = new System.Drawing.Size(100, 20);
            this.textBoxXaxis.TabIndex = 1;
            this.textBoxXaxis.Text = "345\r\n";
            this.textBoxXaxis.TextChanged += new System.EventHandler(this.textBoxXaxis_TextChanged);
            // 
            // textBoxYaxis
            // 
            this.textBoxYaxis.Location = new System.Drawing.Point(112, 104);
            this.textBoxYaxis.Name = "textBoxYaxis";
            this.textBoxYaxis.Size = new System.Drawing.Size(100, 20);
            this.textBoxYaxis.TabIndex = 0;
            this.textBoxYaxis.Text = "452";
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(259, 36);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(142, 58);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.Location = new System.Drawing.Point(12, 51);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(206, 29);
            this.label_home.TabIndex = 2;
            this.label_home.Text = "Homing Scanner";
            // 
            // groupBox_Homming
            // 
            this.groupBox_Homming.Controls.Add(this.buttonHome);
            this.groupBox_Homming.Controls.Add(this.label_home);
            this.groupBox_Homming.Location = new System.Drawing.Point(12, 350);
            this.groupBox_Homming.Name = "groupBox_Homming";
            this.groupBox_Homming.Size = new System.Drawing.Size(427, 129);
            this.groupBox_Homming.TabIndex = 3;
            this.groupBox_Homming.TabStop = false;
            this.groupBox_Homming.Text = "Homming";
            // 
            // groupBox_COM
            // 
            this.groupBox_COM.Controls.Add(this.button_COM);
            this.groupBox_COM.Controls.Add(this.comboBox_com);
            this.groupBox_COM.Location = new System.Drawing.Point(448, 350);
            this.groupBox_COM.Name = "groupBox_COM";
            this.groupBox_COM.Size = new System.Drawing.Size(340, 129);
            this.groupBox_COM.TabIndex = 4;
            this.groupBox_COM.TabStop = false;
            this.groupBox_COM.Text = "COM port";
            // 
            // button_COM
            // 
            this.button_COM.Location = new System.Drawing.Point(248, 54);
            this.button_COM.Name = "button_COM";
            this.button_COM.Size = new System.Drawing.Size(92, 23);
            this.button_COM.TabIndex = 1;
            this.button_COM.Text = "Open";
            this.button_COM.UseVisualStyleBackColor = true;
            this.button_COM.Click += new System.EventHandler(this.button_COM_Click);
            // 
            // comboBox_com
            // 
            this.comboBox_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_com.FormattingEnabled = true;
            this.comboBox_com.Location = new System.Drawing.Point(15, 55);
            this.comboBox_com.Name = "comboBox_com";
            this.comboBox_com.Size = new System.Drawing.Size(227, 21);
            this.comboBox_com.TabIndex = 0;
            this.comboBox_com.DropDown += new System.EventHandler(this.comboBox_dropdown_DropDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(696, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 130);
            this.label5.TabIndex = 6;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_COM);
            this.Controls.Add(this.groupBox_Homming);
            this.Controls.Add(this.groupBox_stepper);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stepper Control- 3D Scanning";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.f);
            this.groupBox_stepper.ResumeLayout(false);
            this.groupBox_stepper.PerformLayout();
            this.groupBox_Homming.ResumeLayout(false);
            this.groupBox_Homming.PerformLayout();
            this.groupBox_COM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_stepper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.TextBox textBoxZaxis;
        private System.Windows.Forms.TextBox textBoxXaxis;
        private System.Windows.Forms.TextBox textBoxYaxis;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.GroupBox groupBox_Homming;
        private System.Windows.Forms.GroupBox groupBox_COM;
        private System.Windows.Forms.Button button_COM;
        private System.Windows.Forms.ComboBox comboBox_com;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}


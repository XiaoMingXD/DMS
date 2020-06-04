namespace DMS
{
    partial class NewDb
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dbIP = new System.Windows.Forms.TextBox();
            this.dbName = new System.Windows.Forms.TextBox();
            this.dbUsr = new System.Windows.Forms.TextBox();
            this.dbPwd = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.dbPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dbPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据库名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据库用户名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "数据库密码";
            // 
            // dbIP
            // 
            this.dbIP.Location = new System.Drawing.Point(190, 44);
            this.dbIP.Margin = new System.Windows.Forms.Padding(6);
            this.dbIP.Name = "dbIP";
            this.dbIP.Size = new System.Drawing.Size(242, 35);
            this.dbIP.TabIndex = 1;
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(190, 200);
            this.dbName.Margin = new System.Windows.Forms.Padding(6);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(242, 35);
            this.dbName.TabIndex = 3;
            // 
            // dbUsr
            // 
            this.dbUsr.Location = new System.Drawing.Point(190, 278);
            this.dbUsr.Margin = new System.Windows.Forms.Padding(6);
            this.dbUsr.Name = "dbUsr";
            this.dbUsr.Size = new System.Drawing.Size(242, 35);
            this.dbUsr.TabIndex = 4;
            // 
            // dbPwd
            // 
            this.dbPwd.Location = new System.Drawing.Point(190, 356);
            this.dbPwd.Margin = new System.Windows.Forms.Padding(6);
            this.dbPwd.Name = "dbPwd";
            this.dbPwd.Size = new System.Drawing.Size(242, 35);
            this.dbPwd.TabIndex = 5;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(52, 438);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(150, 46);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "确定";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(254, 438);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 46);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // dbPort
            // 
            this.dbPort.Location = new System.Drawing.Point(190, 126);
            this.dbPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.dbPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dbPort.Name = "dbPort";
            this.dbPort.Size = new System.Drawing.Size(242, 35);
            this.dbPort.TabIndex = 2;
            this.dbPort.Value = new decimal(new int[] {
            1433,
            0,
            0,
            0});
            // 
            // NewDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 506);
            this.Controls.Add(this.dbPort);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.dbPwd);
            this.Controls.Add(this.dbUsr);
            this.Controls.Add(this.dbName);
            this.Controls.Add(this.dbIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewDb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请输入数据库信息";
            ((System.ComponentModel.ISupportInitialize)(this.dbPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dbIP;
        private System.Windows.Forms.TextBox dbName;
        private System.Windows.Forms.TextBox dbUsr;
        private System.Windows.Forms.TextBox dbPwd;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.NumericUpDown dbPort;
    }
}
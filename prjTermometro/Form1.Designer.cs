namespace prjTermometro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbFrom = new System.Windows.Forms.GroupBox();
            this.rbFromK = new System.Windows.Forms.RadioButton();
            this.rbFromF = new System.Windows.Forms.RadioButton();
            this.rbFromC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTo = new System.Windows.Forms.GroupBox();
            this.rbToK = new System.Windows.Forms.RadioButton();
            this.rbToF = new System.Windows.Forms.RadioButton();
            this.rbToC = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lbResposta = new System.Windows.Forms.Label();
            this.gbFrom.SuspendLayout();
            this.gbTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFrom
            // 
            this.gbFrom.Controls.Add(this.label1);
            this.gbFrom.Controls.Add(this.rbFromK);
            this.gbFrom.Controls.Add(this.rbFromF);
            this.gbFrom.Controls.Add(this.rbFromC);
            this.gbFrom.Location = new System.Drawing.Point(14, 12);
            this.gbFrom.Name = "gbFrom";
            this.gbFrom.Size = new System.Drawing.Size(200, 193);
            this.gbFrom.TabIndex = 0;
            this.gbFrom.TabStop = false;
           
            // 
            // rbFromK
            // 
            this.rbFromK.AutoSize = true;
            this.rbFromK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbFromK.Location = new System.Drawing.Point(7, 100);
            this.rbFromK.Name = "rbFromK";
            this.rbFromK.Size = new System.Drawing.Size(81, 28);
            this.rbFromK.TabIndex = 0;
            this.rbFromK.Text = "Kelvin";
            this.rbFromK.UseVisualStyleBackColor = true;
            // 
            // rbFromF
            // 
            this.rbFromF.AutoSize = true;
            this.rbFromF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbFromF.Location = new System.Drawing.Point(6, 66);
            this.rbFromF.Name = "rbFromF";
            this.rbFromF.Size = new System.Drawing.Size(122, 28);
            this.rbFromF.TabIndex = 0;
            this.rbFromF.Text = "Fahrenheit";
            this.rbFromF.UseVisualStyleBackColor = true;
            // 
            // rbFromC
            // 
            this.rbFromC.AutoSize = true;
            this.rbFromC.Checked = true;
            this.rbFromC.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbFromC.Location = new System.Drawing.Point(7, 32);
            this.rbFromC.Name = "rbFromC";
            this.rbFromC.Size = new System.Drawing.Size(88, 28);
            this.rbFromC.TabIndex = 0;
            this.rbFromC.TabStop = true;
            this.rbFromC.Text = "Celsius";
            this.rbFromC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // gbTo
            // 
            this.gbTo.Controls.Add(this.label2);
            this.gbTo.Controls.Add(this.rbToK);
            this.gbTo.Controls.Add(this.rbToF);
            this.gbTo.Controls.Add(this.rbToC);
            this.gbTo.Location = new System.Drawing.Point(14, 235);
            this.gbTo.Name = "gbTo";
            this.gbTo.Size = new System.Drawing.Size(200, 193);
            this.gbTo.TabIndex = 0;
            this.gbTo.TabStop = false;
           
            // 
            // rbToK
            // 
            this.rbToK.AutoSize = true;
            this.rbToK.Checked = true;
            this.rbToK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbToK.Location = new System.Drawing.Point(7, 100);
            this.rbToK.Name = "rbToK";
            this.rbToK.Size = new System.Drawing.Size(81, 28);
            this.rbToK.TabIndex = 0;
            this.rbToK.TabStop = true;
            this.rbToK.Text = "Kelvin";
            this.rbToK.UseVisualStyleBackColor = true;
            // 
            // rbToF
            // 
            this.rbToF.AutoSize = true;
            this.rbToF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbToF.Location = new System.Drawing.Point(6, 66);
            this.rbToF.Name = "rbToF";
            this.rbToF.Size = new System.Drawing.Size(122, 28);
            this.rbToF.TabIndex = 0;
            this.rbToF.Text = "Fahrenheit";
            this.rbToF.UseVisualStyleBackColor = true;
            // 
            // rbToC
            // 
            this.rbToC.AutoSize = true;
            this.rbToC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbToC.Location = new System.Drawing.Point(7, 32);
            this.rbToC.Name = "rbToC";
            this.rbToC.Size = new System.Drawing.Size(88, 28);
            this.rbToC.TabIndex = 0;
            this.rbToC.Text = "Celsius";
            this.rbToC.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(268, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "DIGITE A TEMPERATURA";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(272, 44);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(214, 32);
            this.txtTemperatura.TabIndex = 2;
            this.txtTemperatura.Text = "0";
            this.txtTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.White;
            this.btnConverter.ForeColor = System.Drawing.Color.Black;
            this.btnConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnConverter.Image")));
            this.btnConverter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConverter.Location = new System.Drawing.Point(272, 97);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(214, 97);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "CONVERTER";
            this.btnConverter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbResposta.Location = new System.Drawing.Point(268, 301);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(242, 129);
            this.lbResposta.TabIndex = 4;
            this.lbResposta.Text = "RESULTADO";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(535, 431);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbTo);
            this.Controls.Add(this.gbFrom);
            this.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TERMOMETRO";
           
            this.gbFrom.ResumeLayout(false);
            this.gbFrom.PerformLayout();
            this.gbTo.ResumeLayout(false);
            this.gbTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFrom;
        private System.Windows.Forms.RadioButton rbFromK;
        private System.Windows.Forms.RadioButton rbFromF;
        private System.Windows.Forms.RadioButton rbFromC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTo;
        private System.Windows.Forms.RadioButton rbToK;
        private System.Windows.Forms.RadioButton rbToF;
        private System.Windows.Forms.RadioButton rbToC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lbResposta;

    }
}


namespace TP6_LocalDeSushi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.simularBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptoLB = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pecTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmNUD = new System.Windows.Forms.NumericUpDown();
            this.tfNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de motos:";
            // 
            // simularBtn
            // 
            this.simularBtn.Location = new System.Drawing.Point(338, 40);
            this.simularBtn.Name = "simularBtn";
            this.simularBtn.Size = new System.Drawing.Size(75, 23);
            this.simularBtn.TabIndex = 2;
            this.simularBtn.Text = "Simular >>";
            this.simularBtn.UseVisualStyleBackColor = true;
            this.simularBtn.Click += new System.EventHandler(this.simularBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "tiempo final:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptoLB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pecTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.paTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 267);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados:";
            // 
            // ptoLB
            // 
            this.ptoLB.FormattingEnabled = true;
            this.ptoLB.Location = new System.Drawing.Point(93, 117);
            this.ptoLB.Name = "ptoLB";
            this.ptoLB.Size = new System.Drawing.Size(230, 95);
            this.ptoLB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PTO(i):";
            // 
            // pecTB
            // 
            this.pecTB.Location = new System.Drawing.Point(155, 73);
            this.pecTB.Name = "pecTB";
            this.pecTB.Size = new System.Drawing.Size(100, 20);
            this.pecTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PEC:";
            // 
            // paTB
            // 
            this.paTB.Location = new System.Drawing.Point(26, 73);
            this.paTB.Name = "paTB";
            this.paTB.Size = new System.Drawing.Size(100, 20);
            this.paTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PA:";
            // 
            // cmNUD
            // 
            this.cmNUD.Location = new System.Drawing.Point(54, 43);
            this.cmNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cmNUD.Name = "cmNUD";
            this.cmNUD.Size = new System.Drawing.Size(120, 20);
            this.cmNUD.TabIndex = 6;
            // 
            // tfNUD
            // 
            this.tfNUD.Location = new System.Drawing.Point(190, 43);
            this.tfNUD.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.tfNUD.Name = "tfNUD";
            this.tfNUD.Size = new System.Drawing.Size(120, 20);
            this.tfNUD.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 366);
            this.Controls.Add(this.tfNUD);
            this.Controls.Add(this.cmNUD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simularBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery de sushi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button simularBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pecTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ptoLB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown cmNUD;
        private System.Windows.Forms.NumericUpDown tfNUD;
    }
}


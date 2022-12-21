namespace _2parcial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cafe = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LbPedidos = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.cafe);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 698);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 10);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amy\'s coffee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(218, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Extras";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.LbPedidos);
            this.PanelPrincipal.Controls.Add(this.label4);
            this.PanelPrincipal.Controls.Add(this.button8);
            this.PanelPrincipal.Controls.Add(this.button7);
            this.PanelPrincipal.Controls.Add(this.button6);
            this.PanelPrincipal.Controls.Add(this.panel2);
            this.PanelPrincipal.Controls.Add(this.panel3);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(361, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(898, 698);
            this.PanelPrincipal.TabIndex = 3;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(583, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 698);
            this.panel3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 300);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 124);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 106);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cafe
            // 
            this.cafe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafe.Image = ((System.Drawing.Image)(resources.GetObject("cafe.Image")));
            this.cafe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cafe.Location = new System.Drawing.Point(36, 197);
            this.cafe.Name = "cafe";
            this.cafe.Size = new System.Drawing.Size(268, 77);
            this.cafe.TabIndex = 1;
            this.cafe.Text = "CAFE  EXPRESO";
            this.cafe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cafe.UseVisualStyleBackColor = false;
            this.cafe.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(36, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 77);
            this.button4.TabIndex = 2;
            this.button4.Text = "CAFE SOLO";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(36, 460);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 77);
            this.button5.TabIndex = 3;
            this.button5.Text = "DESCAFEINADO";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(6, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 92);
            this.button6.TabIndex = 7;
            this.button6.Text = "Canela";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Info;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(187, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 92);
            this.button7.TabIndex = 8;
            this.button7.Text = "CREMA";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Info;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(380, 175);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(186, 92);
            this.button8.TabIndex = 9;
            this.button8.Text = "LECHE";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(57, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(69, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 77);
            this.button3.TabIndex = 4;
            this.button3.Text = "GRUPOS ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(69, 484);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(208, 77);
            this.button10.TabIndex = 6;
            this.button10.Text = "UNITARIO";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(34, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL :";
            // 
            // LbPedidos
            // 
            this.LbPedidos.AutoSize = true;
            this.LbPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPedidos.Location = new System.Drawing.Point(49, 310);
            this.LbPedidos.Name = "LbPedidos";
            this.LbPedidos.Size = new System.Drawing.Size(0, 36);
            this.LbPedidos.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 698);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cafe;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbPedidos;
    }
}
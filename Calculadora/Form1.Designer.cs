
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.output = new System.Windows.Forms.TextBox();
            this.berase = new System.Windows.Forms.Button();
            this.beraseE = new System.Windows.Forms.Button();
            this.beraseO = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.bres = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.bsum = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bsumres = new System.Windows.Forms.Button();
            this.bequal = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Enabled = false;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.SystemColors.InfoText;
            this.output.Location = new System.Drawing.Point(12, 11);
            this.output.MaximumSize = new System.Drawing.Size(1000, 80);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.output.Size = new System.Drawing.Size(318, 80);
            this.output.TabIndex = 0;
            this.output.Text = "0";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // berase
            // 
            this.berase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berase.ForeColor = System.Drawing.Color.Red;
            this.berase.Location = new System.Drawing.Point(93, 111);
            this.berase.Name = "berase";
            this.berase.Size = new System.Drawing.Size(75, 75);
            this.berase.TabIndex = 1;
            this.berase.Text = "C";
            this.berase.UseVisualStyleBackColor = true;
            this.berase.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.berase.Click += new System.EventHandler(this.berase_Click);
            // 
            // beraseE
            // 
            this.beraseE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beraseE.ForeColor = System.Drawing.Color.Red;
            this.beraseE.Location = new System.Drawing.Point(12, 111);
            this.beraseE.Name = "beraseE";
            this.beraseE.Size = new System.Drawing.Size(75, 75);
            this.beraseE.TabIndex = 1;
            this.beraseE.Text = "CE";
            this.beraseE.UseVisualStyleBackColor = true;
            this.beraseE.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.beraseE.Click += new System.EventHandler(this.beraseE_Click);
            // 
            // beraseO
            // 
            this.beraseO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beraseO.ForeColor = System.Drawing.Color.Red;
            this.beraseO.Location = new System.Drawing.Point(174, 111);
            this.beraseO.Name = "beraseO";
            this.beraseO.Size = new System.Drawing.Size(75, 75);
            this.beraseO.TabIndex = 2;
            this.beraseO.Text = "⌫";
            this.beraseO.UseVisualStyleBackColor = true;
            this.beraseO.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.beraseO.Click += new System.EventHandler(this.beraseO_Click);
            // 
            // bdiv
            // 
            this.bdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdiv.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bdiv.Location = new System.Drawing.Point(255, 111);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(75, 75);
            this.bdiv.TabIndex = 3;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.bdiv.Click += new System.EventHandler(this.onClickOp);
            // 
            // bmul
            // 
            this.bmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmul.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bmul.Location = new System.Drawing.Point(255, 192);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(75, 75);
            this.bmul.TabIndex = 7;
            this.bmul.Text = "x";
            this.bmul.UseVisualStyleBackColor = true;
            this.bmul.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.bmul.Click += new System.EventHandler(this.onClickOp);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(174, 192);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 75);
            this.b9.TabIndex = 6;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b9.Click += new System.EventHandler(this.onClick);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(12, 192);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 75);
            this.b7.TabIndex = 4;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b7.Click += new System.EventHandler(this.onClick);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(93, 192);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 75);
            this.b8.TabIndex = 5;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b8.Click += new System.EventHandler(this.onClick);
            // 
            // bres
            // 
            this.bres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bres.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bres.Location = new System.Drawing.Point(255, 273);
            this.bres.Name = "bres";
            this.bres.Size = new System.Drawing.Size(75, 75);
            this.bres.TabIndex = 11;
            this.bres.Text = "-";
            this.bres.UseVisualStyleBackColor = true;
            this.bres.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.bres.Click += new System.EventHandler(this.onClickOp);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(174, 273);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 75);
            this.b6.TabIndex = 10;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b6.Click += new System.EventHandler(this.onClick);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(12, 273);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 75);
            this.b4.TabIndex = 8;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b4.Click += new System.EventHandler(this.onClick);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(93, 273);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 75);
            this.b5.TabIndex = 9;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b5.Click += new System.EventHandler(this.onClick);
            // 
            // bsum
            // 
            this.bsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsum.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bsum.Location = new System.Drawing.Point(255, 354);
            this.bsum.Name = "bsum";
            this.bsum.Size = new System.Drawing.Size(75, 75);
            this.bsum.TabIndex = 15;
            this.bsum.Text = "+";
            this.bsum.UseVisualStyleBackColor = true;
            this.bsum.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.bsum.Click += new System.EventHandler(this.onClickOp);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(174, 354);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 14;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b3.Click += new System.EventHandler(this.onClick);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(12, 354);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 12;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b1.Click += new System.EventHandler(this.onClick);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(93, 354);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 13;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b2.Click += new System.EventHandler(this.onClick);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(93, 435);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 75);
            this.b0.TabIndex = 17;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.b0.Click += new System.EventHandler(this.onClick);
            // 
            // bsumres
            // 
            this.bsumres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsumres.ForeColor = System.Drawing.Color.ForestGreen;
            this.bsumres.Location = new System.Drawing.Point(12, 435);
            this.bsumres.Name = "bsumres";
            this.bsumres.Size = new System.Drawing.Size(75, 75);
            this.bsumres.TabIndex = 16;
            this.bsumres.Text = "±";
            this.bsumres.UseVisualStyleBackColor = true;
            this.bsumres.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.bsumres.Click += new System.EventHandler(this.bsumres_Click);
            // 
            // bequal
            // 
            this.bequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bequal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bequal.Location = new System.Drawing.Point(255, 435);
            this.bequal.Name = "bequal";
            this.bequal.Size = new System.Drawing.Size(75, 75);
            this.bequal.TabIndex = 19;
            this.bequal.Text = "=";
            this.bequal.UseVisualStyleBackColor = true;
            this.bequal.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.bequal.Click += new System.EventHandler(this.onClickEqual);
            // 
            // bdot
            // 
            this.bdot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdot.ForeColor = System.Drawing.Color.ForestGreen;
            this.bdot.Location = new System.Drawing.Point(174, 435);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(75, 75);
            this.bdot.TabIndex = 18;
            this.bdot.Text = ",";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.EnabledChanged += new System.EventHandler(this.onClickColor);
            this.bdot.Click += new System.EventHandler(this.onClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(342, 527);
            this.Controls.Add(this.bequal);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.bsumres);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bsum);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.bres);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.beraseO);
            this.Controls.Add(this.beraseE);
            this.Controls.Add(this.berase);
            this.Controls.Add(this.output);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora 0.1b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button berase;
        private System.Windows.Forms.Button beraseE;
        private System.Windows.Forms.Button beraseO;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bmul;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button bres;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button bsum;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bsumres;
        private System.Windows.Forms.Button bequal;
        private System.Windows.Forms.Button bdot;
    }
}


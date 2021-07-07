
namespace Password_Generator
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.lengthPass = new System.Windows.Forms.NumericUpDown();
            this.tpasslength = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generatedPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkHide = new System.Windows.Forms.CheckBox();
            this.bgen = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bcopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lengthPass)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(260, 27);
            this.title.TabIndex = 0;
            this.title.Text = "Password Generator";
            // 
            // lengthPass
            // 
            this.lengthPass.Enabled = false;
            this.lengthPass.Location = new System.Drawing.Point(4, 18);
            this.lengthPass.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.lengthPass.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.lengthPass.Name = "lengthPass";
            this.lengthPass.Size = new System.Drawing.Size(120, 20);
            this.lengthPass.TabIndex = 1;
            this.lengthPass.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // tpasslength
            // 
            this.tpasslength.AutoSize = true;
            this.tpasslength.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpasslength.Location = new System.Drawing.Point(4, 1);
            this.tpasslength.Name = "tpasslength";
            this.tpasslength.Size = new System.Drawing.Size(102, 14);
            this.tpasslength.TabIndex = 2;
            this.tpasslength.Text = "Password length";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tpasslength);
            this.panelMain.Controls.Add(this.lengthPass);
            this.panelMain.Controls.Add(this.check1);
            this.panelMain.Controls.Add(this.check2);
            this.panelMain.Controls.Add(this.check3);
            this.panelMain.Controls.Add(this.check4);
            this.panelMain.Controls.Add(this.check5);
            this.panelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMain.Location = new System.Drawing.Point(25, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(1, 1, 1, 10);
            this.panelMain.Size = new System.Drawing.Size(423, 230);
            this.panelMain.TabIndex = 3;
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Checked = true;
            this.check1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check1.Location = new System.Drawing.Point(4, 44);
            this.check1.Name = "check1";
            this.check1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.check1.Size = new System.Drawing.Size(104, 27);
            this.check1.TabIndex = 4;
            this.check1.Text = "Include numbers";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.includePass);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Checked = true;
            this.check2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check2.Location = new System.Drawing.Point(4, 77);
            this.check2.Name = "check2";
            this.check2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.check2.Size = new System.Drawing.Size(134, 27);
            this.check2.TabIndex = 5;
            this.check2.Text = "Include Symbols (@!%)";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.includePass);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Checked = true;
            this.check3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check3.Location = new System.Drawing.Point(4, 110);
            this.check3.Name = "check3";
            this.check3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.check3.Size = new System.Drawing.Size(168, 27);
            this.check3.TabIndex = 6;
            this.check3.Text = "Include Downcase characters";
            this.check3.UseVisualStyleBackColor = true;
            this.check3.CheckedChanged += new System.EventHandler(this.includePass);
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Checked = true;
            this.check4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check4.Location = new System.Drawing.Point(4, 143);
            this.check4.Name = "check4";
            this.check4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.check4.Size = new System.Drawing.Size(169, 27);
            this.check4.TabIndex = 7;
            this.check4.Text = "Include Uppercase characters";
            this.check4.UseVisualStyleBackColor = true;
            this.check4.CheckedChanged += new System.EventHandler(this.includePass);
            // 
            // check5
            // 
            this.check5.AutoSize = true;
            this.check5.Checked = true;
            this.check5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check5.Location = new System.Drawing.Point(4, 176);
            this.check5.Name = "check5";
            this.check5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.check5.Size = new System.Drawing.Size(102, 27);
            this.check5.TabIndex = 8;
            this.check5.Text = "Random Length";
            this.check5.UseVisualStyleBackColor = true;
            this.check5.CheckedChanged += new System.EventHandler(this.includePass);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "by Tenarion";
            // 
            // generatedPass
            // 
            this.generatedPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.generatedPass.Location = new System.Drawing.Point(125, 316);
            this.generatedPass.MaxLength = 1;
            this.generatedPass.Name = "generatedPass";
            this.generatedPass.ReadOnly = true;
            this.generatedPass.Size = new System.Drawing.Size(235, 20);
            this.generatedPass.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(26, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "New password:";
            // 
            // checkHide
            // 
            this.checkHide.AutoSize = true;
            this.checkHide.Location = new System.Drawing.Point(125, 342);
            this.checkHide.Name = "checkHide";
            this.checkHide.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.checkHide.Size = new System.Drawing.Size(96, 27);
            this.checkHide.TabIndex = 8;
            this.checkHide.Text = "Hide password";
            this.checkHide.UseVisualStyleBackColor = true;
            this.checkHide.CheckedChanged += new System.EventHandler(this.checkHide_CheckedChanged);
            // 
            // bgen
            // 
            this.bgen.Location = new System.Drawing.Point(373, 314);
            this.bgen.Name = "bgen";
            this.bgen.Size = new System.Drawing.Size(75, 23);
            this.bgen.TabIndex = 10;
            this.bgen.Text = "Generate";
            this.bgen.UseVisualStyleBackColor = true;
            this.bgen.Click += new System.EventHandler(this.PasswordGenerator);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(321, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 18);
            this.panel1.TabIndex = 11;
            // 
            // bcopy
            // 
            this.bcopy.Location = new System.Drawing.Point(373, 343);
            this.bcopy.Name = "bcopy";
            this.bcopy.Size = new System.Drawing.Size(98, 23);
            this.bcopy.TabIndex = 12;
            this.bcopy.Text = "Copy to clipboard";
            this.bcopy.UseVisualStyleBackColor = true;
            this.bcopy.Click += new System.EventHandler(this.copyClipboard);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.bcopy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bgen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.title);
            this.Controls.Add(this.generatedPass);
            this.Controls.Add(this.checkHide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.lengthPass)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.NumericUpDown lengthPass;
        private System.Windows.Forms.Label tpasslength;
        private System.Windows.Forms.FlowLayoutPanel panelMain;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox generatedPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkHide;
        private System.Windows.Forms.Button bgen;
        private System.Windows.Forms.CheckBox check5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bcopy;
    }
}


namespace Caesarkrypto
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Encryptbtn = new System.Windows.Forms.Button();
            this.nummersak = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nummersak)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.Lavender;
            this.InputBox.Location = new System.Drawing.Point(436, 141);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(305, 26);
            this.InputBox.TabIndex = 0;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Lavender;
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(54, 344);
            this.OutputLabel.MinimumSize = new System.Drawing.Size(400, 70);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(400, 70);
            this.OutputLabel.TabIndex = 1;
            // 
            // Encryptbtn
            // 
            this.Encryptbtn.BackColor = System.Drawing.Color.Lavender;
            this.Encryptbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encryptbtn.Location = new System.Drawing.Point(436, 219);
            this.Encryptbtn.Name = "Encryptbtn";
            this.Encryptbtn.Size = new System.Drawing.Size(176, 76);
            this.Encryptbtn.TabIndex = 2;
            this.Encryptbtn.Text = "Encrypt!";
            this.Encryptbtn.UseVisualStyleBackColor = false;
            this.Encryptbtn.Click += new System.EventHandler(this.Encryptbtn_Click);
            // 
            // nummersak
            // 
            this.nummersak.BackColor = System.Drawing.Color.Lavender;
            this.nummersak.Location = new System.Drawing.Point(645, 269);
            this.nummersak.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nummersak.Name = "nummersak";
            this.nummersak.Size = new System.Drawing.Size(120, 26);
            this.nummersak.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 298);
            this.label1.MinimumSize = new System.Drawing.Size(200, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enkrypterad text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(883, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nummersak);
            this.Controls.Add(this.Encryptbtn);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nummersak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button Encryptbtn;
        private System.Windows.Forms.NumericUpDown nummersak;
        private System.Windows.Forms.Label label1;
    }
}


namespace Weather_APP
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
            this.temperatuurLbl = new System.Windows.Forms.Label();
            this.windkrachtLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.stadLbl = new System.Windows.Forms.Label();
            this.stadInvoertxt = new System.Windows.Forms.TextBox();
            this.stadZoekbtn = new System.Windows.Forms.Button();
            this.stad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // temperatuurLbl
            // 
            this.temperatuurLbl.AutoSize = true;
            this.temperatuurLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.temperatuurLbl.Location = new System.Drawing.Point(75, 58);
            this.temperatuurLbl.Name = "temperatuurLbl";
            this.temperatuurLbl.Size = new System.Drawing.Size(0, 25);
            this.temperatuurLbl.TabIndex = 0;
            // 
            // windkrachtLbl
            // 
            this.windkrachtLbl.AutoSize = true;
            this.windkrachtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.windkrachtLbl.Location = new System.Drawing.Point(75, 110);
            this.windkrachtLbl.Name = "windkrachtLbl";
            this.windkrachtLbl.Size = new System.Drawing.Size(0, 25);
            this.windkrachtLbl.TabIndex = 1;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeLbl.Location = new System.Drawing.Point(75, 157);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(0, 25);
            this.timeLbl.TabIndex = 2;
            // 
            // stadLbl
            // 
            this.stadLbl.AutoSize = true;
            this.stadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.stadLbl.Location = new System.Drawing.Point(74, 302);
            this.stadLbl.Name = "stadLbl";
            this.stadLbl.Size = new System.Drawing.Size(78, 31);
            this.stadLbl.TabIndex = 3;
            this.stadLbl.Text = "Stad:";
            // 
            // stadInvoertxt
            // 
            this.stadInvoertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.stadInvoertxt.Location = new System.Drawing.Point(150, 305);
            this.stadInvoertxt.Name = "stadInvoertxt";
            this.stadInvoertxt.Size = new System.Drawing.Size(100, 30);
            this.stadInvoertxt.TabIndex = 4;
            // 
            // stadZoekbtn
            // 
            this.stadZoekbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stadZoekbtn.Location = new System.Drawing.Point(265, 305);
            this.stadZoekbtn.Name = "stadZoekbtn";
            this.stadZoekbtn.Size = new System.Drawing.Size(100, 30);
            this.stadZoekbtn.TabIndex = 5;
            this.stadZoekbtn.Text = "Zoek";
            this.stadZoekbtn.UseVisualStyleBackColor = true;
            this.stadZoekbtn.Click += new System.EventHandler(this.stadZoekbtn_Click);
            // 
            // stad
            // 
            this.stad.AutoSize = true;
            this.stad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.stad.Location = new System.Drawing.Point(75, 34);
            this.stad.Name = "stad";
            this.stad.Size = new System.Drawing.Size(0, 25);
            this.stad.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 579);
            this.Controls.Add(this.stad);
            this.Controls.Add(this.stadZoekbtn);
            this.Controls.Add(this.stadInvoertxt);
            this.Controls.Add(this.stadLbl);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.windkrachtLbl);
            this.Controls.Add(this.temperatuurLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weer van vandaag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temperatuurLbl;
        private System.Windows.Forms.Label windkrachtLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label stadLbl;
        private System.Windows.Forms.TextBox stadInvoertxt;
        private System.Windows.Forms.Button stadZoekbtn;
        private System.Windows.Forms.Label stad;
    }
}


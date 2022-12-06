namespace FifaPlayers
{
    partial class FrmInsertPlayer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(12, 81);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(263, 23);
            this.txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(12, 131);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(263, 23);
            this.txtHeight.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 294);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(263, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Inserir Jogador";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "yyyy-MM-dd";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(12, 186);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(262, 23);
            this.dtp.TabIndex = 4;
            this.dtp.Value = new System.DateTime(2022, 12, 1, 23, 39, 53, 0);
            // 
            // cboCountries
            // 
            this.cboCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Location = new System.Drawing.Point(12, 243);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(263, 23);
            this.cboCountries.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nome:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 63);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(42, 15);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "Altura:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 113);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(35, 15);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Peso:";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(12, 168);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(101, 15);
            this.lblBirthdate.TabIndex = 9;
            this.lblBirthdate.Text = "Data Nascimento;";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(12, 225);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(28, 15);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "País";
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 349);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboCountries);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.Name = "FrmInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Jogador";
            this.Load += new System.EventHandler(this.FrmInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtName;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Button btnInsert;
        private DateTimePicker dtp;
        private ComboBox cboCountries;
        private Label lblName;
        private Label lblHeight;
        private Label lblWeight;
        private Label lblBirthdate;
        private Label lblCountry;
    }
}
namespace FifaPlayers
{
    partial class FrmEditPlayer
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(22, 252);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(28, 15);
            this.lblCountry.TabIndex = 21;
            this.lblCountry.Text = "País";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(22, 195);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(101, 15);
            this.lblBirthdate.TabIndex = 20;
            this.lblBirthdate.Text = "Data Nascimento;";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(22, 140);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(35, 15);
            this.lblWeight.TabIndex = 19;
            this.lblWeight.Text = "Peso:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(22, 90);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(42, 15);
            this.lblHeight.TabIndex = 18;
            this.lblHeight.Text = "Altura:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Nome:";
            // 
            // cboCountries
            // 
            this.cboCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Location = new System.Drawing.Point(22, 270);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(263, 23);
            this.cboCountries.TabIndex = 16;
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "yyyy-MM-dd";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(22, 213);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(262, 23);
            this.dtp.TabIndex = 15;
            this.dtp.Value = new System.DateTime(2022, 12, 1, 23, 39, 53, 0);
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(22, 321);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(263, 23);
            this.btnEditPlayer.TabIndex = 14;
            this.btnEditPlayer.Text = "Editar Jogador";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(22, 158);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(263, 23);
            this.txtWeight.TabIndex = 13;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(22, 108);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(263, 23);
            this.txtHeight.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 23);
            this.txtName.TabIndex = 11;
            // 
            // FrmEditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 383);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboCountries);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.Name = "FrmEditPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Jogador";
            this.Load += new System.EventHandler(this.FrmEditPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCountry;
        private Label lblBirthdate;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblName;
        private DateTimePicker dtp;
        private Button btnEditPlayer;
        private ComboBox cboCountries;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtName;
    }
}
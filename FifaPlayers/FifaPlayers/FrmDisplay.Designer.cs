namespace FifaPlayers
{
    partial class FrmDisplay
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.lblSearchCountry = new System.Windows.Forms.Label();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(667, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboCountries
            // 
            this.cboCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Location = new System.Drawing.Point(667, 45);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(121, 23);
            this.cboCountries.TabIndex = 2;
            this.cboCountries.SelectedIndexChanged += new System.EventHandler(this.cboCountries_SelectedIndexChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(126, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Adicionar Jogador";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(1, 74);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowTemplate.Height = 25;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(798, 374);
            this.dgvPlayers.TabIndex = 4;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(549, 16);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(112, 15);
            this.lblSearchName.TabIndex = 5;
            this.lblSearchName.Text = "Procurar por Nome:";
            // 
            // lblSearchCountry
            // 
            this.lblSearchCountry.AutoSize = true;
            this.lblSearchCountry.Location = new System.Drawing.Point(549, 48);
            this.lblSearchCountry.Name = "lblSearchCountry";
            this.lblSearchCountry.Size = new System.Drawing.Size(100, 15);
            this.lblSearchCountry.TabIndex = 6;
            this.lblSearchCountry.Text = "Procurar por País:";
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(144, 12);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(117, 23);
            this.btnEditPlayer.TabIndex = 7;
            this.btnEditPlayer.Text = "Editar Jogador";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(267, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Apagar Jogador";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.lblSearchCountry);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cboCountries);
            this.Controls.Add(this.txtSearch);
            this.MaximizeBox = false;
            this.Name = "FrmDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fifa Players CRUD";
            this.Load += new System.EventHandler(this.FrmDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtSearch;
        private ComboBox cboCountries;
        private Button btnInsert;
        private Label lblSearchName;
        private Label lblSearchCountry;
        private Button btnEditPlayer;
        public DataGridView dgvPlayers;
        private Button btnDelete;
    }
}
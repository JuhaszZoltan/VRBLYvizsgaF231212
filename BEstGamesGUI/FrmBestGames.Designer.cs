namespace BEstGamesGUI
{
    partial class FrmBestGames
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
            gbxSearch = new GroupBox();
            cbxGenre = new ComboBox();
            tbxTitle = new TextBox();
            lblUI02 = new Label();
            lblUI01 = new Label();
            dgvGames = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lnkGoogle = new LinkLabel();
            gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // gbxSearch
            // 
            gbxSearch.BackColor = Color.PaleGreen;
            gbxSearch.Controls.Add(cbxGenre);
            gbxSearch.Controls.Add(tbxTitle);
            gbxSearch.Controls.Add(lblUI02);
            gbxSearch.Controls.Add(lblUI01);
            gbxSearch.Location = new Point(13, 13);
            gbxSearch.Margin = new Padding(4);
            gbxSearch.Name = "gbxSearch";
            gbxSearch.Padding = new Padding(4);
            gbxSearch.Size = new Size(688, 86);
            gbxSearch.TabIndex = 0;
            gbxSearch.TabStop = false;
            gbxSearch.Text = "search";
            // 
            // cbxGenre
            // 
            cbxGenre.FormattingEnabled = true;
            cbxGenre.Location = new Point(483, 30);
            cbxGenre.Margin = new Padding(4);
            cbxGenre.Name = "cbxGenre";
            cbxGenre.Size = new Size(154, 29);
            cbxGenre.TabIndex = 2;
            // 
            // tbxTitle
            // 
            tbxTitle.Location = new Point(102, 30);
            tbxTitle.Margin = new Padding(4);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(289, 29);
            tbxTitle.TabIndex = 1;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(422, 33);
            lblUI02.Margin = new Padding(4, 0, 4, 0);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(53, 21);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "genre:";
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(55, 33);
            lblUI01.Margin = new Padding(4, 0, 4, 0);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(39, 21);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "title:";
            // 
            // dgvGames
            // 
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.AllowUserToResizeColumns = false;
            dgvGames.AllowUserToResizeRows = false;
            dgvGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGames.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvGames.Location = new Point(13, 120);
            dgvGames.Margin = new Padding(4);
            dgvGames.Name = "dgvGames";
            dgvGames.RowHeadersVisible = false;
            dgvGames.RowTemplate.Height = 25;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(688, 311);
            dgvGames.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 6F;
            Column2.HeaderText = "title";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 1F;
            Column3.HeaderText = "year";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 2F;
            Column4.HeaderText = "genre";
            Column4.Name = "Column4";
            // 
            // lnkGoogle
            // 
            lnkGoogle.ActiveLinkColor = Color.Black;
            lnkGoogle.BackColor = Color.PaleGreen;
            lnkGoogle.LinkColor = Color.Black;
            lnkGoogle.Location = new Point(13, 452);
            lnkGoogle.Margin = new Padding(4, 0, 4, 0);
            lnkGoogle.Name = "lnkGoogle";
            lnkGoogle.Size = new Size(688, 57);
            lnkGoogle.TabIndex = 2;
            lnkGoogle.TabStop = true;
            lnkGoogle.Text = "###GOOGLE search URL###";
            lnkGoogle.TextAlign = ContentAlignment.MiddleCenter;
            lnkGoogle.VisitedLinkColor = Color.Black;
            // 
            // FrmBestGames
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(714, 529);
            Controls.Add(lnkGoogle);
            Controls.Add(dgvGames);
            Controls.Add(gbxSearch);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmBestGames";
            Text = "Best Video Games of All Time";
            gbxSearch.ResumeLayout(false);
            gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxSearch;
        private ComboBox cbxGenre;
        private TextBox tbxTitle;
        private Label lblUI01;
        private DataGridView dgvGames;
        private LinkLabel lnkGoogle;
        private Label lblUI02;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}

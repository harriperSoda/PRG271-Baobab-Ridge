namespace PRG271_Baobab_Ridge
{
    partial class Form1
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
            dgvAnimals = new DataGridView();
            txtAnimalId = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtRecoveryScore = new TextBox();
            txtSearchId = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(320, 44);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(515, 319);
            dgvAnimals.TabIndex = 0;
            dgvAnimals.CellClick += dgvAnimals_CellClick;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick;
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(116, 44);
            txtAnimalId.Margin = new Padding(3, 2, 3, 2);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.PlaceholderText = "Animal ID";
            txtAnimalId.Size = new Size(110, 23);
            txtAnimalId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 99);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 2;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(116, 157);
            txtSpecies.Margin = new Padding(3, 2, 3, 2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.PlaceholderText = "Species";
            txtSpecies.Size = new Size(110, 23);
            txtSpecies.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(116, 214);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(110, 23);
            txtAge.TabIndex = 4;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(116, 279);
            txtRecoveryScore.Margin = new Padding(3, 2, 3, 2);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.PlaceholderText = "Recovery Score";
            txtRecoveryScore.Size = new Size(110, 23);
            txtRecoveryScore.TabIndex = 5;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(116, 343);
            txtSearchId.Margin = new Padding(3, 2, 3, 2);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "Search ID";
            txtSearchId.Size = new Size(110, 23);
            txtSearchId.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(890, 136);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(890, 193);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(890, 245);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(890, 299);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(890, 352);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkGreen;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1384, 95);
            pnlHeader.TabIndex = 12;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.WhiteSmoke;
            lblSubtitle.Location = new Point(33, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(236, 17);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "Animal care and recovery management";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(603, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Baobab Ridge Wildlife Rehabilitation Records";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1384, 761);
            Controls.Add(pnlHeader);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearchId);
            Controls.Add(txtRecoveryScore);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtAnimalId);
            Controls.Add(dgvAnimals);
            MinimumSize = new Size(1200, 720);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baobab Ridge Wildlife Rehabilitation Records";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAnimals;
        private TextBox txtAnimalId;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private TextBox txtRecoveryScore;
        private TextBox txtSearchId;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnSearch;
        private Button btnDelete;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
    }
}

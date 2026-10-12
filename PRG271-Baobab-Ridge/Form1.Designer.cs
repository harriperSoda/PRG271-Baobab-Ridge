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
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(366, 59);
            dgvAnimals.Margin = new Padding(3, 4, 3, 4);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(589, 425);
            dgvAnimals.TabIndex = 0;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick;
            dgvAnimals.CellClick += dgvAnimals_CellClick;
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(133, 59);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.PlaceholderText = "Animal ID";
            txtAnimalId.Size = new Size(125, 27);
            txtAnimalId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 132);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 2;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(133, 209);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.PlaceholderText = "Species";
            txtSpecies.Size = new Size(125, 27);
            txtSpecies.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(133, 286);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 4;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(133, 372);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.PlaceholderText = "Recovery Score";
            txtRecoveryScore.Size = new Size(125, 27);
            txtRecoveryScore.TabIndex = 5;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(133, 457);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.PlaceholderText = "Search ID";
            txtSearchId.Size = new Size(125, 27);
            txtSearchId.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1017, 181);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(1017, 257);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(1017, 327);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1017, 399);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 695);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
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
    }
}

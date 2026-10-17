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
            lblTotal = new Label();
            lblAvgAge = new Label();
            lblAvgScore = new Label();
            lblCritical = new Label();
            lblSerious = new Label();
            lblStable = new Label();
            lblRecovering = new Label();
            lblReleaseReady = new Label();
            btnGenerateSummary = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
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
            dgvAnimals.CellClick += dgvAnimals_CellClick;
            dgvAnimals.CellContentClick += dgvAnimals_CellContentClick;
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
            btnAdd.Location = new Point(997, 127);
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
            btnUpdate.Location = new Point(997, 203);
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
            btnCancel.Location = new Point(997, 273);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(997, 345);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(997, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(302, 571);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(17, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "0";
            lblTotal.Click += label1_Click;
            // 
            // lblAvgAge
            // 
            lblAvgAge.AutoSize = true;
            lblAvgAge.Location = new Point(385, 571);
            lblAvgAge.Name = "lblAvgAge";
            lblAvgAge.Size = new Size(17, 20);
            lblAvgAge.TabIndex = 13;
            lblAvgAge.Text = "0";
            // 
            // lblAvgScore
            // 
            lblAvgScore.AutoSize = true;
            lblAvgScore.Location = new Point(483, 571);
            lblAvgScore.Name = "lblAvgScore";
            lblAvgScore.Size = new Size(17, 20);
            lblAvgScore.TabIndex = 14;
            lblAvgScore.Text = "0";
            // 
            // lblCritical
            // 
            lblCritical.AutoSize = true;
            lblCritical.Location = new Point(578, 571);
            lblCritical.Name = "lblCritical";
            lblCritical.Size = new Size(17, 20);
            lblCritical.TabIndex = 15;
            lblCritical.Text = "0";
            // 
            // lblSerious
            // 
            lblSerious.AutoSize = true;
            lblSerious.Location = new Point(674, 571);
            lblSerious.Name = "lblSerious";
            lblSerious.Size = new Size(17, 20);
            lblSerious.TabIndex = 16;
            lblSerious.Text = "0";
            // 
            // lblStable
            // 
            lblStable.AutoSize = true;
            lblStable.Location = new Point(764, 571);
            lblStable.Name = "lblStable";
            lblStable.Size = new Size(17, 20);
            lblStable.TabIndex = 17;
            lblStable.Text = "0";
            // 
            // lblRecovering
            // 
            lblRecovering.AutoSize = true;
            lblRecovering.Location = new Point(865, 571);
            lblRecovering.Name = "lblRecovering";
            lblRecovering.Size = new Size(17, 20);
            lblRecovering.TabIndex = 18;
            lblRecovering.Text = "0";
            // 
            // lblReleaseReady
            // 
            lblReleaseReady.AutoSize = true;
            lblReleaseReady.Location = new Point(985, 571);
            lblReleaseReady.Name = "lblReleaseReady";
            lblReleaseReady.Size = new Size(17, 20);
            lblReleaseReady.TabIndex = 19;
            lblReleaseReady.Text = "0";
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(571, 503);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(168, 29);
            btnGenerateSummary.TabIndex = 20;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 551);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 21;
            label1.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 551);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 22;
            label2.Text = "Avg Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 551);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 23;
            label3.Text = "Avg Score";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(562, 551);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 24;
            label4.Text = "Critical";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(656, 551);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 25;
            label5.Text = "Serious";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(748, 551);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 26;
            label6.Text = "Stable";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(834, 551);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 27;
            label7.Text = "Recovering";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(945, 551);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 28;
            label8.Text = "Release-Ready";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 695);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerateSummary);
            Controls.Add(lblReleaseReady);
            Controls.Add(lblRecovering);
            Controls.Add(lblStable);
            Controls.Add(lblSerious);
            Controls.Add(lblCritical);
            Controls.Add(lblAvgScore);
            Controls.Add(lblAvgAge);
            Controls.Add(lblTotal);
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
        private Button btnDelete;
        private Label lblTotal;
        private Label lblAvgAge;
        private Label lblAvgScore;
        private Label lblCritical;
        private Label lblSerious;
        private Label lblStable;
        private Label lblRecovering;
        private Label lblReleaseReady;
        private Button btnGenerateSummary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}

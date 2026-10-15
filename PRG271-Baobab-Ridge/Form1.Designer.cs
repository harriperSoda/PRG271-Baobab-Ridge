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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtSearchId = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            grpAnimalDetails = new GroupBox();
            lblName = new Label();
            lblAge = new Label();
            lblSpecies = new Label();
            lblRecoveryScore = new Label();
            lblAnimalId = new Label();
            txtRecoveryScore = new TextBox();
            txtAge = new TextBox();
            txtSpecies = new TextBox();
            txtName = new TextBox();
            txtAnimalId = new TextBox();
            grpSearch = new GroupBox();
            lblSearchId = new Label();
            grpAnimals = new GroupBox();
            dgvAnimals = new DataGridView();
            grpActions = new GroupBox();
            pnlHeader.SuspendLayout();
            grpAnimalDetails.SuspendLayout();
            grpSearch.SuspendLayout();
            grpAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            grpActions.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchId
            // 
            txtSearchId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchId.Location = new Point(20, 55);
            txtSearchId.Margin = new Padding(3, 2, 3, 2);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(175, 25);
            txtSearchId.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 55);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 45);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(20, 125);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 45);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Save Changes";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += this.btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.DimGray;
            btnCancel.Enabled = false;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(20, 195);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 45);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(205, 53);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 31);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(20, 265);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 45);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete Animal";
            btnDelete.UseVisualStyleBackColor = false;
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
            // grpAnimalDetails
            // 
            grpAnimalDetails.Controls.Add(lblName);
            grpAnimalDetails.Controls.Add(lblAge);
            grpAnimalDetails.Controls.Add(lblSpecies);
            grpAnimalDetails.Controls.Add(lblRecoveryScore);
            grpAnimalDetails.Controls.Add(lblAnimalId);
            grpAnimalDetails.Controls.Add(txtRecoveryScore);
            grpAnimalDetails.Controls.Add(txtAge);
            grpAnimalDetails.Controls.Add(txtSpecies);
            grpAnimalDetails.Controls.Add(txtName);
            grpAnimalDetails.Controls.Add(txtAnimalId);
            grpAnimalDetails.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAnimalDetails.ForeColor = Color.DarkGreen;
            grpAnimalDetails.Location = new Point(20, 115);
            grpAnimalDetails.Name = "grpAnimalDetails";
            grpAnimalDetails.Size = new Size(310, 365);
            grpAnimalDetails.TabIndex = 13;
            grpAnimalDetails.TabStop = false;
            grpAnimalDetails.Text = "Animal Details";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DarkSlateGray;
            lblName.Location = new Point(20, 92);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 22;
            lblName.Text = "Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.DarkSlateGray;
            lblAge.Location = new Point(20, 212);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(32, 15);
            lblAge.TabIndex = 21;
            lblAge.Text = "Age:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecies.ForeColor = Color.DarkSlateGray;
            lblSpecies.Location = new Point(20, 152);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(52, 15);
            lblSpecies.TabIndex = 20;
            lblSpecies.Text = "Species:";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecoveryScore.ForeColor = Color.DarkSlateGray;
            lblRecoveryScore.Location = new Point(20, 272);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(98, 15);
            lblRecoveryScore.TabIndex = 19;
            lblRecoveryScore.Text = "Recovery Score:";
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnimalId.ForeColor = Color.DarkSlateGray;
            lblAnimalId.Location = new Point(20, 32);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(64, 15);
            lblAnimalId.TabIndex = 15;
            lblAnimalId.Text = "Animal ID:";
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecoveryScore.Location = new Point(20, 295);
            txtRecoveryScore.Margin = new Padding(3, 2, 3, 2);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(270, 25);
            txtRecoveryScore.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(20, 235);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(270, 25);
            txtAge.TabIndex = 9;
            // 
            // txtSpecies
            // 
            txtSpecies.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecies.Location = new Point(20, 175);
            txtSpecies.Margin = new Padding(3, 2, 3, 2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(270, 25);
            txtSpecies.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(20, 115);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 25);
            txtName.TabIndex = 7;
            // 
            // txtAnimalId
            // 
            txtAnimalId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnimalId.Location = new Point(20, 55);
            txtAnimalId.Margin = new Padding(3, 2, 3, 2);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(270, 25);
            txtAnimalId.TabIndex = 6;
            txtAnimalId.TextChanged += txtAnimalId_TextChanged;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(lblSearchId);
            grpSearch.Controls.Add(txtSearchId);
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSearch.ForeColor = Color.DarkGreen;
            grpSearch.Location = new Point(20, 495);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(310, 125);
            grpSearch.TabIndex = 14;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search by Animal ID";
            // 
            // lblSearchId
            // 
            lblSearchId.AutoSize = true;
            lblSearchId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchId.ForeColor = Color.DarkSlateGray;
            lblSearchId.Location = new Point(20, 32);
            lblSearchId.Name = "lblSearchId";
            lblSearchId.Size = new Size(64, 15);
            lblSearchId.TabIndex = 15;
            lblSearchId.Text = "Search ID:";
            // 
            // grpAnimals
            // 
            grpAnimals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpAnimals.Controls.Add(dgvAnimals);
            grpAnimals.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAnimals.ForeColor = Color.DarkGreen;
            grpAnimals.Location = new Point(350, 115);
            grpAnimals.Name = "grpAnimals";
            grpAnimals.Size = new Size(820, 505);
            grpAnimals.TabIndex = 15;
            grpAnimals.TabStop = false;
            grpAnimals.Text = "Animals in Care";
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.BackgroundColor = Color.White;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAnimals.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAnimals.Location = new Point(15, 35);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(790, 450);
            dgvAnimals.TabIndex = 1;
            // 
            // grpActions
            // 
            grpActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpActions.Controls.Add(btnAdd);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnCancel);
            grpActions.Controls.Add(btnDelete);
            grpActions.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpActions.ForeColor = Color.DarkGreen;
            grpActions.Location = new Point(1190, 115);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(190, 505);
            grpActions.TabIndex = 16;
            grpActions.TabStop = false;
            grpActions.Text = "Actions";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1384, 761);
            Controls.Add(grpActions);
            Controls.Add(grpSearch);
            Controls.Add(pnlHeader);
            Controls.Add(grpAnimalDetails);
            Controls.Add(grpAnimals);
            MinimumSize = new Size(1200, 720);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baobab Ridge Wildlife Rehabilitation Records";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpAnimalDetails.ResumeLayout(false);
            grpAnimalDetails.PerformLayout();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            grpAnimals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            grpActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearchId;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnSearch;
        private Button btnDelete;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private GroupBox grpAnimalDetails;
        private TextBox txtRecoveryScore;
        private TextBox txtAge;
        private TextBox txtSpecies;
        private TextBox txtName;
        private TextBox txtAnimalId;
        private Label lblName;
        private Label lblAge;
        private Label lblSpecies;
        private Label lblRecoveryScore;
        private Label lblAnimalId;
        private GroupBox grpSearch;
        private Label lblSearchId;
        private GroupBox grpAnimals;
        private DataGridView dgvAnimals;
        private GroupBox grpActions;
    }
}

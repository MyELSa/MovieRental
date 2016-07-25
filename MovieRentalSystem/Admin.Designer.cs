namespace MovieRentalSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMovies = new System.Windows.Forms.Button();
            this.dtvMov = new System.Windows.Forms.DataGridView();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.btnRented = new System.Windows.Forms.Button();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.btnSO = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnMovies);
            this.panel1.Controls.Add(this.dtvMov);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.dgvCust);
            this.panel1.Controls.Add(this.btnRented);
            this.panel1.Controls.Add(this.dgvMovies);
            this.panel1.Location = new System.Drawing.Point(173, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 687);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMovies
            // 
            this.btnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.Location = new System.Drawing.Point(459, 637);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(145, 33);
            this.btnMovies.TabIndex = 23;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // dtvMov
            // 
            this.dtvMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMov.Location = new System.Drawing.Point(12, 455);
            this.dtvMov.Name = "dtvMov";
            this.dtvMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvMov.Size = new System.Drawing.Size(592, 174);
            this.dtvMov.TabIndex = 22;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(459, 416);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(145, 33);
            this.btnCustomer.TabIndex = 21;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // dgvCust
            // 
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.Location = new System.Drawing.Point(12, 234);
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCust.Size = new System.Drawing.Size(592, 174);
            this.dgvCust.TabIndex = 20;
            // 
            // btnRented
            // 
            this.btnRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRented.Location = new System.Drawing.Point(459, 195);
            this.btnRented.Name = "btnRented";
            this.btnRented.Size = new System.Drawing.Size(145, 33);
            this.btnRented.TabIndex = 19;
            this.btnRented.Text = "Rented Movies";
            this.btnRented.UseVisualStyleBackColor = true;
            this.btnRented.Click += new System.EventHandler(this.btnRented_Click);
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(12, 13);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(592, 174);
            this.dgvMovies.TabIndex = 7;
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRented_CellContentClick);
            this.dgvMovies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRented_MouseDoubleClick);
            // 
            // btnSO
            // 
            this.btnSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSO.Location = new System.Drawing.Point(12, 279);
            this.btnSO.Name = "btnSO";
            this.btnSO.Size = new System.Drawing.Size(145, 33);
            this.btnSO.TabIndex = 11;
            this.btnSO.Text = "Sign Out";
            this.btnSO.UseVisualStyleBackColor = true;
            this.btnSO.Click += new System.EventHandler(this.btnSO_Click);
            // 
            // btnMC
            // 
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(12, 215);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(145, 42);
            this.btnMC.TabIndex = 15;
            this.btnMC.Text = "Manage Customer";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMM
            // 
            this.btnMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMM.Location = new System.Drawing.Point(12, 161);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(145, 34);
            this.btnMM.TabIndex = 14;
            this.btnMM.Text = "Manage Movies";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.button3_Click);
            // 
            // profile
            // 
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile.ErrorImage = null;
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("profile.InitialImage")));
            this.profile.Location = new System.Drawing.Point(12, 25);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(145, 114);
            this.profile.TabIndex = 18;
            this.profile.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 719);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSO);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMM);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSO;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnRented;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.DataGridView dtvMov;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.DataGridView dgvCust;
    }
}
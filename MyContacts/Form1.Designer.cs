
namespace MyContacts
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewContact = new System.Windows.Forms.ToolStripButton();
            this.Search = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgcontacts = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.ContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontacts)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewContact,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewContact
            // 
            this.btnNewContact.Image = ((System.Drawing.Image)(resources.GetObject("btnNewContact.Image")));
            this.btnNewContact.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(44, 64);
            this.btnNewContact.Text = "Add";
            this.btnNewContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(13, 70);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(675, 64);
            this.Search.TabIndex = 1;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgcontacts);
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 307);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // dgcontacts
            // 
            this.dgcontacts.AllowUserToAddRows = false;
            this.dgcontacts.AllowUserToDeleteRows = false;
            this.dgcontacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcontacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcontacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactID,
            this.MyName,
            this.Family,
            this.Mobile,
            this.Age,
            this.Email});
            this.dgcontacts.Location = new System.Drawing.Point(6, 22);
            this.dgcontacts.Name = "dgcontacts";
            this.dgcontacts.ReadOnly = true;
            this.dgcontacts.RowHeadersWidth = 51;
            this.dgcontacts.RowTemplate.Height = 24;
            this.dgcontacts.Size = new System.Drawing.Size(664, 276);
            this.dgcontacts.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 64);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ContactID
            // 
            this.ContactID.DataPropertyName = "ContacID";
            this.ContactID.HeaderText = "ID";
            this.ContactID.MinimumWidth = 6;
            this.ContactID.Name = "ContactID";
            this.ContactID.ReadOnly = true;
            this.ContactID.Visible = false;
            // 
            // MyName
            // 
            this.MyName.DataPropertyName = "Name";
            this.MyName.HeaderText = "Name";
            this.MyName.MinimumWidth = 6;
            this.MyName.Name = "MyName";
            this.MyName.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.HeaderText = "Family";
            this.Family.MinimumWidth = 6;
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.MinimumWidth = 6;
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "My Phone Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewContact;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgcontacts;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}


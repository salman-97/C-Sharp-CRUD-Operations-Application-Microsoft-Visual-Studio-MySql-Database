namespace SalmanApplication
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.logo = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Panel();
            this.DGVtable = new System.Windows.Forms.DataGridView();
            this.delinfo = new System.Windows.Forms.Label();
            this.closeBTN = new System.Windows.Forms.Button();
            this.delBTN = new System.Windows.Forms.Button();
            this.footer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtable)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(137, 77);
            this.logo.TabIndex = 53;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(236, 44);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(257, 45);
            this.header.TabIndex = 52;
            this.header.Text = "DELETE RECORD";
            // 
            // image
            // 
            this.image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("image.BackgroundImage")));
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.Location = new System.Drawing.Point(620, 12);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(119, 115);
            this.image.TabIndex = 51;
            // 
            // DGVtable
            // 
            this.DGVtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtable.Location = new System.Drawing.Point(20, 180);
            this.DGVtable.Name = "DGVtable";
            this.DGVtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVtable.Size = new System.Drawing.Size(712, 348);
            this.DGVtable.TabIndex = 54;
            // 
            // delinfo
            // 
            this.delinfo.AutoSize = true;
            this.delinfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delinfo.Location = new System.Drawing.Point(15, 152);
            this.delinfo.Name = "delinfo";
            this.delinfo.Size = new System.Drawing.Size(283, 25);
            this.delinfo.TabIndex = 55;
            this.delinfo.Text = "* Select a row to delete the record";
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.AliceBlue;
            this.closeBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBTN.Location = new System.Drawing.Point(19, 544);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(161, 37);
            this.closeBTN.TabIndex = 57;
            this.closeBTN.Text = "CLOSE";
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // delBTN
            // 
            this.delBTN.BackColor = System.Drawing.Color.GhostWhite;
            this.delBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBTN.Location = new System.Drawing.Point(570, 544);
            this.delBTN.Name = "delBTN";
            this.delBTN.Size = new System.Drawing.Size(161, 37);
            this.delBTN.TabIndex = 56;
            this.delBTN.Text = "DELETE";
            this.delBTN.UseVisualStyleBackColor = false;
            this.delBTN.Click += new System.EventHandler(this.delBTN_Click);
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer.Location = new System.Drawing.Point(210, 592);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(307, 17);
            this.footer.TabIndex = 58;
            this.footer.Text = "Database Application Created by Muhammad Salman";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 614);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.delBTN);
            this.Controls.Add(this.delinfo);
            this.Controls.Add(this.DGVtable);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.header);
            this.Controls.Add(this.image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel image;
        private System.Windows.Forms.DataGridView DGVtable;
        private System.Windows.Forms.Label delinfo;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button delBTN;
        private System.Windows.Forms.Label footer;
    }
}
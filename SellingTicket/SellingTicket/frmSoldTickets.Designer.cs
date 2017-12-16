namespace SellingTicket
{
    partial class frmSoldTickets
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
            this.dgvAllTickets = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTickets
            // 
            this.dgvAllTickets.AllowUserToAddRows = false;
            this.dgvAllTickets.AllowUserToDeleteRows = false;
            this.dgvAllTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllTickets.Location = new System.Drawing.Point(0, 0);
            this.dgvAllTickets.Name = "dgvAllTickets";
            this.dgvAllTickets.ReadOnly = true;
            this.dgvAllTickets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAllTickets.RowTemplate.Height = 24;
            this.dgvAllTickets.Size = new System.Drawing.Size(782, 448);
            this.dgvAllTickets.TabIndex = 0;
            // 
            // frmSoldTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 448);
            this.Controls.Add(this.dgvAllTickets);
            this.Name = "frmSoldTickets";
            this.Text = "frmSoldTickets";
            this.Load += new System.EventHandler(this.frmSoldTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllTickets;
    }
}
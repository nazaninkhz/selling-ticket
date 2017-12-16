namespace SellingTicket
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.btnSoldTickets = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "خوش آمدید آقا/خانم";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(199, 20);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(18, 17);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "--";
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.Location = new System.Drawing.Point(12, 72);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(458, 47);
            this.btnSellTicket.TabIndex = 2;
            this.btnSellTicket.Text = "صدور بلیط";
            this.btnSellTicket.UseVisualStyleBackColor = true;
            this.btnSellTicket.Click += new System.EventHandler(this.btnSellTicket_Click);
            // 
            // btnSoldTickets
            // 
            this.btnSoldTickets.Location = new System.Drawing.Point(12, 137);
            this.btnSoldTickets.Name = "btnSoldTickets";
            this.btnSoldTickets.Size = new System.Drawing.Size(458, 47);
            this.btnSoldTickets.TabIndex = 3;
            this.btnSoldTickets.Text = "لیست فروش";
            this.btnSoldTickets.UseVisualStyleBackColor = true;
            this.btnSoldTickets.Click += new System.EventHandler(this.btnSoldTickets_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(458, 47);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSoldTickets);
            this.Controls.Add(this.btnSellTicket);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.Button btnSoldTickets;
        private System.Windows.Forms.Button btnExit;
    }
}
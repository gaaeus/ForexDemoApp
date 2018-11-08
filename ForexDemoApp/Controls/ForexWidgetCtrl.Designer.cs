namespace ForexDemoApp.Controls
{
    partial class ForexWidgetCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPair = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblPair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 33);
            this.panel1.TabIndex = 0;
            // 
            // lblPair
            // 
            this.lblPair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPair.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPair.ForeColor = System.Drawing.Color.White;
            this.lblPair.Location = new System.Drawing.Point(0, 0);
            this.lblPair.Name = "lblPair";
            this.lblPair.Size = new System.Drawing.Size(262, 33);
            this.lblPair.TabIndex = 0;
            this.lblPair.Text = "EUR/GBP";
            this.lblPair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::ForexDemoApp.Properties.Resources.ButtonFontClose;
            this.btnClose.Location = new System.Drawing.Point(233, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 5000;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblBuy, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSell, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 145);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSell.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.ForeColor = System.Drawing.Color.White;
            this.lblSell.Location = new System.Drawing.Point(3, 0);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(125, 13);
            this.lblSell.TabIndex = 0;
            this.lblSell.Text = "Sell";
            this.lblSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBuy.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.ForeColor = System.Drawing.Color.White;
            this.lblBuy.Location = new System.Drawing.Point(134, 0);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(125, 13);
            this.lblBuy.TabIndex = 1;
            this.lblBuy.Text = "Buy";
            this.lblBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForexWidgetCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ForexWidgetCtrl";
            this.Size = new System.Drawing.Size(262, 178);
            this.Load += new System.EventHandler(this.ForexWidgetCtrl_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPair;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
    }
}

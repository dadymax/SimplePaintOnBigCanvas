namespace PaintOnEntireScreen
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
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Draw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.BackColor = System.Drawing.Color.White;
            this.pnl_Draw.Controls.Add(this.label1);
            this.pnl_Draw.Location = new System.Drawing.Point(0, 0);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(5000, 5000);
            this.pnl_Draw.TabIndex = 0;
            this.pnl_Draw.MouseEnter += new System.EventHandler(this.pnl_Draw_MouseEnter);
            this.pnl_Draw.MouseLeave += new System.EventHandler(this.pnl_Draw_MouseLeave);
            this.pnl_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2771, 913);
            this.Controls.Add(this.pnl_Draw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnl_Draw.ResumeLayout(false);
            this.pnl_Draw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.Label label1;
    }
}


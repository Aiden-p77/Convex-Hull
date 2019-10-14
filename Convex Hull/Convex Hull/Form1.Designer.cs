namespace Convex_Hull
{
    partial class fMain
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
            this.pButton = new System.Windows.Forms.Panel();
            this.bClear = new System.Windows.Forms.Button();
            this.cboxCulling = new System.Windows.Forms.CheckBox();
            this.cboxConvex = new System.Windows.Forms.CheckBox();
            this.cboxMin = new System.Windows.Forms.CheckBox();
            this.pButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButton
            // 
            this.pButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pButton.Controls.Add(this.cboxMin);
            this.pButton.Controls.Add(this.cboxConvex);
            this.pButton.Controls.Add(this.cboxCulling);
            this.pButton.Controls.Add(this.bClear);
            this.pButton.Location = new System.Drawing.Point(0, 348);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(743, 54);
            this.pButton.TabIndex = 0;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bClear.Location = new System.Drawing.Point(3, 7);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(101, 38);
            this.bClear.TabIndex = 0;
            this.bClear.Text = "Clear point";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // cboxCulling
            // 
            this.cboxCulling.AutoSize = true;
            this.cboxCulling.Location = new System.Drawing.Point(211, 19);
            this.cboxCulling.Name = "cboxCulling";
            this.cboxCulling.Size = new System.Drawing.Size(77, 17);
            this.cboxCulling.TabIndex = 1;
            this.cboxCulling.Text = "Culling box";
            this.cboxCulling.UseVisualStyleBackColor = true;
            // 
            // cboxConvex
            // 
            this.cboxConvex.AutoSize = true;
            this.cboxConvex.Checked = true;
            this.cboxConvex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxConvex.Location = new System.Drawing.Point(124, 19);
            this.cboxConvex.Name = "cboxConvex";
            this.cboxConvex.Size = new System.Drawing.Size(81, 17);
            this.cboxConvex.TabIndex = 2;
            this.cboxConvex.Text = "Convex hull";
            this.cboxConvex.UseVisualStyleBackColor = true;
            this.cboxConvex.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cboxMin
            // 
            this.cboxMin.AutoSize = true;
            this.cboxMin.Location = new System.Drawing.Point(294, 19);
            this.cboxMin.Name = "cboxMin";
            this.cboxMin.Size = new System.Drawing.Size(125, 17);
            this.cboxMin.TabIndex = 3;
            this.cboxMin.Text = "Min max quadrilateral";
            this.cboxMin.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 402);
            this.Controls.Add(this.pButton);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convex hull program";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fMain_MouseDown);
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.CheckBox cboxMin;
        private System.Windows.Forms.CheckBox cboxConvex;
        private System.Windows.Forms.CheckBox cboxCulling;
    }
}


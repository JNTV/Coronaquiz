namespace Quiz
{
    partial class frmName
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
            this.cmdAbsenden = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdAbsenden
            // 
            this.cmdAbsenden.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdAbsenden.Location = new System.Drawing.Point(235, 12);
            this.cmdAbsenden.Name = "cmdAbsenden";
            this.cmdAbsenden.Size = new System.Drawing.Size(75, 23);
            this.cmdAbsenden.TabIndex = 0;
            this.cmdAbsenden.Text = "Absenden";
            this.cmdAbsenden.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(148, 20);
            this.txtResult.TabIndex = 1;
            // 
            // frmName
            // 
            this.AcceptButton = this.cmdAbsenden;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 48);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cmdAbsenden);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Name eingeben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAbsenden;
        public System.Windows.Forms.TextBox txtResult;
    }
}
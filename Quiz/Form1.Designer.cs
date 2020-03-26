namespace Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFrage = new System.Windows.Forms.Label();
            this.cmdAntwortA = new System.Windows.Forms.Button();
            this.cmdAntwortC = new System.Windows.Forms.Button();
            this.cmdAntwortB = new System.Windows.Forms.Button();
            this.cmdAntwortD = new System.Windows.Forms.Button();
            this.prgZeit = new System.Windows.Forms.ProgressBar();
            this.tmrZeit = new System.Windows.Forms.Timer(this.components);
            this.lblZeit = new System.Windows.Forms.Label();
            this.lvwLeaderboard = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblFrage
            // 
            this.lblFrage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrage.Location = new System.Drawing.Point(97, 51);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(700, 108);
            this.lblFrage.TabIndex = 0;
            this.lblFrage.Text = "Frage";
            this.lblFrage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFrage.Visible = false;
            // 
            // cmdAntwortA
            // 
            this.cmdAntwortA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAntwortA.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAntwortA.Location = new System.Drawing.Point(97, 182);
            this.cmdAntwortA.Name = "cmdAntwortA";
            this.cmdAntwortA.Size = new System.Drawing.Size(340, 151);
            this.cmdAntwortA.TabIndex = 1;
            this.cmdAntwortA.Text = "Antwort A";
            this.cmdAntwortA.UseVisualStyleBackColor = true;
            this.cmdAntwortA.Visible = false;
            // 
            // cmdAntwortC
            // 
            this.cmdAntwortC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAntwortC.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAntwortC.Location = new System.Drawing.Point(97, 350);
            this.cmdAntwortC.Name = "cmdAntwortC";
            this.cmdAntwortC.Size = new System.Drawing.Size(340, 151);
            this.cmdAntwortC.TabIndex = 5;
            this.cmdAntwortC.Text = "Antwort C";
            this.cmdAntwortC.UseVisualStyleBackColor = true;
            this.cmdAntwortC.Visible = false;
            // 
            // cmdAntwortB
            // 
            this.cmdAntwortB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAntwortB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAntwortB.Location = new System.Drawing.Point(457, 182);
            this.cmdAntwortB.Name = "cmdAntwortB";
            this.cmdAntwortB.Size = new System.Drawing.Size(340, 151);
            this.cmdAntwortB.TabIndex = 6;
            this.cmdAntwortB.Text = "Antwort B";
            this.cmdAntwortB.UseVisualStyleBackColor = true;
            this.cmdAntwortB.Visible = false;
            // 
            // cmdAntwortD
            // 
            this.cmdAntwortD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAntwortD.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAntwortD.Location = new System.Drawing.Point(457, 350);
            this.cmdAntwortD.Name = "cmdAntwortD";
            this.cmdAntwortD.Size = new System.Drawing.Size(340, 151);
            this.cmdAntwortD.TabIndex = 7;
            this.cmdAntwortD.Text = "Antwort D";
            this.cmdAntwortD.UseVisualStyleBackColor = true;
            this.cmdAntwortD.Visible = false;
            // 
            // prgZeit
            // 
            this.prgZeit.Location = new System.Drawing.Point(97, 25);
            this.prgZeit.Name = "prgZeit";
            this.prgZeit.Size = new System.Drawing.Size(700, 23);
            this.prgZeit.TabIndex = 8;
            this.prgZeit.Value = 50;
            this.prgZeit.Visible = false;
            // 
            // lblZeit
            // 
            this.lblZeit.BackColor = System.Drawing.Color.Transparent;
            this.lblZeit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblZeit.ForeColor = System.Drawing.Color.Black;
            this.lblZeit.Location = new System.Drawing.Point(97, -1);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(700, 23);
            this.lblZeit.TabIndex = 10;
            this.lblZeit.Text = "Noch 50 Sekunden";
            this.lblZeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblZeit.Visible = false;
            // 
            // lvwLeaderboard
            // 
            this.lvwLeaderboard.HideSelection = false;
            this.lvwLeaderboard.Location = new System.Drawing.Point(12, 507);
            this.lvwLeaderboard.Name = "lvwLeaderboard";
            this.lvwLeaderboard.Size = new System.Drawing.Size(136, 114);
            this.lvwLeaderboard.TabIndex = 11;
            this.lvwLeaderboard.UseCompatibleStateImageBehavior = false;
            this.lvwLeaderboard.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 633);
            this.Controls.Add(this.lvwLeaderboard);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.prgZeit);
            this.Controls.Add(this.cmdAntwortD);
            this.Controls.Add(this.cmdAntwortB);
            this.Controls.Add(this.cmdAntwortC);
            this.Controls.Add(this.cmdAntwortA);
            this.Controls.Add(this.lblFrage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFrage;
        private System.Windows.Forms.Button cmdAntwortA;
        private System.Windows.Forms.Button cmdAntwortC;
        private System.Windows.Forms.Button cmdAntwortB;
        private System.Windows.Forms.Button cmdAntwortD;
        private System.Windows.Forms.ProgressBar prgZeit;
        private System.Windows.Forms.Timer tmrZeit;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.ListView lvwLeaderboard;
    }
}


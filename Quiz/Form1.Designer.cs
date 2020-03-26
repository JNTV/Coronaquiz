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
            this.grbFrage = new System.Windows.Forms.GroupBox();
            this.cmdNeu = new System.Windows.Forms.Button();
            this.grbHauptmenue = new System.Windows.Forms.GroupBox();
            this.cmdLGBTQ = new System.Windows.Forms.Button();
            this.cmdFeminismus = new System.Windows.Forms.Button();
            this.cmdCorona = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Platz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Punktzahl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbFrage.SuspendLayout();
            this.grbHauptmenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrage
            // 
            this.lblFrage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrage.Location = new System.Drawing.Point(85, 74);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(700, 108);
            this.lblFrage.TabIndex = 0;
            this.lblFrage.Text = "Frage";
            this.lblFrage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdAntwortA
            // 
            this.cmdAntwortA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAntwortA.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAntwortA.Location = new System.Drawing.Point(85, 201);
            this.cmdAntwortA.Name = "cmdAntwortA";
            this.cmdAntwortA.Size = new System.Drawing.Size(340, 151);
            this.cmdAntwortA.TabIndex = 1;
            this.cmdAntwortA.Text = "Antwort A";
            this.cmdAntwortA.UseVisualStyleBackColor = true;
            this.cmdAntwortA.Click += new System.EventHandler(this.cmdAntwortA_Click);
            // 
            // cmdAntwortC
            // 
            this.cmdAntwortC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAntwortC.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAntwortC.Location = new System.Drawing.Point(85, 358);
            this.cmdAntwortC.Name = "cmdAntwortC";
            this.cmdAntwortC.Size = new System.Drawing.Size(340, 151);
            this.cmdAntwortC.TabIndex = 5;
            this.cmdAntwortC.Text = "Antwort C";
            this.cmdAntwortC.UseVisualStyleBackColor = true;
            this.cmdAntwortC.Click += new System.EventHandler(this.cmdAntwortC_Click);
            // 
            // cmdAntwortB
            // 
            this.cmdAntwortB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAntwortB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAntwortB.Location = new System.Drawing.Point(445, 201);
            this.cmdAntwortB.Name = "cmdAntwortB";
            this.cmdAntwortB.Size = new System.Drawing.Size(340, 151);
            this.cmdAntwortB.TabIndex = 6;
            this.cmdAntwortB.Text = "Antwort B";
            this.cmdAntwortB.UseVisualStyleBackColor = true;
            this.cmdAntwortB.Click += new System.EventHandler(this.cmdAntwortB_Click);
            // 
            // cmdAntwortD
            // 
            this.cmdAntwortD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAntwortD.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAntwortD.Location = new System.Drawing.Point(445, 358);
            this.cmdAntwortD.Name = "cmdAntwortD";
            this.cmdAntwortD.Size = new System.Drawing.Size(340, 151);
            this.cmdAntwortD.TabIndex = 7;
            this.cmdAntwortD.Text = "Antwort D";
            this.cmdAntwortD.UseVisualStyleBackColor = true;
            this.cmdAntwortD.Click += new System.EventHandler(this.cmdAntwortD_Click);
            // 
            // prgZeit
            // 
            this.prgZeit.Location = new System.Drawing.Point(85, 48);
            this.prgZeit.Name = "prgZeit";
            this.prgZeit.Size = new System.Drawing.Size(700, 23);
            this.prgZeit.TabIndex = 8;
            this.prgZeit.Value = 50;
            // 
            // tmrZeit
            // 
            this.tmrZeit.Interval = 1;
            this.tmrZeit.Tick += new System.EventHandler(this.tmrZeit_Tick);
            // 
            // lblZeit
            // 
            this.lblZeit.BackColor = System.Drawing.Color.Transparent;
            this.lblZeit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblZeit.ForeColor = System.Drawing.Color.Black;
            this.lblZeit.Location = new System.Drawing.Point(82, 16);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(700, 23);
            this.lblZeit.TabIndex = 10;
            this.lblZeit.Text = "Noch 50 Sekunden";
            this.lblZeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwLeaderboard
            // 
            this.lvwLeaderboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Platz,
            this.Name,
            this.Punktzahl});
            this.lvwLeaderboard.HideSelection = false;
            this.lvwLeaderboard.Location = new System.Drawing.Point(6, 515);
            this.lvwLeaderboard.Name = "lvwLeaderboard";
            this.lvwLeaderboard.Size = new System.Drawing.Size(310, 88);
            this.lvwLeaderboard.TabIndex = 11;
            this.lvwLeaderboard.UseCompatibleStateImageBehavior = false;
            this.lvwLeaderboard.View = System.Windows.Forms.View.Details;
            // 
            // grbFrage
            // 
            this.grbFrage.Controls.Add(this.cmdNeu);
            this.grbFrage.Controls.Add(this.lblZeit);
            this.grbFrage.Controls.Add(this.lvwLeaderboard);
            this.grbFrage.Controls.Add(this.prgZeit);
            this.grbFrage.Controls.Add(this.lblFrage);
            this.grbFrage.Controls.Add(this.cmdAntwortA);
            this.grbFrage.Controls.Add(this.cmdAntwortC);
            this.grbFrage.Controls.Add(this.cmdAntwortB);
            this.grbFrage.Controls.Add(this.cmdAntwortD);
            this.grbFrage.Location = new System.Drawing.Point(12, 12);
            this.grbFrage.Name = "grbFrage";
            this.grbFrage.Size = new System.Drawing.Size(895, 609);
            this.grbFrage.TabIndex = 12;
            this.grbFrage.TabStop = false;
            this.grbFrage.Visible = false;
            // 
            // cmdNeu
            // 
            this.cmdNeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNeu.Location = new System.Drawing.Point(743, 554);
            this.cmdNeu.Name = "cmdNeu";
            this.cmdNeu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdNeu.Size = new System.Drawing.Size(146, 49);
            this.cmdNeu.TabIndex = 12;
            this.cmdNeu.Text = "Hauptmenü";
            this.cmdNeu.UseVisualStyleBackColor = true;
            // 
            // grbHauptmenue
            // 
            this.grbHauptmenue.Controls.Add(this.cmdLGBTQ);
            this.grbHauptmenue.Controls.Add(this.cmdFeminismus);
            this.grbHauptmenue.Controls.Add(this.cmdCorona);
            this.grbHauptmenue.Controls.Add(this.label2);
            this.grbHauptmenue.Controls.Add(this.label1);
            this.grbHauptmenue.Location = new System.Drawing.Point(12, 12);
            this.grbHauptmenue.Name = "grbHauptmenue";
            this.grbHauptmenue.Size = new System.Drawing.Size(895, 609);
            this.grbHauptmenue.TabIndex = 13;
            this.grbHauptmenue.TabStop = false;
            // 
            // cmdLGBTQ
            // 
            this.cmdLGBTQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLGBTQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLGBTQ.Location = new System.Drawing.Point(313, 415);
            this.cmdLGBTQ.Name = "cmdLGBTQ";
            this.cmdLGBTQ.Size = new System.Drawing.Size(274, 109);
            this.cmdLGBTQ.TabIndex = 4;
            this.cmdLGBTQ.Text = "LGBTQ*";
            this.cmdLGBTQ.UseVisualStyleBackColor = true;
            this.cmdLGBTQ.Click += new System.EventHandler(this.cmdLGBTQ_Click);
            // 
            // cmdFeminismus
            // 
            this.cmdFeminismus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFeminismus.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFeminismus.Location = new System.Drawing.Point(313, 300);
            this.cmdFeminismus.Name = "cmdFeminismus";
            this.cmdFeminismus.Size = new System.Drawing.Size(274, 109);
            this.cmdFeminismus.TabIndex = 3;
            this.cmdFeminismus.Text = "Feminismus";
            this.cmdFeminismus.UseVisualStyleBackColor = true;
            this.cmdFeminismus.Click += new System.EventHandler(this.cmdFeminismus_Click);
            // 
            // cmdCorona
            // 
            this.cmdCorona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCorona.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCorona.Location = new System.Drawing.Point(313, 185);
            this.cmdCorona.Name = "cmdCorona";
            this.cmdCorona.Size = new System.Drawing.Size(274, 109);
            this.cmdCorona.TabIndex = 2;
            this.cmdCorona.Text = "Corona";
            this.cmdCorona.UseVisualStyleBackColor = true;
            this.cmdCorona.Click += new System.EventHandler(this.cmdCorona_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 109);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welches Thema möchtest du wählen?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Willkommen beim Quiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Platz
            // 
            this.Platz.Text = "Platz";
            this.Platz.Width = 40;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 200;
            // 
            // Punktzahl
            // 
            this.Punktzahl.Text = "Punktzahl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 633);
            this.Controls.Add(this.grbFrage);
            this.Controls.Add(this.grbHauptmenue);
            this.Name.Name = "Form1";
            this.Text = "Form1";
            this.grbFrage.ResumeLayout(false);
            this.grbHauptmenue.ResumeLayout(false);
            this.grbHauptmenue.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbFrage;
        private System.Windows.Forms.GroupBox grbHauptmenue;
        private System.Windows.Forms.Button cmdLGBTQ;
        private System.Windows.Forms.Button cmdFeminismus;
        private System.Windows.Forms.Button cmdCorona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdNeu;
        private System.Windows.Forms.ColumnHeader Platz;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Punktzahl;
    }
}


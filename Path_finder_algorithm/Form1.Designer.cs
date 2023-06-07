namespace Path_finder_algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.find_path = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RESET);
            this.groupBox1.Controls.Add(this.find_path);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Location = new System.Drawing.Point(807, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 683);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // find_path
            // 
            this.find_path.Location = new System.Drawing.Point(13, 101);
            this.find_path.Name = "find_path";
            this.find_path.Size = new System.Drawing.Size(120, 81);
            this.find_path.TabIndex = 1;
            this.find_path.Text = "FIND PATH";
            this.find_path.UseVisualStyleBackColor = true;
            this.find_path.Click += new System.EventHandler(this.find_path_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 25);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(120, 52);
            this.start.TabIndex = 0;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(13, 198);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(120, 83);
            this.RESET.TabIndex = 2;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 790);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button find_path;
        private System.Windows.Forms.Button RESET;
    }
}


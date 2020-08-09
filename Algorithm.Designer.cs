namespace FormApp
{
    partial class Algorithm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Algorithm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAlgorithmText = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.picture_exitbox = new System.Windows.Forms.PictureBox();
            this.txtAlgorithms = new System.Windows.Forms.Label();
            this.btnBacktrack = new System.Windows.Forms.Button();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.txtGrid1 = new System.Windows.Forms.TextBox();
            this.lblGridSize = new System.Windows.Forms.Label();
            this.txtGrid2 = new System.Windows.Forms.TextBox();
            this.btnAstar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_exitbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAlgorithmText
            // 
            this.lblAlgorithmText.AutoSize = true;
            this.lblAlgorithmText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAlgorithmText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlgorithmText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAlgorithmText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithmText.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAlgorithmText.Location = new System.Drawing.Point(144, 27);
            this.lblAlgorithmText.Name = "lblAlgorithmText";
            this.lblAlgorithmText.Size = new System.Drawing.Size(153, 23);
            this.lblAlgorithmText.TabIndex = 1;
            this.lblAlgorithmText.Text = "Algorithm Visualizer";
            this.lblAlgorithmText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlgorithmText.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(165, 50);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(98, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Created by Alex Hill";
            // 
            // picture_exitbox
            // 
            this.picture_exitbox.Image = ((System.Drawing.Image)(resources.GetObject("picture_exitbox.Image")));
            this.picture_exitbox.Location = new System.Drawing.Point(356, -2);
            this.picture_exitbox.Name = "picture_exitbox";
            this.picture_exitbox.Size = new System.Drawing.Size(31, 28);
            this.picture_exitbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_exitbox.TabIndex = 3;
            this.picture_exitbox.TabStop = false;
            this.picture_exitbox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtAlgorithms
            // 
            this.txtAlgorithms.AutoSize = true;
            this.txtAlgorithms.BackColor = System.Drawing.Color.Violet;
            this.txtAlgorithms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlgorithms.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlgorithms.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtAlgorithms.Location = new System.Drawing.Point(8, 188);
            this.txtAlgorithms.Name = "txtAlgorithms";
            this.txtAlgorithms.Size = new System.Drawing.Size(104, 25);
            this.txtAlgorithms.TabIndex = 4;
            this.txtAlgorithms.Text = "Algorithms";
            this.txtAlgorithms.Click += new System.EventHandler(this.txtAlgorithms_Click);
            // 
            // btnBacktrack
            // 
            this.btnBacktrack.BackColor = System.Drawing.Color.Crimson;
            this.btnBacktrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBacktrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBacktrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktrack.ForeColor = System.Drawing.Color.White;
            this.btnBacktrack.Location = new System.Drawing.Point(40, 277);
            this.btnBacktrack.Name = "btnBacktrack";
            this.btnBacktrack.Size = new System.Drawing.Size(115, 38);
            this.btnBacktrack.TabIndex = 5;
            this.btnBacktrack.Text = "Backtrack";
            this.btnBacktrack.UseVisualStyleBackColor = false;
            this.btnBacktrack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.BackColor = System.Drawing.Color.DimGray;
            this.btnDijkstra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDijkstra.ForeColor = System.Drawing.Color.White;
            this.btnDijkstra.Location = new System.Drawing.Point(215, 277);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(115, 38);
            this.btnDijkstra.TabIndex = 6;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = false;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // txtGrid1
            // 
            this.txtGrid1.Location = new System.Drawing.Point(119, 228);
            this.txtGrid1.Name = "txtGrid1";
            this.txtGrid1.Size = new System.Drawing.Size(23, 20);
            this.txtGrid1.TabIndex = 7;
            this.txtGrid1.TextChanged += new System.EventHandler(this.txtGrid1_TextChanged);
            // 
            // lblGridSize
            // 
            this.lblGridSize.AutoSize = true;
            this.lblGridSize.Location = new System.Drawing.Point(9, 231);
            this.lblGridSize.Name = "lblGridSize";
            this.lblGridSize.Size = new System.Drawing.Size(110, 13);
            this.lblGridSize.TabIndex = 10;
            this.lblGridSize.Text = "Grid Size (Max 50x50)";
            // 
            // txtGrid2
            // 
            this.txtGrid2.Location = new System.Drawing.Point(148, 228);
            this.txtGrid2.Name = "txtGrid2";
            this.txtGrid2.Size = new System.Drawing.Size(23, 20);
            this.txtGrid2.TabIndex = 11;
            this.txtGrid2.TextChanged += new System.EventHandler(this.txtGrid2_TextChanged);
            // 
            // btnAstar
            // 
            this.btnAstar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAstar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAstar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAstar.ForeColor = System.Drawing.Color.White;
            this.btnAstar.Location = new System.Drawing.Point(128, 348);
            this.btnAstar.Name = "btnAstar";
            this.btnAstar.Size = new System.Drawing.Size(115, 38);
            this.btnAstar.TabIndex = 12;
            this.btnAstar.Text = "A*";
            this.btnAstar.UseVisualStyleBackColor = false;
            this.btnAstar.Click += new System.EventHandler(this.btnAstar_Click);
            // 
            // Algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.btnAstar);
            this.Controls.Add(this.txtGrid2);
            this.Controls.Add(this.lblGridSize);
            this.Controls.Add(this.txtGrid1);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.btnBacktrack);
            this.Controls.Add(this.txtAlgorithms);
            this.Controls.Add(this.picture_exitbox);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblAlgorithmText);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Algorithm";
            this.Text = "Algorithm Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_exitbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAlgorithmText;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.PictureBox picture_exitbox;
        private System.Windows.Forms.Label txtAlgorithms;
        private System.Windows.Forms.Button btnBacktrack;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.TextBox txtGrid1;
        private System.Windows.Forms.Label lblGridSize;
        private System.Windows.Forms.TextBox txtGrid2;
        private System.Windows.Forms.Button btnAstar;
    }
}


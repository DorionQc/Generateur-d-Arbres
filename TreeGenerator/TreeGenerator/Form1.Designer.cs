namespace TreeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numAngle = new System.Windows.Forms.NumericUpDown();
            this.numBranchAngle = new System.Windows.Forms.NumericUpDown();
            this.numBranchNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelXY = new TreeGenerator.OptPanel();
            this.panelZY = new TreeGenerator.OptPanel();
            this.panelXZ = new TreeGenerator.OptPanel();
            this.cbDoubleBuffer = new System.Windows.Forms.CheckBox();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numZ = new System.Windows.Forms.NumericUpDown();
            this.cbCouleur = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBranchAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBranchNumber)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).BeginInit();
            this.SuspendLayout();
            // 
            // numHeight
            // 
            this.numHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numHeight.Location = new System.Drawing.Point(968, 12);
            this.numHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 20);
            this.numHeight.TabIndex = 1;
            this.numHeight.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // numWidth
            // 
            this.numWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numWidth.Location = new System.Drawing.Point(968, 38);
            this.numWidth.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 20);
            this.numWidth.TabIndex = 2;
            this.numWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numAngle
            // 
            this.numAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numAngle.Location = new System.Drawing.Point(968, 64);
            this.numAngle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numAngle.Name = "numAngle";
            this.numAngle.Size = new System.Drawing.Size(120, 20);
            this.numAngle.TabIndex = 3;
            this.numAngle.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numBranchAngle
            // 
            this.numBranchAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numBranchAngle.Location = new System.Drawing.Point(968, 90);
            this.numBranchAngle.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numBranchAngle.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numBranchAngle.Name = "numBranchAngle";
            this.numBranchAngle.Size = new System.Drawing.Size(120, 20);
            this.numBranchAngle.TabIndex = 4;
            this.numBranchAngle.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numBranchNumber
            // 
            this.numBranchNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numBranchNumber.Location = new System.Drawing.Point(968, 116);
            this.numBranchNumber.Name = "numBranchNumber";
            this.numBranchNumber.Size = new System.Drawing.Size(120, 20);
            this.numBranchNumber.TabIndex = 5;
            this.numBranchNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1094, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1094, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1094, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MaxAngle";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1094, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "AverageAngleBranch";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1094, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Branches";
            // 
            // btnDraw
            // 
            this.btnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDraw.Location = new System.Drawing.Point(968, 142);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 13;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "XY - FRONT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(318, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "XZ - TOP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(641, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "ZY - SIDE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelXY, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelZY, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelXZ, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 356);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panelXY
            // 
            this.panelXY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelXY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelXY.DoubleBuffered = true;
            this.panelXY.Location = new System.Drawing.Point(6, 6);
            this.panelXY.Margin = new System.Windows.Forms.Padding(5);
            this.panelXY.Name = "panelXY";
            this.panelXY.Size = new System.Drawing.Size(303, 325);
            this.panelXY.TabIndex = 0;
            this.panelXY.Paint += new System.Windows.Forms.PaintEventHandler(this.panelXY_Paint);
            // 
            // panelZY
            // 
            this.panelZY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelZY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZY.DoubleBuffered = true;
            this.panelZY.Location = new System.Drawing.Point(643, 6);
            this.panelZY.Margin = new System.Windows.Forms.Padding(5);
            this.panelZY.Name = "panelZY";
            this.panelZY.Size = new System.Drawing.Size(304, 325);
            this.panelZY.TabIndex = 2;
            this.panelZY.Paint += new System.Windows.Forms.PaintEventHandler(this.panelZY_Paint);
            // 
            // panelXZ
            // 
            this.panelXZ.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelXZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelXZ.DoubleBuffered = true;
            this.panelXZ.Location = new System.Drawing.Point(320, 6);
            this.panelXZ.Margin = new System.Windows.Forms.Padding(5);
            this.panelXZ.Name = "panelXZ";
            this.panelXZ.Size = new System.Drawing.Size(312, 325);
            this.panelXZ.TabIndex = 1;
            this.panelXZ.Paint += new System.Windows.Forms.PaintEventHandler(this.panelXZ_Paint);
            // 
            // cbDoubleBuffer
            // 
            this.cbDoubleBuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDoubleBuffer.AutoSize = true;
            this.cbDoubleBuffer.Checked = true;
            this.cbDoubleBuffer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDoubleBuffer.Location = new System.Drawing.Point(968, 171);
            this.cbDoubleBuffer.Name = "cbDoubleBuffer";
            this.cbDoubleBuffer.Size = new System.Drawing.Size(100, 17);
            this.cbDoubleBuffer.TabIndex = 20;
            this.cbDoubleBuffer.Text = "DoubleBuffered";
            this.cbDoubleBuffer.UseVisualStyleBackColor = true;
            this.cbDoubleBuffer.CheckedChanged += new System.EventHandler(this.cbDoubleBuffer_CheckedChanged);
            // 
            // numX
            // 
            this.numX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numX.Location = new System.Drawing.Point(968, 194);
            this.numX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(53, 20);
            this.numX.TabIndex = 21;
            this.numX.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numY
            // 
            this.numY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numY.Location = new System.Drawing.Point(1027, 194);
            this.numY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(53, 20);
            this.numY.TabIndex = 22;
            this.numY.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numZ
            // 
            this.numZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numZ.Location = new System.Drawing.Point(1086, 194);
            this.numZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numZ.Name = "numZ";
            this.numZ.Size = new System.Drawing.Size(53, 20);
            this.numZ.TabIndex = 23;
            this.numZ.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // cbCouleur
            // 
            this.cbCouleur.AutoSize = true;
            this.cbCouleur.Location = new System.Drawing.Point(968, 220);
            this.cbCouleur.Name = "cbCouleur";
            this.cbCouleur.Size = new System.Drawing.Size(62, 17);
            this.cbCouleur.TabIndex = 24;
            this.cbCouleur.Text = "Couleur";
            this.cbCouleur.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 438);
            this.Controls.Add(this.cbCouleur);
            this.Controls.Add(this.numZ);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.cbDoubleBuffer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numBranchNumber);
            this.Controls.Add(this.numBranchAngle);
            this.Controls.Add(this.numAngle);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.numHeight);
            this.Name = "Form1";
            this.Text = "Tree Generator";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBranchAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBranchNumber)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OptPanel panelXY;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numAngle;
        private System.Windows.Forms.NumericUpDown numBranchAngle;
        private System.Windows.Forms.NumericUpDown numBranchNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDraw;
        private OptPanel panelXZ;
        private OptPanel panelZY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cbDoubleBuffer;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numZ;
        private System.Windows.Forms.CheckBox cbCouleur;
    }
}


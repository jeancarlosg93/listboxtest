namespace listboxtest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listSelection = new ListBox();
            comboBox1 = new ComboBox();
            lblName = new Label();
            groupBox1 = new GroupBox();
            listNutritionInfo = new ListBox();
            lblIngredient = new Label();
            pictureBox1 = new PictureBox();
            txtNutritionInfo = new Label();
            listIngredient = new ListBox();
            txtDescription = new TextBox();
            btnclearfilter = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listSelection
            // 
            listSelection.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listSelection.ForeColor = SystemColors.ActiveCaptionText;
            listSelection.FormattingEnabled = true;
            listSelection.HorizontalScrollbar = true;
            listSelection.ItemHeight = 41;
            listSelection.Location = new Point(22, 147);
            listSelection.Margin = new Padding(6, 6, 6, 6);
            listSelection.Name = "listSelection";
            listSelection.Size = new Size(509, 947);
            listSelection.TabIndex = 0;
            listSelection.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.Location = new Point(22, 43);
            comboBox1.Margin = new Padding(6, 6, 6, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(359, 53);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(24, 38);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(108, 45);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listNutritionInfo);
            groupBox1.Controls.Add(lblIngredient);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtNutritionInfo);
            groupBox1.Controls.Add(listIngredient);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new Point(559, 23);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(1077, 1114);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // listNutritionInfo
            // 
            listNutritionInfo.BackColor = SystemColors.ButtonFace;
            listNutritionInfo.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listNutritionInfo.ForeColor = SystemColors.ActiveCaptionText;
            listNutritionInfo.FormattingEnabled = true;
            listNutritionInfo.ItemHeight = 41;
            listNutritionInfo.Location = new Point(643, 549);
            listNutritionInfo.Margin = new Padding(6, 6, 6, 6);
            listNutritionInfo.Name = "listNutritionInfo";
            listNutritionInfo.Size = new Size(413, 168);
            listNutritionInfo.TabIndex = 10;
            // 
            // lblIngredient
            // 
            lblIngredient.AutoSize = true;
            lblIngredient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIngredient.Location = new Point(24, 442);
            lblIngredient.Margin = new Padding(4, 0, 4, 0);
            lblIngredient.Name = "lblIngredient";
            lblIngredient.Size = new Size(190, 45);
            lblIngredient.TabIndex = 9;
            lblIngredient.Text = "Ingredients";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(643, 38);
            pictureBox1.Margin = new Padding(6, 6, 6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 416);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtNutritionInfo
            // 
            txtNutritionInfo.AutoSize = true;
            txtNutritionInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNutritionInfo.Location = new Point(643, 498);
            txtNutritionInfo.Margin = new Padding(4, 0, 4, 0);
            txtNutritionInfo.Name = "txtNutritionInfo";
            txtNutritionInfo.Size = new Size(347, 45);
            txtNutritionInfo.TabIndex = 7;
            txtNutritionInfo.Text = "Nutrition Information";
            // 
            // listIngredient
            // 
            listIngredient.BackColor = SystemColors.ButtonFace;
            listIngredient.BorderStyle = BorderStyle.None;
            listIngredient.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listIngredient.ForeColor = SystemColors.ActiveCaptionText;
            listIngredient.FormattingEnabled = true;
            listIngredient.ItemHeight = 41;
            listIngredient.Location = new Point(24, 489);
            listIngredient.Margin = new Padding(6, 6, 6, 6);
            listIngredient.Name = "listIngredient";
            listIngredient.Size = new Size(607, 533);
            listIngredient.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ButtonFace;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(24, 87);
            txtDescription.Margin = new Padding(4, 4, 4, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(607, 337);
            txtDescription.TabIndex = 3;
            // 
            // btnclearfilter
            // 
            btnclearfilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclearfilter.Location = new Point(396, 43);
            btnclearfilter.Margin = new Padding(6, 6, 6, 6);
            btnclearfilter.Name = "btnclearfilter";
            btnclearfilter.Size = new Size(139, 64);
            btnclearfilter.TabIndex = 5;
            btnclearfilter.Text = "Clear";
            btnclearfilter.UseVisualStyleBackColor = true;
            btnclearfilter.Click += btnclearfilter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1658, 1175);
            Controls.Add(btnclearfilter);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(listSelection);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listSelection;
        private ComboBox comboBox1;
        private Label lblName;
        private GroupBox groupBox1;
        private TextBox txtDescription;
        private ListBox listIngredient;
        private Label txtNutritionInfo;
        private PictureBox pictureBox1;
        private Label lblIngredient;
        private ListBox listNutritionInfo;
        private Button btnclearfilter;
    }
}

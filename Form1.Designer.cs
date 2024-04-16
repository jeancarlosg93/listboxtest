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
            lblIngredient = new Label();
            pictureBox1 = new PictureBox();
            txtNutritionInfo = new Label();
            listIngredient = new ListBox();
            txtDescription = new TextBox();
            listNutritionInfo = new ListBox();
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
            listSelection.ItemHeight = 20;
            listSelection.Location = new Point(12, 49);
            listSelection.Name = "listSelection";
            listSelection.Size = new Size(276, 484);
            listSelection.TabIndex = 0;
            listSelection.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(12, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(276, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(13, 24);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
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
            groupBox1.Location = new Point(301, 44);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(402, 496);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // lblIngredient
            // 
            lblIngredient.AutoSize = true;
            lblIngredient.Location = new Point(13, 211);
            lblIngredient.Margin = new Padding(2, 0, 2, 0);
            lblIngredient.Name = "lblIngredient";
            lblIngredient.Size = new Size(66, 15);
            lblIngredient.TabIndex = 9;
            lblIngredient.Text = "Ingredients";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(221, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 158);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtNutritionInfo
            // 
            txtNutritionInfo.AutoSize = true;
            txtNutritionInfo.Location = new Point(221, 211);
            txtNutritionInfo.Margin = new Padding(2, 0, 2, 0);
            txtNutritionInfo.Name = "txtNutritionInfo";
            txtNutritionInfo.Size = new Size(121, 15);
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
            listIngredient.ItemHeight = 20;
            listIngredient.Location = new Point(13, 229);
            listIngredient.Name = "listIngredient";
            listIngredient.Size = new Size(194, 260);
            listIngredient.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ButtonFace;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(13, 41);
            txtDescription.Margin = new Padding(2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 158);
            txtDescription.TabIndex = 3;
            // 
            // listNutritionInfo
            // 
            listNutritionInfo.BackColor = SystemColors.ButtonFace;
            listNutritionInfo.BorderStyle = BorderStyle.None;
            listNutritionInfo.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listNutritionInfo.ForeColor = SystemColors.ActiveCaptionText;
            listNutritionInfo.FormattingEnabled = true;
            listNutritionInfo.ItemHeight = 20;
            listNutritionInfo.Location = new Point(221, 231);
            listNutritionInfo.Name = "listNutritionInfo";
            listNutritionInfo.Size = new Size(168, 260);
            listNutritionInfo.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 551);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(listSelection);
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
    }
}

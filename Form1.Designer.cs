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
            pictureBox1 = new PictureBox();
            btnclearfilter = new Button();
            NameBox = new GroupBox();
            txtDescription = new TextBox();
            boxIngredients = new GroupBox();
            listIngredient = new ListBox();
            boxInstructions = new GroupBox();
            txtPreparation = new TextBox();
            groupBox1 = new GroupBox();
            listNutritionInfo = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NameBox.SuspendLayout();
            boxIngredients.SuspendLayout();
            boxInstructions.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listSelection
            // 
            listSelection.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listSelection.ForeColor = SystemColors.ActiveCaptionText;
            listSelection.FormattingEnabled = true;
            listSelection.HorizontalScrollbar = true;
            listSelection.ItemHeight = 20;
            listSelection.Location = new Point(12, 69);
            listSelection.Name = "listSelection";
            listSelection.Size = new Size(276, 644);
            listSelection.TabIndex = 0;
            listSelection.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.Location = new Point(12, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 29);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(1049, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnclearfilter
            // 
            btnclearfilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclearfilter.Location = new Point(213, 20);
            btnclearfilter.Name = "btnclearfilter";
            btnclearfilter.Size = new Size(75, 30);
            btnclearfilter.TabIndex = 5;
            btnclearfilter.Text = "Clear";
            btnclearfilter.UseVisualStyleBackColor = true;
            btnclearfilter.Click += btnclearfilter_Click;
            // 
            // NameBox
            // 
            NameBox.Controls.Add(txtDescription);
            NameBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameBox.Location = new Point(301, 10);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(368, 246);
            NameBox.TabIndex = 12;
            NameBox.TabStop = false;
            NameBox.Text = "Name";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ButtonFace;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = SystemColors.WindowText;
            txtDescription.Location = new Point(8, 27);
            txtDescription.Margin = new Padding(2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(355, 207);
            txtDescription.TabIndex = 4;
            // 
            // boxIngredients
            // 
            boxIngredients.Controls.Add(listIngredient);
            boxIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxIngredients.Location = new Point(301, 262);
            boxIngredients.Name = "boxIngredients";
            boxIngredients.Size = new Size(368, 457);
            boxIngredients.TabIndex = 13;
            boxIngredients.TabStop = false;
            boxIngredients.Text = "Ingredients";
            // 
            // listIngredient
            // 
            listIngredient.BackColor = SystemColors.ButtonFace;
            listIngredient.BorderStyle = BorderStyle.None;
            listIngredient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listIngredient.ForeColor = SystemColors.ActiveCaptionText;
            listIngredient.FormattingEnabled = true;
            listIngredient.ItemHeight = 21;
            listIngredient.Location = new Point(8, 26);
            listIngredient.Name = "listIngredient";
            listIngredient.Size = new Size(346, 420);
            listIngredient.TabIndex = 6;
            // 
            // boxInstructions
            // 
            boxInstructions.Controls.Add(txtPreparation);
            boxInstructions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxInstructions.Location = new Point(675, 10);
            boxInstructions.Name = "boxInstructions";
            boxInstructions.Size = new Size(368, 709);
            boxInstructions.TabIndex = 13;
            boxInstructions.TabStop = false;
            boxInstructions.Text = "Preparation";
            // 
            // txtPreparation
            // 
            txtPreparation.BackColor = SystemColors.Control;
            txtPreparation.BorderStyle = BorderStyle.None;
            txtPreparation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPreparation.Location = new Point(6, 24);
            txtPreparation.Multiline = true;
            txtPreparation.Name = "txtPreparation";
            txtPreparation.Size = new Size(356, 674);
            txtPreparation.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listNutritionInfo);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1049, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 157);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Food Facts";
            // 
            // listNutritionInfo
            // 
            listNutritionInfo.BackColor = SystemColors.ButtonFace;
            listNutritionInfo.BorderStyle = BorderStyle.None;
            listNutritionInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listNutritionInfo.ForeColor = SystemColors.ActiveCaptionText;
            listNutritionInfo.FormattingEnabled = true;
            listNutritionInfo.ItemHeight = 21;
            listNutritionInfo.Location = new Point(6, 28);
            listNutritionInfo.Name = "listNutritionInfo";
            listNutritionInfo.Size = new Size(212, 84);
            listNutritionInfo.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1055, 689);
            button1.Name = "button1";
            button1.Size = new Size(218, 30);
            button1.TabIndex = 15;
            button1.Text = "About";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 727);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(boxInstructions);
            Controls.Add(boxIngredients);
            Controls.Add(btnclearfilter);
            Controls.Add(comboBox1);
            Controls.Add(listSelection);
            Controls.Add(pictureBox1);
            Controls.Add(NameBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            NameBox.ResumeLayout(false);
            NameBox.PerformLayout();
            boxIngredients.ResumeLayout(false);
            boxInstructions.ResumeLayout(false);
            boxInstructions.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listSelection;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button btnclearfilter;
        private GroupBox NameBox;
        private GroupBox boxIngredients;
        private ListBox listIngredient;
        private GroupBox boxInstructions;
        private GroupBox groupBox1;
        private ListBox listNutritionInfo;
        private TextBox txtDescription;
        private Button button1;
        private TextBox txtPreparation;
    }
}

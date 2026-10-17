namespace Practical7_Ustych
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
            labelTitle = new Label();
            checkBoxTea = new CheckBox();
            groupBoxTea = new GroupBox();
            radioButtonBlackTea = new RadioButton();
            radioButtonGreenTea = new RadioButton();
            checkBoxCoffee = new CheckBox();
            checkBoxPizza = new CheckBox();
            groupBoxPizza = new GroupBox();
            checkBoxCheese = new CheckBox();
            checkBoxMushrooms = new CheckBox();
            checkBoxChicken = new CheckBox();
            checkBoxSalad = new CheckBox();
            checkBoxDiscount = new CheckBox();
            labelTotal = new Label();
            lblTotal = new Label();
            pictureBoxDish = new PictureBox();
            groupBoxTea.SuspendLayout();
            groupBoxPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDish).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(255, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(145, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "МЕНЮ КАФЕ";
            // 
            // checkBoxTea
            // 
            checkBoxTea.AutoSize = true;
            checkBoxTea.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBoxTea.Location = new Point(47, 74);
            checkBoxTea.Name = "checkBoxTea";
            checkBoxTea.Size = new Size(125, 25);
            checkBoxTea.TabIndex = 1;
            checkBoxTea.Text = "Чай – 40 грн";
            checkBoxTea.UseVisualStyleBackColor = true;
            checkBoxTea.CheckedChanged += checkBoxTea_CheckedChanged;
            // 
            // groupBoxTea
            // 
            groupBoxTea.Controls.Add(radioButtonGreenTea);
            groupBoxTea.Controls.Add(radioButtonBlackTea);
            groupBoxTea.Enabled = false;
            groupBoxTea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxTea.Location = new Point(47, 105);
            groupBoxTea.Name = "groupBoxTea";
            groupBoxTea.Size = new Size(177, 100);
            groupBoxTea.TabIndex = 2;
            groupBoxTea.TabStop = false;
            groupBoxTea.Text = "Вид чаю";
            // 
            // radioButtonBlackTea
            // 
            radioButtonBlackTea.AutoSize = true;
            radioButtonBlackTea.Checked = true;
            radioButtonBlackTea.Location = new Point(31, 28);
            radioButtonBlackTea.Name = "radioButtonBlackTea";
            radioButtonBlackTea.Size = new Size(114, 25);
            radioButtonBlackTea.TabIndex = 0;
            radioButtonBlackTea.TabStop = true;
            radioButtonBlackTea.Text = "Чорний чай";
            radioButtonBlackTea.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreenTea
            // 
            radioButtonGreenTea.AutoSize = true;
            radioButtonGreenTea.Location = new Point(31, 59);
            radioButtonGreenTea.Name = "radioButtonGreenTea";
            radioButtonGreenTea.Size = new Size(118, 25);
            radioButtonGreenTea.TabIndex = 1;
            radioButtonGreenTea.Text = "Зелений чай";
            radioButtonGreenTea.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoffee
            // 
            checkBoxCoffee.AutoSize = true;
            checkBoxCoffee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBoxCoffee.Location = new Point(295, 74);
            checkBoxCoffee.Name = "checkBoxCoffee";
            checkBoxCoffee.Size = new Size(131, 25);
            checkBoxCoffee.TabIndex = 3;
            checkBoxCoffee.Text = "Кава – 60 грн";
            checkBoxCoffee.UseVisualStyleBackColor = true;
            checkBoxCoffee.CheckedChanged += checkBoxCoffee_CheckedChanged;
            // 
            // checkBoxPizza
            // 
            checkBoxPizza.AutoSize = true;
            checkBoxPizza.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBoxPizza.Location = new Point(47, 228);
            checkBoxPizza.Name = "checkBoxPizza";
            checkBoxPizza.Size = new Size(139, 25);
            checkBoxPizza.TabIndex = 4;
            checkBoxPizza.Text = "Піца – 120 грн";
            checkBoxPizza.UseVisualStyleBackColor = true;
            // 
            // groupBoxPizza
            // 
            groupBoxPizza.Controls.Add(checkBoxChicken);
            groupBoxPizza.Controls.Add(checkBoxMushrooms);
            groupBoxPizza.Controls.Add(checkBoxCheese);
            groupBoxPizza.Enabled = false;
            groupBoxPizza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxPizza.Location = new Point(47, 269);
            groupBoxPizza.Name = "groupBoxPizza";
            groupBoxPizza.Size = new Size(175, 126);
            groupBoxPizza.TabIndex = 5;
            groupBoxPizza.TabStop = false;
            groupBoxPizza.Text = "Начинка піци";
            // 
            // checkBoxCheese
            // 
            checkBoxCheese.AutoSize = true;
            checkBoxCheese.Location = new Point(21, 28);
            checkBoxCheese.Name = "checkBoxCheese";
            checkBoxCheese.Size = new Size(118, 25);
            checkBoxCheese.TabIndex = 0;
            checkBoxCheese.Text = "Сир +20 грн";
            checkBoxCheese.UseVisualStyleBackColor = true;
            // 
            // checkBoxMushrooms
            // 
            checkBoxMushrooms.AutoSize = true;
            checkBoxMushrooms.Location = new Point(21, 59);
            checkBoxMushrooms.Name = "checkBoxMushrooms";
            checkBoxMushrooms.Size = new Size(134, 25);
            checkBoxMushrooms.TabIndex = 1;
            checkBoxMushrooms.Text = "Гриби +25 грн";
            checkBoxMushrooms.UseVisualStyleBackColor = true;
            // 
            // checkBoxChicken
            // 
            checkBoxChicken.AutoSize = true;
            checkBoxChicken.Location = new Point(21, 90);
            checkBoxChicken.Name = "checkBoxChicken";
            checkBoxChicken.Size = new Size(132, 25);
            checkBoxChicken.TabIndex = 2;
            checkBoxChicken.Text = "Курка +35 грн";
            checkBoxChicken.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalad
            // 
            checkBoxSalad.AutoSize = true;
            checkBoxSalad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBoxSalad.Location = new Point(295, 228);
            checkBoxSalad.Name = "checkBoxSalad";
            checkBoxSalad.Size = new Size(139, 25);
            checkBoxSalad.TabIndex = 6;
            checkBoxSalad.Text = "Салат – 80 грн";
            checkBoxSalad.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiscount
            // 
            checkBoxDiscount.AutoSize = true;
            checkBoxDiscount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBoxDiscount.Location = new Point(295, 370);
            checkBoxDiscount.Name = "checkBoxDiscount";
            checkBoxDiscount.Size = new Size(126, 25);
            checkBoxDiscount.TabIndex = 7;
            checkBoxDiscount.Text = "Знижка 10%";
            checkBoxDiscount.UseVisualStyleBackColor = true;
            checkBoxDiscount.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTotal.Location = new Point(179, 768);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(202, 25);
            labelTotal.TabIndex = 8;
            labelTotal.Text = "Загальна сума: 0 грн";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotal.Location = new Point(217, 454);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(223, 30);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Загальна сума: 0 грн";
            // 
            // pictureBoxDish
            // 
            pictureBoxDish.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxDish.Location = new Point(473, 328);
            pictureBoxDish.Name = "pictureBoxDish";
            pictureBoxDish.Size = new Size(180, 150);
            pictureBoxDish.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDish.TabIndex = 10;
            pictureBoxDish.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 511);
            Controls.Add(pictureBoxDish);
            Controls.Add(lblTotal);
            Controls.Add(labelTotal);
            Controls.Add(checkBoxDiscount);
            Controls.Add(checkBoxSalad);
            Controls.Add(groupBoxPizza);
            Controls.Add(checkBoxPizza);
            Controls.Add(checkBoxCoffee);
            Controls.Add(groupBoxTea);
            Controls.Add(checkBoxTea);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Замовлення в кафе";
            Load += Form1_Load;
            groupBoxTea.ResumeLayout(false);
            groupBoxTea.PerformLayout();
            groupBoxPizza.ResumeLayout(false);
            groupBoxPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDish).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private CheckBox checkBoxTea;
        private GroupBox groupBoxTea;
        private RadioButton radioButtonGreenTea;
        private RadioButton radioButtonBlackTea;
        private CheckBox checkBoxCoffee;
        private CheckBox checkBoxPizza;
        private GroupBox groupBoxPizza;
        private CheckBox checkBoxChicken;
        private CheckBox checkBoxMushrooms;
        private CheckBox checkBoxCheese;
        private CheckBox checkBoxSalad;
        private CheckBox checkBoxDiscount;
        private Label labelTotal;
        private Label lblTotal;
        private PictureBox pictureBoxDish;
    }
}

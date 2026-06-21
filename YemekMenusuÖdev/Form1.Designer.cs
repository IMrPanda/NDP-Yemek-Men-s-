namespace YemekMenusuÖdev
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
            FoodSelectLabel = new Label();
            NameLabel = new Label();
            TypeLabel = new Label();
            PriceLabel = new Label();
            KDVLabel = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            AddMenuButton = new Button();
            OrdersListBox = new ListBox();
            CalorieLabel = new Label();
            textBox5 = new TextBox();
            OrdersLabel = new Label();
            TotalLabel = new TextBox();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // FoodSelectLabel
            // 
            FoodSelectLabel.AutoSize = true;
            FoodSelectLabel.Font = new Font("Segoe UI", 20F);
            FoodSelectLabel.Location = new Point(32, 57);
            FoodSelectLabel.Margin = new Padding(6, 0, 6, 0);
            FoodSelectLabel.Name = "FoodSelectLabel";
            FoodSelectLabel.Size = new Size(155, 37);
            FoodSelectLabel.TabIndex = 0;
            FoodSelectLabel.Text = "Select Food";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 20F);
            NameLabel.Location = new Point(43, 152);
            NameLabel.Margin = new Padding(6, 0, 6, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(88, 37);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 20F);
            TypeLabel.Location = new Point(43, 234);
            TypeLabel.Margin = new Padding(6, 0, 6, 0);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(73, 37);
            TypeLabel.TabIndex = 2;
            TypeLabel.Text = "Type";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 20F);
            PriceLabel.Location = new Point(43, 332);
            PriceLabel.Margin = new Padding(6, 0, 6, 0);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(74, 37);
            PriceLabel.TabIndex = 3;
            PriceLabel.Text = "Price";
            // 
            // KDVLabel
            // 
            KDVLabel.AutoSize = true;
            KDVLabel.Font = new Font("Segoe UI", 20F);
            KDVLabel.Location = new Point(48, 434);
            KDVLabel.Margin = new Padding(6, 0, 6, 0);
            KDVLabel.Name = "KDVLabel";
            KDVLabel.Size = new Size(68, 37);
            KDVLabel.TabIndex = 4;
            KDVLabel.Text = "KDV";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Fruit", "Salad", "Dessert", "Drinks" });
            comboBox1.Location = new Point(224, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(321, 45);
            comboBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 43);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 43);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 332);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(321, 43);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 434);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(321, 43);
            textBox4.TabIndex = 9;
            // 
            // AddMenuButton
            // 
            AddMenuButton.Location = new Point(359, 601);
            AddMenuButton.Name = "AddMenuButton";
            AddMenuButton.Size = new Size(186, 50);
            AddMenuButton.TabIndex = 10;
            AddMenuButton.Text = "Add to Menu";
            AddMenuButton.UseVisualStyleBackColor = true;
            AddMenuButton.Click += AddMenuButton_Click;
            // 
            // OrdersListBox
            // 
            OrdersListBox.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            OrdersListBox.FormattingEnabled = true;
            OrdersListBox.Location = new Point(615, 72);
            OrdersListBox.Name = "OrdersListBox";
            OrdersListBox.Size = new Size(926, 364);
            OrdersListBox.TabIndex = 11;
            // 
            // CalorieLabel
            // 
            CalorieLabel.AutoSize = true;
            CalorieLabel.Font = new Font("Segoe UI", 20F);
            CalorieLabel.Location = new Point(43, 521);
            CalorieLabel.Margin = new Padding(6, 0, 6, 0);
            CalorieLabel.Name = "CalorieLabel";
            CalorieLabel.Size = new Size(101, 37);
            CalorieLabel.TabIndex = 12;
            CalorieLabel.Text = "Calorie";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(224, 521);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(321, 43);
            textBox5.TabIndex = 13;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI", 20F);
            OrdersLabel.Location = new Point(615, 32);
            OrdersLabel.Margin = new Padding(6, 0, 6, 0);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(156, 37);
            OrdersLabel.TabIndex = 14;
            OrdersLabel.Text = "Your Orders";
            // 
            // TotalLabel
            // 
            TotalLabel.Location = new Point(615, 489);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(926, 43);
            TotalLabel.TabIndex = 15;
            TotalLabel.Text = "Toplam Tutar: 0,00 ₺";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(615, 601);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(244, 50);
            ClearButton.TabIndex = 16;
            ClearButton.Text = "Clear the Selected";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1553, 692);
            Controls.Add(ClearButton);
            Controls.Add(TotalLabel);
            Controls.Add(OrdersLabel);
            Controls.Add(textBox5);
            Controls.Add(CalorieLabel);
            Controls.Add(OrdersListBox);
            Controls.Add(AddMenuButton);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(KDVLabel);
            Controls.Add(PriceLabel);
            Controls.Add(TypeLabel);
            Controls.Add(NameLabel);
            Controls.Add(FoodSelectLabel);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FoodSelectLabel;
        private Label NameLabel;
        private Label TypeLabel;
        private Label PriceLabel;
        private Label KDVLabel;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button AddMenuButton;
        private ListBox OrdersListBox;
        private Label CalorieLabel;
        private TextBox textBox5;
        private Label OrdersLabel;
        private TextBox TotalLabel;
        private Button ClearButton;
    }
}

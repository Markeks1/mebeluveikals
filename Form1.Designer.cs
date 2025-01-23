namespace mebeluveikals
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
            selectProductComboBox = new ComboBox();
            label1 = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            priceTextBox = new TextBox();
            label4 = new Label();
            hTextBox = new TextBox();
            label5 = new Label();
            wTextBox = new TextBox();
            label6 = new Label();
            descTextBox = new TextBox();
            label7 = new Label();
            lTextBox = new TextBox();
            selectBtn = new Button();
            addButton = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            exportCsvButton_click = new Button();
            importCsvButton_click = new Button();
            SuspendLayout();
            // 
            // selectProductComboBox
            // 
            selectProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectProductComboBox.FormattingEnabled = true;
            selectProductComboBox.Location = new Point(17, 63);
            selectProductComboBox.Margin = new Padding(4, 5, 4, 5);
            selectProductComboBox.Name = "selectProductComboBox";
            selectProductComboBox.Size = new Size(444, 33);
            selectProductComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 1;
            label1.Text = "Izvēlies preci";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(17, 183);
            nameTextBox.Margin = new Padding(4, 5, 4, 5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(260, 31);
            nameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 3;
            label2.Text = "Preces nosaukums";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 258);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 5;
            label3.Text = "Cena";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(17, 288);
            priceTextBox.Margin = new Padding(4, 5, 4, 5);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(260, 31);
            priceTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 153);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 7;
            label4.Text = "Augstums";
            // 
            // hTextBox
            // 
            hTextBox.Location = new Point(317, 183);
            hTextBox.Margin = new Padding(4, 5, 4, 5);
            hTextBox.Name = "hTextBox";
            hTextBox.Size = new Size(260, 31);
            hTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 258);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 9;
            label5.Text = "Platums";
            // 
            // wTextBox
            // 
            wTextBox.Location = new Point(317, 288);
            wTextBox.Margin = new Padding(4, 5, 4, 5);
            wTextBox.Name = "wTextBox";
            wTextBox.Size = new Size(260, 31);
            wTextBox.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 363);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 11;
            label6.Text = "Apraksts";
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(17, 393);
            descTextBox.Margin = new Padding(4, 5, 4, 5);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(260, 31);
            descTextBox.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 363);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 13;
            label7.Text = "Garums";
            // 
            // lTextBox
            // 
            lTextBox.Location = new Point(317, 393);
            lTextBox.Margin = new Padding(4, 5, 4, 5);
            lTextBox.Name = "lTextBox";
            lTextBox.Size = new Size(260, 31);
            lTextBox.TabIndex = 12;
            // 
            // selectBtn
            // 
            selectBtn.Location = new Point(471, 62);
            selectBtn.Margin = new Padding(4, 5, 4, 5);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(107, 40);
            selectBtn.TabIndex = 14;
            selectBtn.Text = "Izvēlēties";
            selectBtn.UseVisualStyleBackColor = true;
            selectBtn.Click += selectBtn_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(17, 497);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(107, 40);
            addButton.TabIndex = 15;
            addButton.Text = "Pievienot";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(133, 497);
            editBtn.Margin = new Padding(4, 5, 4, 5);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(107, 40);
            editBtn.TabIndex = 16;
            editBtn.Text = "Rediģēt";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(249, 497);
            deleteBtn.Margin = new Padding(4, 5, 4, 5);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(107, 40);
            deleteBtn.TabIndex = 17;
            deleteBtn.Text = "Dzēst";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // button1
            // 
            exportCsvButton_click.Location = new Point(363, 497);
            exportCsvButton_click.Name = "button1";
            exportCsvButton_click.Size = new Size(121, 37);
            exportCsvButton_click.TabIndex = 18;
            exportCsvButton_click.Text = "ExpCSV";
            exportCsvButton_click.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            importCsvButton_click.Location = new Point(490, 497);
            importCsvButton_click.Name = "button2";
            importCsvButton_click.Size = new Size(122, 37);
            importCsvButton_click.TabIndex = 19;
            importCsvButton_click.Text = "ImpCSV";
            importCsvButton_click.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 562);
            Controls.Add(importCsvButton_click);
            Controls.Add(exportCsvButton_click);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addButton);
            Controls.Add(selectBtn);
            Controls.Add(label7);
            Controls.Add(lTextBox);
            Controls.Add(label6);
            Controls.Add(descTextBox);
            Controls.Add(label5);
            Controls.Add(wTextBox);
            Controls.Add(label4);
            Controls.Add(hTextBox);
            Controls.Add(label3);
            Controls.Add(priceTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(selectProductComboBox);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(646, 618);
            MinimumSize = new Size(646, 618);
            Name = "Form1";
            Text = "Mēbeļu veikals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectProductComboBox;
        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private Label label3;
        private TextBox priceTextBox;
        private Label label4;
        private TextBox hTextBox;
        private Label label5;
        private TextBox wTextBox;
        private Label label6;
        private TextBox descTextBox;
        private Label label7;
        private TextBox lTextBox;
        private Button selectBtn;
        private Button addButton;
        private Button editBtn;
        private Button deleteBtn;
        private Button exportCsvButton_click;
        private Button importCsvButton_click;
    }
}

namespace AirPlaneWinForm
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
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.textBox3 = new System.Windows.Forms.TextBox();
        this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
        this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
        this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
        this.textBox4 = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.label8 = new System.Windows.Forms.Label();
        this.label9 = new System.Windows.Forms.Label();
        this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(13, 175);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(100, 23);
        this.button1.TabIndex = 0;
        this.button1.Text = "Подтвердить";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(368, 175);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(100, 23);
        this.button2.TabIndex = 1;
        this.button2.Text = "Отмена";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(13, 28);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(100, 20);
        this.textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(190, 28);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(100, 20);
        this.textBox2.TabIndex = 3;
        // 
        // textBox3
        // 
        this.textBox3.Location = new System.Drawing.Point(368, 28);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new System.Drawing.Size(100, 20);
        this.textBox3.TabIndex = 4;
        // 
        // maskedTextBox1
        // 
        this.maskedTextBox1.Location = new System.Drawing.Point(13, 83);
        this.maskedTextBox1.Mask = "00000";
        this.maskedTextBox1.Name = "maskedTextBox1";
        this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
        this.maskedTextBox1.TabIndex = 5;
        this.maskedTextBox1.ValidatingType = typeof(int);
        // 
        // maskedTextBox2
        // 
        this.maskedTextBox2.Location = new System.Drawing.Point(190, 83);
        this.maskedTextBox2.Mask = "00000";
        this.maskedTextBox2.Name = "maskedTextBox2";
        this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
        this.maskedTextBox2.TabIndex = 6;
        this.maskedTextBox2.ValidatingType = typeof(int);
        this.maskedTextBox2.TextChanged += new System.EventHandler(this.maskedTextBox2_TextChanged);
        // 
        // dateTimePicker1
        // 
        this.dateTimePicker1.CustomFormat = "";
        this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateTimePicker1.Location = new System.Drawing.Point(368, 83);
        this.dateTimePicker1.Name = "dateTimePicker1";
        this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
        this.dateTimePicker1.TabIndex = 7;
        // 
        // maskedTextBox3
        // 
        this.maskedTextBox3.Location = new System.Drawing.Point(190, 139);
        this.maskedTextBox3.Mask = "00000";
        this.maskedTextBox3.Name = "maskedTextBox3";
        this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
        this.maskedTextBox3.TabIndex = 9;
        this.maskedTextBox3.ValidatingType = typeof(int);
        // 
        // textBox4
        // 
        this.textBox4.Location = new System.Drawing.Point(368, 139);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new System.Drawing.Size(100, 20);
        this.textBox4.TabIndex = 10;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label1.ForeColor = System.Drawing.Color.White;
        this.label1.Location = new System.Drawing.Point(10, 12);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(36, 13);
        this.label1.TabIndex = 11;
        this.label1.Text = "Имя:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label2.ForeColor = System.Drawing.Color.White;
        this.label2.Location = new System.Drawing.Point(187, 12);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(67, 13);
        this.label2.TabIndex = 12;
        this.label2.Text = "Фамилия:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label3.ForeColor = System.Drawing.Color.White;
        this.label3.Location = new System.Drawing.Point(365, 12);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(60, 13);
        this.label3.TabIndex = 13;
        this.label3.Text = "Очество:";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label4.ForeColor = System.Drawing.Color.White;
        this.label4.Location = new System.Drawing.Point(10, 67);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(110, 13);
        this.label4.TabIndex = 14;
        this.label4.Text = "Вес багажа в КГ:";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label5.ForeColor = System.Drawing.Color.White;
        this.label5.Location = new System.Drawing.Point(187, 67);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(62, 13);
        this.label5.TabIndex = 15;
        this.label5.Text = "№ рейса:";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label6.ForeColor = System.Drawing.Color.White;
        this.label6.Location = new System.Drawing.Point(365, 67);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(88, 13);
        this.label6.TabIndex = 16;
        this.label6.Text = "Дата вылета:";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label7.ForeColor = System.Drawing.Color.White;
        this.label7.Location = new System.Drawing.Point(10, 123);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(96, 13);
        this.label7.TabIndex = 17;
        this.label7.Text = "Время вылета:";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label8.ForeColor = System.Drawing.Color.White;
        this.label8.Location = new System.Drawing.Point(187, 123);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(99, 13);
        this.label8.TabIndex = 18;
        this.label8.Text = "Часы в полете:";
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label9.ForeColor = System.Drawing.Color.White;
        this.label9.Location = new System.Drawing.Point(365, 123);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(119, 13);
        this.label9.TabIndex = 19;
        this.label9.Text = "Пункт назначения:";
        // 
        // maskedTextBox4
        // 
        this.maskedTextBox4.Location = new System.Drawing.Point(13, 139);
        this.maskedTextBox4.Mask = "00:00";
        this.maskedTextBox4.Name = "maskedTextBox4";
        this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
        this.maskedTextBox4.TabIndex = 20;
        this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
        // 
        // Form2
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.ClientSize = new System.Drawing.Size(480, 210);
        this.Controls.Add(this.maskedTextBox4);
        this.Controls.Add(this.label9);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.textBox4);
        this.Controls.Add(this.maskedTextBox3);
        this.Controls.Add(this.dateTimePicker1);
        this.Controls.Add(this.maskedTextBox2);
        this.Controls.Add(this.maskedTextBox1);
        this.Controls.Add(this.textBox3);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Name = "Form2";
        this.Text = "Form2";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.MaskedTextBox maskedTextBox4;
}
}
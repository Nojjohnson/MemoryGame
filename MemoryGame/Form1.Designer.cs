namespace MemoryGame
{
  partial class Form1
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
      this.btn_Generate = new System.Windows.Forms.Button();
      this.lbl_Display = new System.Windows.Forms.Label();
      this.btn_Memorize = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btn_Check = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.pictureBox5 = new System.Windows.Forms.PictureBox();
      this.lbl_Percent = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
      this.SuspendLayout();
      // 
      // btn_Generate
      // 
      this.btn_Generate.Location = new System.Drawing.Point(185, 31);
      this.btn_Generate.Name = "btn_Generate";
      this.btn_Generate.Size = new System.Drawing.Size(75, 23);
      this.btn_Generate.TabIndex = 0;
      this.btn_Generate.Text = "Generate";
      this.btn_Generate.UseVisualStyleBackColor = true;
      this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
      // 
      // lbl_Display
      // 
      this.lbl_Display.Location = new System.Drawing.Point(155, 70);
      this.lbl_Display.Name = "lbl_Display";
      this.lbl_Display.Size = new System.Drawing.Size(150, 30);
      this.lbl_Display.TabIndex = 1;
      this.lbl_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btn_Memorize
      // 
      this.btn_Memorize.Location = new System.Drawing.Point(185, 129);
      this.btn_Memorize.Name = "btn_Memorize";
      this.btn_Memorize.Size = new System.Drawing.Size(75, 23);
      this.btn_Memorize.TabIndex = 2;
      this.btn_Memorize.Text = "Memorize";
      this.btn_Memorize.UseVisualStyleBackColor = true;
      this.btn_Memorize.Click += new System.EventHandler(this.btn_Memorize_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(172, 194);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 3;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // btn_Check
      // 
      this.btn_Check.Location = new System.Drawing.Point(185, 256);
      this.btn_Check.Name = "btn_Check";
      this.btn_Check.Size = new System.Drawing.Size(75, 23);
      this.btn_Check.TabIndex = 4;
      this.btn_Check.Text = "Check";
      this.btn_Check.UseVisualStyleBackColor = true;
      this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(12, 350);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(71, 50);
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Location = new System.Drawing.Point(95, 350);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(71, 50);
      this.pictureBox2.TabIndex = 6;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Location = new System.Drawing.Point(184, 350);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(71, 50);
      this.pictureBox3.TabIndex = 7;
      this.pictureBox3.TabStop = false;
      // 
      // pictureBox4
      // 
      this.pictureBox4.Location = new System.Drawing.Point(273, 350);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(71, 50);
      this.pictureBox4.TabIndex = 8;
      this.pictureBox4.TabStop = false;
      // 
      // pictureBox5
      // 
      this.pictureBox5.Location = new System.Drawing.Point(359, 350);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new System.Drawing.Size(71, 50);
      this.pictureBox5.TabIndex = 9;
      this.pictureBox5.TabStop = false;
      // 
      // lbl_Percent
      // 
      this.lbl_Percent.AutoSize = true;
      this.lbl_Percent.Location = new System.Drawing.Point(206, 470);
      this.lbl_Percent.Name = "lbl_Percent";
      this.lbl_Percent.Size = new System.Drawing.Size(35, 13);
      this.lbl_Percent.TabIndex = 10;
      this.lbl_Percent.Text = "label1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(476, 605);
      this.Controls.Add(this.lbl_Percent);
      this.Controls.Add(this.pictureBox5);
      this.Controls.Add(this.pictureBox4);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.btn_Check);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btn_Memorize);
      this.Controls.Add(this.lbl_Display);
      this.Controls.Add(this.btn_Generate);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_Generate;
    private System.Windows.Forms.Label lbl_Display;
    private System.Windows.Forms.Button btn_Memorize;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btn_Check;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox pictureBox5;
    private System.Windows.Forms.Label lbl_Percent;
  }
}


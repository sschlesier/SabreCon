namespace SaberCon
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
      this.label1 = new System.Windows.Forms.Label();
      this.TextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.Fonts = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.Size = new System.Windows.Forms.NumericUpDown();
      this.Icon = new System.Windows.Forms.Panel();
      this.IsBold = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.Size)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(28, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Text";
      // 
      // TextBox
      // 
      this.TextBox.Location = new System.Drawing.Point(16, 29);
      this.TextBox.Name = "TextBox";
      this.TextBox.Size = new System.Drawing.Size(188, 20);
      this.TextBox.TabIndex = 1;
      this.TextBox.Text = "Text goes here";
      this.TextBox.TextChanged += new System.EventHandler(this.SpecChange);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(208, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Font";
      // 
      // Fonts
      // 
      this.Fonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.Fonts.FormattingEnabled = true;
      this.Fonts.Location = new System.Drawing.Point(211, 29);
      this.Fonts.Name = "Fonts";
      this.Fonts.Size = new System.Drawing.Size(179, 21);
      this.Fonts.TabIndex = 4;
      this.Fonts.SelectedIndexChanged += new System.EventHandler(this.SpecChange);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(208, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Size";
      // 
      // Size
      // 
      this.Size.Location = new System.Drawing.Point(211, 72);
      this.Size.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.Size.Name = "Size";
      this.Size.Size = new System.Drawing.Size(120, 20);
      this.Size.TabIndex = 5;
      this.Size.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
      this.Size.ValueChanged += new System.EventHandler(this.SpecChange);
      // 
      // Icon
      // 
      this.Icon.Location = new System.Drawing.Point(60, 56);
      this.Icon.Name = "Icon";
      this.Icon.Size = new System.Drawing.Size(64, 64);
      this.Icon.TabIndex = 6;
      this.Icon.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintIcon);
      // 
      // IsBold
      // 
      this.IsBold.AutoSize = true;
      this.IsBold.Location = new System.Drawing.Point(211, 98);
      this.IsBold.Name = "IsBold";
      this.IsBold.Size = new System.Drawing.Size(47, 17);
      this.IsBold.TabIndex = 7;
      this.IsBold.Text = "Bold";
      this.IsBold.UseVisualStyleBackColor = true;
      this.IsBold.CheckedChanged += new System.EventHandler(this.SpecChange);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(399, 128);
      this.Controls.Add(this.IsBold);
      this.Controls.Add(this.Icon);
      this.Controls.Add(this.Size);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Fonts);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.TextBox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "Form1";
      this.Text = "SaberCon";
      ((System.ComponentModel.ISupportInitialize)(this.Size)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox Fonts;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown Size;
    private System.Windows.Forms.Panel Icon;
    private System.Windows.Forms.CheckBox IsBold;
  }
}


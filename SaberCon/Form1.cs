using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SaberCon
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      LoadFonts();
    }

    private void LoadFonts()
    {
      Fonts.DataSource = new InstalledFontCollection().Families;
      Fonts.DisplayMember = "Name";

      var index = Fonts.FindStringExact("Calibri");
      if (index < 0)
      {
        index = Fonts.FindStringExact("Arial");
        if (index < 0)
        {
          index = 0;
        }
      }

      Fonts.SelectedIndex = index;
    }

    private void PaintIcon(object sender, PaintEventArgs e)
    {
      e.Graphics.FillRectangle(Brushes.Black, 0, 0, 64, 64);

      using (var font = new Font((FontFamily)Fonts.SelectedItem, (int) Size.Value, IsBold.Checked ? FontStyle.Bold : FontStyle.Regular))
      {
        var size = e.Graphics.MeasureString(TextBox.Text, font);

        var x = 32 - size.Width/2;
        var y = 32 - size.Height/2;

        e.Graphics.DrawString(TextBox.Text, font, Brushes.White, x, y);

        //debug, surround with rectangle to see size of text area
        //e.Graphics.DrawRectangle(Pens.Red, x, y, size.Width, size.Height);
      }
    }

    private void SpecChange(object sender, EventArgs e)
    {
      Icon.Refresh();
    }
  }
}
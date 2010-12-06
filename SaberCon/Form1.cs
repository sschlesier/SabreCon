using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using System.Linq;

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

    private static readonly String[] SplitStrings = new[] {Environment.NewLine};

    private void PaintIcon(Graphics graphics)
    {
      graphics.FillRectangle(Brushes.Black, 0, 0, 64, 64);

      using (
        var font = new Font((FontFamily) Fonts.SelectedItem, (int) Size.Value,
                            IsBold.Checked ? FontStyle.Bold : FontStyle.Regular))
      {
        var output = from l in IconText.Text.Split(SplitStrings, StringSplitOptions.None)
                     select
                       new
                         {
                           Text = SpaceForEmpty(l),
                           Size = AdjustHeight(graphics.MeasureString(SpaceForEmpty(l), font), -4)
                         };

        var totalHeight = (output.Select(i => i.Size.Height)).Sum();
        var y = 32 - totalHeight/2;

        foreach (var item in output)
        {
          var x = 32 - item.Size.Width/2;

          graphics.DrawString(item.Text, font, Brushes.White, x, y);

          //debug only
          //e.Graphics.DrawRectangle(Pens.Red, x, y, item.Size.Width, item.Size.Height);

          y += item.Size.Height - 4;
        }
      }
    }

    private void PaintIcon(object sender, PaintEventArgs e)
    {
      PaintIcon(e.Graphics);
    }

    private static SizeF AdjustHeight(SizeF size, int shrinkBy)
    {
      size.Height += shrinkBy;
      return size;
    }

    private static String SpaceForEmpty(string s)
    {
      return String.IsNullOrEmpty(s) ? " " : s;
    }

    private void SpecChange(object sender, EventArgs e)
    {
      Icon.Refresh();
    }

    private void SaveClick(object sender, EventArgs e)
    {
      var dlg = new SaveFileDialog
                  {
                    Filter = @"bmp files (*.bmp)|*.bmp",
                    FilterIndex = 0,
                    RestoreDirectory = true,
                    AddExtension = true,
                    FileName = MakeSafeFileName(IconText.Text)
                  };

      if (dlg.ShowDialog() == DialogResult.OK)
      {
        var bmp = new Bitmap(64, 64);
        using (var g = Graphics.FromImage(bmp))
        {
          PaintIcon(g);
        }
        bmp.Save(dlg.FileName, ImageFormat.Bmp);
      }
    }

    private static string MakeSafeFileName(string text)
    {
      text = Path.GetInvalidFileNameChars().Aggregate(text, (current, invalChar) => current.Replace(invalChar.ToString(), ""));
      text = Path.GetInvalidPathChars().Aggregate(text, (current, invalChar) => current.Replace(invalChar.ToString(), ""));

      if (text.Length > 160) //safe value threshold is 260
        text = text.Remove(156) + "...";

      return text;
    }
  }
}
using System;
using System.Drawing;
using Guna.UI2.WinForms;

namespace GUNASYSTEM.Messages
{
    public static class Utils
    {
        public static int GetTextHeight(Guna.UI2.WinForms.Guna2HtmlLabel label)
        {
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(label.Text, label.Font, 495);
                return (int)Math.Ceiling(size.Height); 
            }
        }
    }
}
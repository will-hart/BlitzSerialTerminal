using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTerminal.Controls
{
    /// <summary>
    /// A list box extension that allows formatting of lines
    /// </summary>
    public class FormattedListBox : ListBox
    {

        public event EventHandler Redrawing;

        /// <summary>
        /// Constructor which sets the correct drawing modes
        /// </summary>
        public FormattedListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.ItemHeight = 18;
            this.DrawItem += this.DoDrawItem;
        }

        /// <summary>
        /// Draws a list box item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void DoDrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            var g = e.Graphics;
            var backCol = Color.White;
            var foreCol = Color.Black;
            var text = ((ListBox)sender).Items[e.Index].ToString();
            var header = ' ';
            var selected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            var split = text.Split(']');
            if (split.Length > 1)
            {
                header = split[1][2];
            }

            // determine the colour from the message header
            if (header == '>')
            {
                backCol = Color.LightGreen;
            }
            else if (header == '<')
            {
                backCol = Color.RoyalBlue;//Color.LightGoldenrodYellow;
                foreCol = Color.White;
            }
            else if (header == '!')
            {
                backCol = Color.Firebrick;
                foreCol = Color.White;
            }
            else if (header == '-')
            {
                backCol = Color.LightGray;
            }

            if (e.Index == 0)
            {
                backCol = Color.Black;
                foreCol = Color.White;
            }

            if (text == string.Empty)
            {
                backCol = Color.LightGray;
            }

            g.FillRectangle(new SolidBrush(backCol), e.Bounds);
            g.DrawString(text,
                new Font(e.Font.FontFamily, e.Font.Size, selected || e.Index == 0 ? FontStyle.Bold : FontStyle.Regular),
                new SolidBrush(foreCol),
                this.GetItemRectangle(e.Index).Location);
            e.DrawFocusRectangle();
        }
    }
}

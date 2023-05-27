using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGalaxy
{
    public partial class CustomButton : Button
    {
        ToolTip t1 = new ToolTip();
        //Declare Properties
        private Image NormalImage;
        private Image HoverImage;
        private Color HoverForeColor;
        private Color NormalForeColor;
        private string Tooltip;
        public CustomButton()
        {
            InitializeComponent();
        }
        [Category("Custom Button")]
        public Image NormalImage1 { get => NormalImage; set => NormalImage = value; }
        [Category("Custom Button")]
        public Image HoverImage1 { get => HoverImage; set => HoverImage = value; }
        [Category("Custom Button")]
        public Color HoverForeColor1 { get => HoverForeColor; set => HoverForeColor = value; }
        [Category("Custom Button")]
        public Color NormalForeColor1 { get => NormalForeColor; set => NormalForeColor = value; }
        [Category("Custom Button")]
        public string Tooltip1 { get => Tooltip; set => Tooltip = value; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
        }


            

        private void CustomButton_MouseHover(object sender, EventArgs e)
        {
            Image = HoverImage;
            ForeColor = HoverForeColor;
            t1.Show(Tooltip, this);
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            Image = NormalImage;
            ForeColor = NormalForeColor;
            t1.Hide(this);
         }
                

            
    }


}

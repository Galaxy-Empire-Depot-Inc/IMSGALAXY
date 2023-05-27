using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGalaxy
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class CustomComboBox : ComboBox
    {
        //Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor= Color.FromArgb(230,228,245);
        private Color listTextColor = Color.DimGray;
        private Color bordercolor = Color.MediumSlateBlue;
        private int borderSize = 1;

        //Items
        private ComboBox cmbList;
        private Label labelText;
        private Button btnIcon;

        //Events
        public event EventHandler onSelectedIndexChanged;//Default Event

        //Constructor
        public CustomComboBox()
        {
            
            InitializeComponent();
            cmbList = new ComboBox();
            labelText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //ComboBox: Dropdown List
            cmbList.BackColor = backColor;
            /*cmbList.Font = new Font(this.Si, 10F);*/
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);//Default Event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);//Refresh text

            //Button: Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle=FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Clicked);//Open DropdownList
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw Icon

            //Label: Text
            labelText.Dock = DockStyle.Fill;
            labelText.AutoSize = false;
            labelText.TextAlign = ContentAlignment.MiddleLeft;
            labelText.Padding = new Padding(0, 0, 0, 0);
            labelText.Click += new EventHandler(Surface_Clicked);//Select Combo Box

            //User Control
            this.Controls.Add(labelText);//2
            this.Controls.Add(btnIcon);//1
            this.Controls.Add(cmbList);//0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);//Border Size
            base.BackColor = backColor;//Border Color
            this.ResumeLayout();
            AdjustComboBoxDimension();
        }

        //Private Methods
        private void AdjustComboBoxDimension()
        {
            cmbList.Width = labelText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = labelText.Bottom - cmbList.Height
            };
        }
        //Event Methods
        private void Surface_Clicked(object sender, EventArgs e)
        {
            //Select Combo Box
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Icon_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

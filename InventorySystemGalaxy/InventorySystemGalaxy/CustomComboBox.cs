using Microsoft.Scripting.Metadata;
using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemGalaxy
{
    [DefaultEvent(nameof(SelectedIndexChanged))]
    public partial class CustomComboBox : ComboBox
    {
        //Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.CornflowerBlue;
        private Color listBackColor= Color.FromArgb(230,228,245);
        private Color listTextColor = Color.DimGray;
        private Color bordercolor = Color.CornflowerBlue;
        private int borderSize = 1;

        //Items
        private ComboBox cmbList;
        private Label labelText;
        private Button btnIcon;


        public Color BackColor1 { get => backColor; set => backColor = value; }
        public Color IconColor { get => iconColor; set => iconColor = value; }
        public Color ListBackColor { get => listBackColor; set => listBackColor = value; }
        public Color ListTextColor { get => listTextColor; set => listTextColor = value; }
        public Color Bordercolor { get => bordercolor; set => bordercolor = value; }
        public int BorderSize { get => borderSize; set => borderSize = value; }

        //Events
        public event EventHandler onSelectedIndexChanged;//Default Event

        //->Data

     

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get
            {
                return cmbList.Items;
            }
        }

        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint),
        AttributeProvider(typeof(IListSource))]
        public new object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get
            {
                return cmbList.SelectedIndex;
            }
            set
            {
                cmbList.SelectedIndex=value;
            }
        }
        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get
            {
                return cmbList.SelectedItem;
            }
            set
            {
                cmbList.SelectedItem = value;
            }
        }

        
        


        //Constructor
        public CustomComboBox()
        {
            
            InitializeComponent();
            cmbList = new ComboBox();
            labelText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //ComboBox: Dropdown List
            cmbList.BackColor = listBackColor;
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

        //->Default event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (onSelectedIndexChanged != null)
                onSelectedIndexChanged.Invoke(sender, e);
            labelText.Text = cmbList.Text;

        }
        private void Surface_Clicked(object sender, EventArgs e)
        {
            //Select Combo Box
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;//Open Dropdown List 
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width-iconWidth)/2,(btnIcon.Height-iconHeight)/2,iconWidth,iconHeight);
            Graphics graph = e.Graphics;

            //Draw arrow down icon
            using (GraphicsPath path=new GraphicsPath())
            using (Pen pen= new Pen(iconColor,2))
            {
                graph.SmoothingMode=SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X+(iconWidth/2),rectIcon.Bottom,rectIcon.Right,rectIcon.Y);
                graph.DrawPath(pen,path);
            }

        }

        private void Icon_Clicked(object sender, EventArgs e)
        {
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

            private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            labelText.Text=cmbList.Text;
        }

        
    }
}

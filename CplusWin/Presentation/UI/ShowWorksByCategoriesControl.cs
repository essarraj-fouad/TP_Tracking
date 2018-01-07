using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Tracking.Entities;

namespace TP_Tracking.Presentation.UI
{
    public partial class ShowWorksByCategoriesControl : UserControl
    {
        Dictionary<string, RepertoriesControl> List_RepertoriesControl;
        public ShowWorksByCategoriesControl()
        {
            InitializeComponent();
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            List_RepertoriesControl = new Dictionary<string, RepertoriesControl>();
        }

        public void RefreshShow(TraineeDirectory traineeDirectory)
        {
            this.repertoriesRoot.RefreshRepertories(traineeDirectory);
            TabColors[tabPageOrganisation] = this.BackColor;
            if (traineeDirectory.hasErrors())
            {
                SetTabHeader(tabPageOrganisation, Color.Red);
            }

            // Create TabPage for each valide Child TraineeDirectory
            foreach (Work workToDoFileData in
                traineeDirectory
                .WorksChilds
                .Where(w => w.Validation == Enumerations.ValisationStat.Valid))
            {
                // Create Tab if not exit
                if (!tabControl1.TabPages.ContainsKey(workToDoFileData.Reference))
                {
                    // Create RepertoriesControl
                    RepertoriesControl repertoriesControl = new RepertoriesControl();
                    repertoriesControl.Dock = DockStyle.Fill;
                    repertoriesControl.RefreshRepertories(workToDoFileData);
                    List_RepertoriesControl.Add(workToDoFileData.Reference, repertoriesControl);
                    // Create TabPage
                    TabPage tabPage = new TabPage();
                    tabPage.Name = workToDoFileData.Reference;
                    tabPage.Text = workToDoFileData.Reference;
                    tabPage.Controls.Add(repertoriesControl);
                    if (workToDoFileData.hasErrors())
                    {
                        SetTabHeader(tabPage, Color.Red);
                    }
                       
                        
                    tabControl1.TabPages.Add(tabPage);
                }else
                {
                    List_RepertoriesControl[workToDoFileData.Reference].RefreshRepertories(workToDoFileData);
                }
            }

        }


        # region Change Item Color solution
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            tabControl1.Invalidate();
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // default color
            Color color = this.BackColor;

            // Font font = new Font(e.Font,FontStyle.Italic);
            


            TabPage tabPage = tabControl1.TabPages[e.Index];
            if (TabColors.Keys.Contains(tabPage))
            {
                color = TabColors[tabPage];
            }
           
            //e.DrawBackground();
            using (Brush br = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(br, e.Bounds);
                SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, e.Font);
                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);

                Rectangle rect = e.Bounds;
                rect.Offset(0, 1);
                rect.Inflate(0, -1);
                e.Graphics.DrawRectangle(Pens.DarkGray, rect);
                e.DrawFocusRectangle();
           
            }
        }
        #endregion
    }
}

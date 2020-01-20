using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraMap;

namespace NewProject
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mapControl1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MapControl mapControl = sender as MapControl;
            MapHitInfo hitInfo = mapControl.CalcHitInfo(e.Location);
            XtraMessageBox.Show(String.Format("hitInfo.InMapPolygon = {0}", hitInfo.InMapPolygon));
        }
    }
}

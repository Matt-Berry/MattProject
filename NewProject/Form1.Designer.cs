namespace NewProject
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
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            DevExpress.XtraMap.MapItemStorage mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            DevExpress.XtraMap.MapPolygon mapPolygon1 = new DevExpress.XtraMap.MapPolygon();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            imageTilesLayer1.DataProvider = openStreetMapDataProvider1;
            mapPolygon1.HighlightedFill = System.Drawing.Color.Red;
            mapPolygon1.Points.Add(new DevExpress.XtraMap.GeoPoint(0D, 0D));
            mapPolygon1.Points.Add(new DevExpress.XtraMap.GeoPoint(90D, 0D));
            mapPolygon1.Points.Add(new DevExpress.XtraMap.GeoPoint(0D, 180D));
            mapItemStorage1.Items.Add(mapPolygon1);
            vectorItemsLayer1.Data = mapItemStorage1;
            this.mapControl1.Layers.Add(imageTilesLayer1);
            this.mapControl1.Layers.Add(vectorItemsLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(946, 752);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mapControl1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 752);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;






    }
}


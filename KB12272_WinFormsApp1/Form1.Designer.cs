namespace KB12272_WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ultraGeographicMap1 = new Infragistics.Win.DataVisualization.UltraGeographicMap();
        button1 = new Button();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)ultraGeographicMap1).BeginInit();
        SuspendLayout();
        // 
        // ultraGeographicMap1
        // 
        ultraGeographicMap1.BackColor = Color.White;
        ultraGeographicMap1.CrosshairPoint = new Infragistics.Win.DataVisualization.Point(double.NaN, double.NaN);
        ultraGeographicMap1.HorizontalViewScrollbarCornerRadius = double.NaN;
        ultraGeographicMap1.HorizontalViewScrollbarHeight = double.NaN;
        ultraGeographicMap1.HorizontalViewScrollbarInset = double.NaN;
        ultraGeographicMap1.HorizontalViewScrollbarMaxOpacity = double.NaN;
        ultraGeographicMap1.HorizontalViewScrollbarShouldAddAutoTrackInsets = true;
        ultraGeographicMap1.HorizontalViewScrollbarStrokeThickness = double.NaN;
        ultraGeographicMap1.HorizontalViewScrollbarTrackEndInset = double.NaN;
        ultraGeographicMap1.HorizontalViewScrollbarTrackStartInset = double.NaN;
        ultraGeographicMap1.Location = new Point(0, 0);
        ultraGeographicMap1.Name = "ultraGeographicMap1";
        ultraGeographicMap1.ScrollbarsAnimationDuration = 300;
        ultraGeographicMap1.Size = new Size(600, 450);
        ultraGeographicMap1.TabIndex = 0;
        ultraGeographicMap1.Text = "ultraGeographicMap1";
        ultraGeographicMap1.VerticalViewScrollbarCornerRadius = double.NaN;
        ultraGeographicMap1.VerticalViewScrollbarInset = double.NaN;
        ultraGeographicMap1.VerticalViewScrollbarMaxOpacity = double.NaN;
        ultraGeographicMap1.VerticalViewScrollbarShouldAddAutoTrackInsets = true;
        ultraGeographicMap1.VerticalViewScrollbarStrokeThickness = double.NaN;
        ultraGeographicMap1.VerticalViewScrollbarTrackEndInset = double.NaN;
        ultraGeographicMap1.VerticalViewScrollbarTrackStartInset = double.NaN;
        ultraGeographicMap1.VerticalViewScrollbarWidth = double.NaN;
        ultraGeographicMap1.WindowRectMinWidth = 5E-06D;
        ultraGeographicMap1.WorldRect = new Infragistics.Win.DataVisualization.Rectangle(-180D, -85.05112878D, 360D, 170.10225756D);
        // 
        // button1
        // 
        button1.Location = new Point(628, 33);
        button1.Name = "button1";
        button1.Size = new Size(370, 57);
        button1.TabIndex = 1;
        button1.Text = "四隅の経度と緯度を取得する。";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(628, 140);
        label1.Name = "label1";
        label1.Size = new Size(59, 25);
        label1.TabIndex = 2;
        label1.Text = "";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1280, 450);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(ultraGeographicMap1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)ultraGeographicMap1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Infragistics.Win.DataVisualization.UltraGeographicMap ultraGeographicMap1;
    private Button button1;
    private Label label1;
}

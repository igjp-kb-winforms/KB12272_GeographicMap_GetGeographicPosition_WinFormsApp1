using Infragistics.Win.DataVisualization;
using System.Text;

namespace KB12272_WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        ultraGeographicMap1.Zoomable = true;

        double latitude = 35.6895;
        double longitude = 139.6917;
        double height = 0.013;
        double width = 0.013;

        Infragistics.Win.DataVisualization.Rectangle rect = ultraGeographicMap1.GetZoomFromGeographic(new Infragistics.Win.DataVisualization.Rectangle(longitude - height / 2, latitude - width / 2, width, height));
        ultraGeographicMap1.WindowRect = rect;

    }

    private void button1_Click(object sender, EventArgs e)
    {
        var geographicRect = ultraGeographicMap1.GetGeographicFromZoom(ultraGeographicMap1.WindowRect);

        var geographicInformation = new StringBuilder();
        geographicInformation.AppendLine($"左上(経度, 緯度) = ({geographicRect.Left}, {geographicRect.Top})");
        geographicInformation.AppendLine($"右上(経度, 緯度) = ({geographicRect.Right}, {geographicRect.Top})");
        geographicInformation.AppendLine($"左下(経度, 緯度) = ({geographicRect.Left}, {geographicRect.Bottom})");
        geographicInformation.AppendLine($"右下(経度, 緯度) = ({geographicRect.Right}, {geographicRect.Bottom})");
        label1.Text = geographicInformation.ToString();
    }
}

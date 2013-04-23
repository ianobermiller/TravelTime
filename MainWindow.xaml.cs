using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TravelTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Dictionary<int, string> idToName = new Dictionary<int, string>()
        {
            { 1, "Everett-Seattle (SB AM)" },
            { 2, "HOV Everett-Seattle (SB AM)" },
            { 3, "HOV Seattle-Everett (NB PM)" },
            { 4, "Seattle-Everett (NB PM)" },
            { 5, "Bellevue-Issaquah (EB PM)" },
            { 6, "HOV Bellevue-Issaquah (EB PM)" },
            { 7, "HOV Issaquah-Bellevue (WB AM)" },
            { 8, "Issaquah-Bellevue (WB AM)" },
            { 9, "Bellevue-Everett (NB PM)" },
            { 10, "Everett-Bellevue (SB AM)" },
            { 11, "HOV Bellevue-Everett (NB PM)" },
            { 12, "HOV Everett-Bellevue (SB AM)" },
            { 13, "Federal Way-SeaTac (NB AM)" },
            { 14, "HOV Federal Way-SeaTac (NB AM)" },
            { 15, "HOV SeaTac-Federal Way (SB PM)" },
            { 16, "SeaTac-Federal Way (SB PM)" },
            { 17, "Federal Way-Seattle (NB AM)" },
            { 18, "HOV Federal Way-Seattle (NB AM)" },
            { 19, "HOV Seattle-Federal Way (SB PM)" },
            { 20, "Seattle-Federal Way (SB PM)" },
            { 21, "Bellevue-Federal Way (SB PM)" },
            { 22, "Federal Way-Bellevue (NB AM)" },
            { 23, "HOV Bellevue-Federal Way (SB PM)" },
            { 24, "HOV Federal Way-Bellevue (NB AM)" },
            { 25, "HOV Seattle-Lynnwood (NB PM)" },
            { 26, "Lynnwood-Seattle (SB AM)" },
            { 27, "Seattle-Lynnwood (NB PM)" },
            { 28, "HOV Lynnwood-Seattle (SB REV)" },
            { 29, "Lynnwood-Seattle (SB REV)" },
            { 30, "HOV Renton-Seattle (NB AM)" },
            { 31, "HOV Seattle-Renton (SB PM)" },
            { 32, "Renton-Seattle (NB AM)" },
            { 33, "Seattle-Renton (SB PM)" },
            { 34, "Shoreline-Seattle (SB REV)" },
            { 35, "Bellevue-Lynnwood (NB PM)" },
            { 36, "HOV Bellevue-Lynnwood (NB PM)" },
            { 37, "HOV Lynnwood-Bellevue (SB AM)" },
            { 38, "Lynnwood-Bellevue (SB AM)" },
            { 39, "Everett-Seattle (SB REV)" },
            { 40, "1B HOV Everett-Seattle (SB REV)" },
            { 41, "HOV SeaTac-Seattle (NB AM)" },
            { 42, "HOV Seattle-SeaTac (SB PM)" },
            { 43, "SeaTac-Seattle (NB AM)" },
            { 44, "Seattle-SeaTac (SB PM)" },
            { 45, "Bellevue-Renton (SB PM)" },
            { 46, "HOV Bellevue-Renton (SB PM)" },
            { 47, "HOT Lanes NB GP" },
            { 48, "HOT Lanes NB HOV" },
            { 49, "HOT Lanes SB GP" },
            { 50, "HOT Lanes SB HOV" },
            { 51, "Alderwood to Southcenter via I-405 (SB AM)" },
            { 52, "Alderwood to Southcenter via I-5 (SB AM)" },
            { 53, "Southcenter to Alderwood via I-405 (NB PM)" },
            { 54, "Southcenter to Alderwood via I-5 (NB PM)" },
            { 55, "Bellevue-SR 522 (NB PM)" },
            { 56, "HOV Bellevue-SR 522 (NB PM)" },
            { 57, "HOV SR 522-Bellevue (SB AM)" },
            { 58, "SR 522-Bellevue" },
            { 59, "Woodinville-Seattle via I-90 (WB AM)" },
            { 60, "Woodinville-Seattle via SR 520 (WB AM)" },
            { 61, "Woodinville-Seattle via I-90 (EB PM)" },
            { 62, "Woodinville-Seattle via SR 520 (EB PM)" },
            { 63, "Bellevue-Tukwila (SB PM)" },
            { 64, "HOV Bellevue-Tukwila (SB PM)" },
            { 65, "HOV Tukwila-Bellevue (NB AM)" },
            { 66, "Tukwila-Bellevue (NB AM)" },
            { 67, "Auburn-Renton (NB AM)" },
            { 68, "HOV Auburn-Renton (NB AM)" },
            { 69, "HOV Renton-Auburn (SB PM)" },
            { 70, "Renton-Auburn (SB PM)" },
            { 71, "HOV Issaquah-Seattle (WB PM)" },
            { 72, "HOV Downtown Seattle-Issaquah (EB AM)" },
            { 73, "Issaquah-Seattle (WB PM)" },
            { 74, "Seattle-Issaquah (EB AM)" },
            { 75, "HOV Issaquah-Seattle (WB REV)" },
            { 76, "Issaquah-Seattle (WB REV)" },
            { 77, "HOV Redmond-Seattle (WB PM)" },
            { 78, "HOV Seattle-Redmond (EB AM)" },
            { 79, "Redmond-Seattle (WB PM)" },
            { 80, "Seattle-Redmond (EB AM)" },
            { 81, "HOV Redmond-Seattle via I-90 (WB PM)" },
            { 82, "HOV Seattle-Redmond via I-90 (EB AM)" },
            { 83, "Redmond-Seattle via I-90 (WB PM)" },
            { 84, "Seattle-Redmond via I-90 (EB AM)" },
            { 85, "HOV Redmond-Seattle via I-90 (WB REV)" },
            { 86, "Redmond-Seattle via I-90 (WB REV)" },
            { 87, "Northgate-ShipCanal (SB AM)" },
            { 88, "Albro-Seattle (NB AM)" },
            { 89, "Bellevue-Seattle via 520 (WB PM)" },
            { 90, "HOV Bellevue-Seattle via 520 (WB PM)" },
            { 91, "HOV Seattle-Bellevue via 520 (EB AM)" },
            { 92, "Seattle-Bellevue via 520 (EB AM)" },
            { 93, "Bellevue-Seattle via I-90 (WB PM)" },
            { 94, "HOV Bellevue-Seattle via I-90 (WB PM)" },
            { 95, "HOV Seattle-Bellevue via I-90 (EB AM)" },
            { 96, "Seattle-Bellevue via I-90 (EB AM)" },
            { 97, "Bellevue-Seattle via I-90 (WB REV)" },
            { 98, "HOV Bellevue-Seattle via I-90 (WB REV)" },
            { 99, "Bellevue-Redmond (EB PM)" },
            { 100, "HOV Bellevue-Redmond (EB PM)" },
            { 101, "HOV Redmond-Bellevue (WB PM)" },
            { 102, "Redmond-Bellevue (WB PM)" },
            { 103, "Albro-Northgate (NB AM)" },
            { 104, "Northgate-Spokane (SB AM)" },
            { 105, "405 Kirkland-Seattle via I-90 (WB PM)(3)" },
            { 106, "405 Kirkland-Seattle via SR 520 (WB PM)" },
            { 107, "Web Redmond-Seattle via I-90 (WB PM)" },
            { 108, "Web Redmond-Seattle via SR 520 (WB PM)" },
            { 109, "HOV 405 Kirkland-Seattle via I-90 (WB PM)(3)" },
            { 110, "HOV 405 Kirkland-Seattle via SR 520 (WB PM)" },
            { 111, "WebHOV Redmond-Seattle via I-90 (WB PM)" },
            { 112, "HOV 520 Redmond-Seattle via SR 520 (WB PM)" },
            { 113, "WebHOVEXP Redmond-Seattle via I-90 (WB PM)" },
            { 114, "Snoqualmie Pass" },
            { 115, "Snoqualmie Pass" },
            { 116, "SB I-5, Lacey (SR510) to Olympia" },
            { 117, "NB I-5, Olympia to Lacey (SR510)" },
            { 118, "SB I-5, JBLM Main Gate to Lacey (SR510) SB" },
            { 119, "NB I-5, Lacey (SR510) to JBLM Main Gate" },
            { 120, "NB I-5, JBLM Main Gate to Lakewood (SR512)" },
            { 121, "SB I-5, Lakewood (SR512) to JBLM Main Gate" },
            { 122, "NB I-5,Lakewood at SR512 To Tacoma" },
            { 123, "SB I-5,Tacoma To Lakewood at SR512" },
            { 124, "SB I-5, Pierce King County Line To Tacoma" },
            { 125, "NB I-5,Tacoma To Pierce King County Line" },
            { 126, "NB I-5, Olympia To Tacoma" },
            { 127, "SB I-5,Tacoma To Olympia" },
            { 128, "HOV Seattle-Lynnwood (NB REV)" },
            { 129, "Seattle-Lynnwood (NB REV)" },
            { 130, "Seattle-Shoreline (NB REV)" },
            { 131, "HOV Seattle-Everett (NB REV)" },
            { 132, "Seattle-Everett (NB REV)" },
            { 133, "HOV Seattle-Redmond via I-90 (EB REV)" },
            { 134, "Seattle-Redmond via I-90 (EB REV)" },
            { 135, "HOV Seattle-Bellevue via I-90 (EB REV)" },
            { 136, "Seattle-Bellevue via I-90 (EB REV)" },
            { 266, "Arlington-Everett (SB AM)" },
            { 267, "Everett-Arlington (NB PM)" },
            { 268, "Everett-Marysville (NB PM)" },
            { 269, "Marysville-Everett (SB AM)" },
            { 275, "HOV Lynnwood-Seattle (SB AM)" },
            { 278, "HOV Renton-Bellevue (NB AM)" },
            { 279, "Renton-Bellevue (NB AM)" },
            { 285, "Seattle-Woodinville via SR 522 (EB REV)" },
            { 286, "Seattle-Woodinville via SR 522 Short (EB PM)-v2" },
            { 287, "Woodinville-Seattle via SR 522 Short (WB AM)-v2" },
            { 288, "Woodinville-Seattle via SR 522 (SB REV)" }
        };
        private static string AccessCode = "c7438153-3a3f-42aa-a7b9-59b695ed51b9";
        private Timer timer;
        public MainWindow()
        {
            InitializeComponent();
            this.MouseLeftButtonDown += DragWindow;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await UpdateTime();
            timer = new Timer(1000 * 60 * 5);
            timer.Elapsed += async (s, ea) => {
                await UpdateTime();
            };
            timer.Start();
        }

        private async Task UpdateTime()
        {
            var client = new WashingtonDot.TravelTimesClient();
            var routeIds = new[] { 101, 46 };
            var routes = await Task.WhenAll(routeIds.Select(id => client.GetTravelTimeAsync(AccessCode, id)).ToArray());
            var totalTime = routes.Sum(r => r.CurrentTime);

            await this.Dispatcher.BeginInvoke((Action)(() => {
                uxTime.ToolTip = string.Join(", ", routes.Select(r => idToName[r.TravelTimeID] + ": " + r.CurrentTime));
                uxTime.Text = totalTime.ToString();
                if (totalTime < 30)
                {
                    uxTime.Foreground = Brushes.Green;
                }
                else if (totalTime < 45)
                {
                    uxTime.Foreground = Brushes.Yellow;
                }
                else
                {
                    uxTime.Foreground = Brushes.Red;
                }
            }));
        }


        //
        // DraggableWindow
        //
        
        private Point startPoint;

        protected void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        protected void ChildPreviewMouseMove(object sender, MouseEventArgs e)
        {
            IInputElement element = sender as IInputElement;
            var currentPoint = e.GetPosition(element);
            if (e.LeftButton == MouseButtonState.Pressed &&
                element.IsMouseCaptured &&
                (Math.Abs(currentPoint.X - startPoint.X) >
                    SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(currentPoint.Y - startPoint.Y) >
                    SystemParameters.MinimumVerticalDragDistance))
            {
                // Prevent Click from firing
                element.ReleaseMouseCapture();
                DragMove();
            }
        }

        protected void ChildPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(sender as IInputElement);
        }
    }
}

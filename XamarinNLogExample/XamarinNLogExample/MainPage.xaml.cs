using NLog;
using System;
using Xamarin.Forms;

namespace XamarinNLogExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void InfoBtn_Clicked(object sender, EventArgs e)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Info("You registered an info log");
        }

        private void DebugBtn_Clicked(object sender, EventArgs e)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Debug("You registered a debug log");
        }

        private void TraceBtn_Clicked(object sender, EventArgs e)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Trace("You registered a trace log");
        }

        private void WarnBtn_Clicked(object sender, EventArgs e)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Warn("You registered a warning log");
        }

        private void ErroBtn_Clicked(object sender, EventArgs e)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Error("You registered an error log");
        }
    }
}
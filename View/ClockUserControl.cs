using Sidekick.Presenter;

namespace Sidekick.View
{
    public partial class ClockUserControl : UserControl, IClockView
    {
        private ClockPresenter _presenter;

        public ClockUserControl()
        {
            InitializeComponent();

            _presenter = new ClockPresenter(this);
        }

        public void ShowTime(string time)
        {
            timeLabel.Text = time;
        }

        public void ShowDate(string date)
        {
            dateLabel.Text = date;
        }
    }
}

using Sidekick.View;
using Timer = System.Windows.Forms.Timer;

namespace Sidekick.Presenter
{
    internal class ClockPresenter
    {
        private readonly IClockView _view;
        private readonly Timer _timer;

        public ClockPresenter(IClockView view)
        {
            _view = view;

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(Timer_Tick);
            _timer.Enabled = true;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            var date = DateTime.Now;
            _view.ShowTime(date.ToShortTimeString());
            _view.ShowDate(date.ToShortDateString());
        }
    }
}

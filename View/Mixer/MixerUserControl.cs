using Sidekick.Presenter.Mixer;

namespace Sidekick.View.Mixer
{
    public partial class MixerUserControl : UserControl, IMixerView
    {
        private readonly MixerPresenter _presenter;

        public MixerUserControl()
        {
            InitializeComponent();

            _presenter = new MixerPresenter(this);
        }
    }
}

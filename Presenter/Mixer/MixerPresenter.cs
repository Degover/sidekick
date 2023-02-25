using Sidekick.View.Mixer;

namespace Sidekick.Presenter.Mixer
{
    internal class MixerPresenter
    {
        private readonly IMixerView _view;

        public MixerPresenter(IMixerView view)
        {
            _view = view;
        }
    }
}

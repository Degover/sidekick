using Sidekick.Audio;
using Sidekick.View.Mixer;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Sidekick.Presenter.Mixer
{
    internal class MixerPresenter
    {
        private readonly IMixerView _view;

        public MixerPresenter(IMixerView view)
        {
            _view = view;

            Class1.OtherTest();
        }
    }
}

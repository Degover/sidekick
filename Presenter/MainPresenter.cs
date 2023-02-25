using Sidekick.View;

namespace Sidekick.Presenter
{
    internal class MainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            this._view = view;
        }
    }
}

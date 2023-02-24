using Sidekick.View;

namespace Sidekick.Presenter
{
    internal class MainPresenter
    {
        private IMainView view;

        public MainPresenter(IMainView view)
        {
            this.view = view;
        }
    }
}

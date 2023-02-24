using Sidekick.Presenter;

namespace Sidekick.View.Impl
{
    public partial class MainForm : Form, IMainView
    {
        private MainPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();

            _presenter = new MainPresenter(this);
        }
    }
}

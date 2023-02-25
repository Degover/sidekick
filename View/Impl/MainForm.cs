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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams baseParams = base.CreateParams;

                const int WS_EX_NOACTIVATE = 0x08000000;
                baseParams.ExStyle = WS_EX_NOACTIVATE;

                return baseParams;
            }
        }
    }
}

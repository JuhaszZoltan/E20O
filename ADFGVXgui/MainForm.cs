namespace ADFGVXgui
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            loadButton.Click += OnLoadButtonClick;
        }

        private void OnLoadButtonClick(object? sender, EventArgs e)
        {
            OpenFileDialog odf = new()
            {
                InitialDirectory = Application.StartupPath.Split("\\bin")[0] + "\\SRC\\",
            };
            odf.ShowDialog();
        }
    }
}
using System.Text;

namespace ADFGVXgui
{
    public partial class MainForm : Form
    {
        public char[,] Kodtabla { get; set; }

        public MainForm()
        {
            InitializeComponent();
            loadButton.Click += OnLoadButtonClick;
        }

        private void OnLoadButtonClick(object? sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                InitialDirectory = Application.StartupPath.Split("\\bin")[0] + "\\SRC\\",
            };
            if (DialogResult.OK == ofd.ShowDialog())
            {
                Kodtabla = new char[6, 6];
                using StreamReader sr = new(ofd.FileName, Encoding.UTF8);
                int si = 0;
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine()!;
                    for (int oi = 0; oi < sor.Length; oi++)
                        Kodtabla[si, oi] = sor[oi];
                }
                KodtablaBetoltese();
            }
        }

        private void KodtablaBetoltese()
        {
            throw new NotImplementedException();
        }
    }
}
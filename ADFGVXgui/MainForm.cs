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
            Kodtabla = new char[6, 6];

            OpenFileDialog ofd = new()
            {
                InitialDirectory = Application.StartupPath.Split("\\bin")[0] + "\\SRC\\",
            };
            if (DialogResult.OK == ofd.ShowDialog())
            {
                using StreamReader sr = new(ofd.FileName, Encoding.UTF8);
                int si = 0;
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine()!;
                    for (int oi = 0; oi < sor.Length; oi++)
                    {
                        Kodtabla[si, oi] = sor[oi];
                    }
                    si++;
                }
                KodtablaBetoltese();
            }
        }

        private void KodtablaBetoltese()
        {
            mainPanel.Controls.Clear();
            Label[,] labelmatrix = new Label[Kodtabla.GetLength(0), Kodtabla.GetLength(1)];

            int rat = mainPanel.Width / labelmatrix.GetLength(1);
            
            for (int s = 0; s < labelmatrix.GetLength(0); s++)
            {
                for (int o = 0; o < labelmatrix.GetLength(1); o++)
                {
                    labelmatrix[s, o] = new()
                    {
                        AutoSize = false,
                        BackColor = Color.White,
                        Bounds = new()
                        {
                            Width = rat,
                            Height = rat,
                            X = o * rat,
                            Y = s * rat,
                        },
                        Font = new(familyName: "Consolas", emSize: 20f),
                        Text = $"{Kodtabla[s, o]}",
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    mainPanel.Controls.Add(labelmatrix[s, o]);
                }
            }
        }
    }
}
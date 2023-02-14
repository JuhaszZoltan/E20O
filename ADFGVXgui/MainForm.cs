using System.Text;

namespace ADFGVXgui
{
    public partial class MainForm : Form
    {
        public char[,] Kodtabla { get; set; }
        private static string valid = "abcdefghijklmnopqrstuvwxyz0123456789";

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
                KodtablaEllenorzese();
            }
        }

        private void KodtablaEllenorzese()
        {
            checkRichTextBox.Clear();
            bool meret = JoMeret();
            bool karakterek = MegfeleloKarakterek();
            bool pontegyszer = PontosanEgyszerSzerepelMinden();

            if (meret & karakterek & pontegyszer)
            {
                checkRichTextBox.Text += "A mátrix megfelelõ!\n";
            }

        }

        private bool PontosanEgyszerSzerepelMinden()
        {
            bool peszm = true;
            string ks = string.Empty;
            foreach (var c in Kodtabla) if (c != '\0') ks += c;

            foreach (var v in valid)
            { 
                //TODO: SZAR AZ EGÉSZ!
                foreach (var kc in ks)
                {
                    int cc = valid.Count(x => x == v);
                    if (cc != 1)
                    {
                        peszm = false;
                        checkRichTextBox.Text += $"A(z) karakter {cc}x szerepel a mátrixban!\n";
                    }
                }
            }
            return peszm;
        }

        private bool MegfeleloKarakterek()
        {
            bool megfelelo = true;
            foreach (var c in Kodtabla)
            {
                if (!valid.Contains(c) && c != '\0')
                {
                    checkRichTextBox.Text += $"hibás karakter ({c}) a mátrixban!\n";
                    megfelelo = false;
                }
            }
            return megfelelo;
        }

        private bool JoMeret()
        {
            for (int s = 0; s < Kodtabla.GetLength(0); s++)
            {
                for (int o = 0; o < Kodtabla.GetLength(1); o++)
                {
                    if (Kodtabla[s, o] == '\0')
                    {
                        checkRichTextBox.Text += "Hiba a mátrix méretében!\n";
                        return false;
                    }
                }
            }
            return true;
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
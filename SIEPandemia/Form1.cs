using System;
using System.Linq;
using System.Windows.Forms;

namespace SIEPandemia {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void NumeroAlunos_ValueChanged(object sender, EventArgs e) {
            if (NumeroAlunos.Value < AlunosLista.Items.Count) {
                while (NumeroAlunos.Value < AlunosLista.Items.Count) {
                    AlunosLista.Items.RemoveAt(AlunosLista.Items.Count - 1);
                }
            } else if (NumeroAlunos.Value > AlunosLista.Items.Count) {
                while (NumeroAlunos.Value > AlunosLista.Items.Count) {
                    AlunosLista.Items.Add("Aluno " + (AlunosLista.Items.Count + 1));
                }
            }
        }

        private void ButtonColar_Click(object sender, EventArgs e) {
            string[] lines = Clipboard.GetText().Split('\n');
            AlunosLista.Items.Clear();
            foreach (string line in lines) {
                if (line.Length > 0) {
                    string input = line;
                    if (input.Length > 25) input = input.Substring(0, 20);
                    AlunosLista.Items.Add(input);
                }
            }
            NumeroAlunos.Value = AlunosLista.Items.Count;
        }

        private void ButtonLimpar_Click(object sender, EventArgs e) {
            NumeroAlunos.Value = 1;
            AlunosLista.Items.Clear();
            AlunosLista.Items.Add("Aluno 1");
        }

        private void ButtonTodos_Click(object sender, EventArgs e) {
            SetAllItemsChecked(true);
        }

        private void ButtonNenhum_Click(object sender, EventArgs e) {
            SetAllItemsChecked(false);
        }

        private void SetAllItemsChecked(bool IsChecked) {
            for (int index = 0; index < AlunosLista.Items.Count; index++) {
                AlunosLista.SetItemChecked(index, IsChecked);
            }
        }

        private void ButtonSalvar_Click(object sender, EventArgs e) {
            string output = "";

            output += delay(300);
            output += next();

            System.IO.File.WriteAllText(@"E:\teste.mcr", output);
        }

        private string delay(int millis) {
            return "DELAY : " + millis + "\n";
        }

        private string next() {
            return
                "Keyboard : Tab : KeyDown\n" +
                "DELAY : " + NumeroDelay.Value + "\n" +
                "Keyboard : Tab : KeyUp\n" +
                "DELAY : " + NumeroDelay.Value + "\n";
        }

        private string select() {
            return
                "Keyboard : Space : KeyDown\n" +
                "DELAY : " + NumeroDelay.Value + "\n" +
                "Keyboard : Space : KeyUp\n" +
                "DELAY : " + NumeroDelay.Value + "\n";
        }

        private string markPandemia() {
            return
                "Keyboard : P : KeyDown\n" +
                "DELAY : " + NumeroDelay.Value + "\n" +
                "Keyboard : P : KeyUp\n" +
                "DELAY : " + NumeroDelay.Value + "\n";
        }

        private void label1_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://google.com");
        }
    }
}

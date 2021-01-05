using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SIEPandemia {
    public partial class Form1 : Form {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        IWshRuntimeLibrary.WshShell shell;
        const int MYACTION_HOTKEY_ID = 1;

        public Form1() {
            InitializeComponent();
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 2, (int)Keys.B);
            shell = new IWshRuntimeLibrary.WshShell();
        }

        protected override void WndProc(ref Message m) {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID) {
                play();
            }
            base.WndProc(ref m);
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
            play();
        }

        private void delay(decimal millis) {
            Thread.Sleep((int)millis);
        }

        private void next() {
            shell.SendKeys("\t");
            delay(NumeroDelay.Value);
        }

        private void select() {
            shell.SendKeys(" ");
            delay(NumeroDelay.Value);
        }

        private void markPandemia() {
            shell.SendKeys("P");
            delay(NumeroDelay.Value);
        }

        private void play() {
            if (this.WindowState != FormWindowState.Minimized) this.WindowState = FormWindowState.Minimized;
            delay(300);
            next();
            next();
            next();
            for (int index = 0; index < AlunosLista.Items.Count; index++) {
                next();
                if (AlunosLista.GetItemChecked(index)) {
                    for (int aulas = 0; aulas < NumeroAulas.Value; aulas++) {
                        select();
                        next();
                        if (index == 0 && aulas == 0) next();
                        next();
                    }
                    
                    for (int aulas = 0; aulas < NumeroAulas.Value; aulas++) {
                        markPandemia();
                        next();
                    }
                } else {
                    for (int aulas = 0; aulas < NumeroAulas.Value; aulas++) {
                        next();
                        next();
                        if (index == 0 && aulas == 0) next();
                    }
                }
            }

        }

        private void Logo_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/firminoveras/SIEPandemia");
        }
    }
}

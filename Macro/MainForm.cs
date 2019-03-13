using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Macro
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVNETF_MOVE = 0x0001;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_WHEEL = 0x0800;
        private const int MOUSEEVENTF_XDOWN = 0x0080;
        private const int MOUSEEVENTF_XUP = 0x0100;
        private const int MOUSEEVENTF_HWHEEL = 0x1000;

        public string DataSubstring(string o, string s, string e, int cur)
        {
            int p = o.IndexOf(s, cur);
            p += s.Length;
            int ep = o.IndexOf(e, p);
            return o.Substring(p, ep - p);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xPosTextBox.Text = "1000";
            yPosTextBox.Text = "800";
            WaitTextBox.Text = "200";
            tick.Start();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            int cursorX = Cursor.Position.X;
            int cursorY = Cursor.Position.Y;
            CursorPositionLabel.Text = string.Format("({0}, {1})", cursorX, cursorY);
        }

        private new void MouseClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        private new void MouseClick(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            MouseClick();
        }

        private new void MouseDoubleClick()
        {
            MouseClick();
            Thread.Sleep(50);
            MouseClick();
        }

        private new void MouseDoubleClick(int x, int y)
        {
            MouseClick(x, y);
            Thread.Sleep(50);
            MouseClick(x, y);
        }

        private void MouseRightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        private void MouseRightClick(int x, int y)
        {
            Cursor.Position = new Point(x, y);
            MouseRightClick();
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            ProcedureListBox.Items.Add(string.Format("Click({0}, {1})", xPosTextBox.Text, yPosTextBox.Text));
            if (eachCheckBox.Checked)
            {
                ProcedureListBox.Items.Add(string.Format("Wait({0}ms)", WaitTextBox.Text));
            }
        }

        private void DoubleClickButton_Click(object sender, EventArgs e)
        {
            ProcedureListBox.Items.Add(string.Format("DClick({0}, {1})", xPosTextBox.Text, yPosTextBox.Text));
            if (eachCheckBox.Checked)
            {
                ProcedureListBox.Items.Add(string.Format("Wait({0}ms)", WaitTextBox.Text));
            }
        }

        private void RightClickButton_Click(object sender, EventArgs e)
        {
            ProcedureListBox.Items.Add(string.Format("RClick({0}, {1})", xPosTextBox.Text, yPosTextBox.Text));
            if (eachCheckBox.Checked)
            {
                ProcedureListBox.Items.Add(string.Format("Wait({0}ms)", WaitTextBox.Text));
            }
        }

        private void PressButton_Click(object sender, EventArgs e)
        {
            ProcedureListBox.Items.Add(string.Format("Press({0})", KeyTextBox.Text));
            if (eachCheckBox.Checked)
            {
                ProcedureListBox.Items.Add(string.Format("Wait({0}ms)", WaitTextBox.Text));
            }
        }

        private void WaitButton_Click(object sender, EventArgs e)
        {
            ProcedureListBox.Items.Add(string.Format("Wait({0}ms)", WaitTextBox.Text));
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int x, y;
            for (int i = 0; i < ProcedureListBox.Items.Count; i++)
            {
                ProcedureListBox.SelectedIndex = i;
                string str = ProcedureListBox.Items[i].ToString();
                string command = str.Split('(')[0];
                switch (command)
                {
                    case "Click":
                        x = int.Parse(DataSubstring(str, "(", ",", 0));
                        y = int.Parse(DataSubstring(str, ", ", ")", 0));
                        MouseClick(x, y);
                        break;
                    case "DClick":
                        x = int.Parse(DataSubstring(str, "(", ",", 0));
                        y = int.Parse(DataSubstring(str, ", ", ")", 0));
                        MouseDoubleClick(x, y);
                        break;
                    case "RClick":
                        x = int.Parse(DataSubstring(str, "(", ",", 0));
                        y = int.Parse(DataSubstring(str, ", ", ")", 0));
                        MouseRightClick(x, y);
                        break;
                    case "Press":
                        SendKeys.Send(SendKeysString(DataSubstring(str, "(", ")", 0)));
                        break;
                    case "Wait":
                        Thread.Sleep(int.Parse(DataSubstring(str, "(", "ms", 0)));
                        break;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProcedureListBox.SelectedIndex >= 0)
            {
                int idx = ProcedureListBox.SelectedIndex;
                ProcedureListBox.Items.RemoveAt(idx);
                if (ProcedureListBox.Items.Count > idx)
                {
                    ProcedureListBox.SelectedIndex = idx;
                }
                else if (idx != 0)
                {
                    ProcedureListBox.SelectedIndex = idx - 1;
                }
            }
        }

        private void NewRoutineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcedureListBox.Items.Clear();
        }

        private void EndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void speedMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void KeyTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string keyText = string.Empty;

            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.ControlKey)
                    keyText = "Ctrl";
                else
                    keyText = "Ctrl+" + KeysString("" + e.KeyCode);
            }
            else if (e.Modifiers == Keys.Alt)
            {
                if (e.KeyCode == Keys.Menu)
                    keyText = "Alt";
                else
                    keyText = "Alt+" + KeysString("" + e.KeyCode);
            }
            else if (e.Modifiers == Keys.Shift)
            {
                if (e.KeyCode == Keys.ShiftKey)
                    keyText = "Shift";
                else
                    keyText = "Shift+" + KeysString("" + e.KeyCode);
            }
            else if (e.Modifiers == (Keys.Control | Keys.Alt))
            {
                if (e.KeyCode == Keys.Menu || e.KeyCode == Keys.ControlKey)
                    keyText = "Ctrl+Alt";
                else
                    keyText = "Ctrl+Alt+" + KeysString("" + e.KeyCode);
            }
            else if (e.Modifiers == (Keys.Control | Keys.Shift))
            {
                if (e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.ControlKey)
                    keyText = "Ctrl+Shift";
                else
                    keyText = "Ctrl+Shift+" + KeysString("" + e.KeyCode);
            }
            else if (e.Modifiers == (Keys.Alt | Keys.Shift))
            {
                if (e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.Menu)
                    keyText = "Alt+Shift";
                else
                    keyText = "Alt+Shift+" + KeysString("" + e.KeyCode);
            }
            else if (e.Modifiers == (Keys.Control | Keys.Alt | Keys.Shift))
            {
                if (e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.Menu || e.KeyCode == Keys.ControlKey)
                    keyText = "Ctrl+Alt+Shift";
                else
                    keyText = "Ctrl+Alt+Shift+" + KeysString("" + e.KeyCode);
            }
            else
            {
                keyText = KeysString("" + e.KeyCode);
            }
            KeyTextBox.Text = keyText;
        }

        private string KeysString(string keyString)
        {
            string toString = string.Empty;
            switch (keyString)
            {
                case "Capital": toString = "CapsLock"; break;
                case "D0": toString = "0"; break;
                case "D1": toString = "1"; break;
                case "D2": toString = "2"; break;
                case "D3": toString = "3"; break;
                case "D4": toString = "4"; break;
                case "D5": toString = "5"; break;
                case "D6": toString = "6"; break;
                case "D7": toString = "7"; break;
                case "D8": toString = "8"; break;
                case "D9": toString = "9"; break;
                case "Add": toString = "+"; break;
                case "Subtract": toString = "-"; break;
                case "Multiply": toString = "*"; break;
                case "Divide": toString = "/"; break;
                case "Up": toString = "↑"; break;
                case "Down": toString = "↓"; break;
                case "Left": toString = "←"; break;
                case "Right": toString = "→"; break;
                case "Escape": toString = "ESC"; break;
                case "Oemtilde": toString = "`"; break;
                case "OemMinus": toString = "-"; break;
                case "Oemplus": toString = "="; break;
                case "Oem5": toString = "\\"; break;
                case "Next": toString = "PageDown"; break;
                case "OemOpenBrackets": toString = "["; break;
                case "Oem6": toString = "]"; break;
                case "Oem1": toString = ";"; break;
                case "Oem7": toString = "'"; break;
                case "Oemcomma": toString = ","; break;
                case "OemPeriod": toString = "."; break;
                case "OemQuestion": toString = "/"; break;
                case "Return": toString = "Enter"; break;
                case "Scroll": toString = "ScrollLock"; break;
                case "LWin": toString = "Window"; break;
                case "HanjaMode": toString = "Hanja"; break;
                case "KanaMode": toString = "Kana"; break;
                case "Decimal": toString = "."; break;
                case "NumPad0": toString = "N0"; break;
                case "NumPad1": toString = "N1"; break;
                case "NumPad2": toString = "N2"; break;
                case "NumPad3": toString = "N3"; break;
                case "NumPad4": toString = "N4"; break;
                case "NumPad5": toString = "N5"; break;
                case "NumPad6": toString = "N6"; break;
                case "NumPad7": toString = "N7"; break;
                case "NumPad8": toString = "N8"; break;
                case "NumPad9": toString = "N9"; break;
                default: toString = keyString; break;
            }
            return toString;
        }

        private string SendKeysString(string keyString)
        {
            string[] key = keyString.Split('+');
            string toString = string.Empty;
            for (int i = 0; i < key.Length; i++)
            {
                switch (key[i])
                {
                    case "Ctrl": toString += "^"; break;
                    case "Alt": toString += "%"; break;
                    case "Shift": toString += "+"; break;
                    case "Space": toString += " "; break;
                    case "Back": toString += "{BACKSPACE}"; break;
                    case "CapsLock": toString += "{CAPSLOCK}"; break;
                    case "Delete": toString += "{DELETE}"; break;
                    case "↓": toString += "{DOWN}"; break;
                    case "End": toString += "{END}"; break;
                    case "Enter": toString += "{ENTER}"; break;
                    case "ESC": toString += "{ESC}"; break;
                    case "Home": toString += "{HOME}"; break;
                    case "Insert": toString += "{INSERT}"; break;
                    case "←": toString += "{LEFT}"; break;
                    case "NumLock": toString += "{NUMLOCK}"; break;
                    case "PageDown": toString += "{PGDN}"; break;
                    case "PageUp": toString += "{PGUP}"; break;
                    case "PrintScreen": toString += "{PRTSC}"; break;
                    case "→": toString += "{RIGHT}"; break;
                    case "ScrollLock": toString += "{SCROLLLOCK}"; break;
                    case "Tab": toString += "{TAB}"; break;
                    case "↑": toString += "{UP}"; break;
                    case "F1": toString += "{F1}"; break;
                    case "F2": toString += "{F2}"; break;
                    case "F3": toString += "{F3}"; break;
                    case "F4": toString += "{F4}"; break;
                    case "F5": toString += "{F5}"; break;
                    case "F6": toString += "{F6}"; break;
                    case "F7": toString += "{F7}"; break;
                    case "F8": toString += "{F8}"; break;
                    case "F9": toString += "{F9}"; break;
                    case "F10": toString += "{F10}"; break;
                    case "F11": toString += "{F11}"; break;
                    case "F12": toString += "{F12}"; break;
                    case "+": toString += "{ADD}"; break;
                    case "-": toString += "{SUBTRACT}"; break;
                    case "*": toString += "{MULTIPLY}"; break;
                    case "/": toString += "{DIVIDE}"; break;
                    default:
                        if (key[i].Length == 1 && key[i][0] >= 'A' && key[i][0] <= 'Z')
                            toString += key[i].ToLower();
                        else
                            toString += key[i]; break;
                }
            }
            return toString;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter sw;
            RoutineSaveFileDialog.Filter = "routine files (*.rt)|*.rt";
            RoutineSaveFileDialog.RestoreDirectory = true;

            if (RoutineOpenFileDialog.FileName != "")
            {
                fs = new FileStream(RoutineOpenFileDialog.FileName, FileMode.Create);
                sw = new StreamWriter(fs);
                for (int i = 0; i < ProcedureListBox.Items.Count; i++)
                {
                    sw.WriteLine(ProcedureListBox.Items[i].ToString());
                }
                sw.Flush();
                fs.Close();
            }
            else if (RoutineSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fs = new FileStream(RoutineSaveFileDialog.FileName, FileMode.Create);
                sw = new StreamWriter(fs);
                for (int i = 0; i < ProcedureListBox.Items.Count; i++)
                {
                    sw.WriteLine(ProcedureListBox.Items[i].ToString());
                }
                sw.Flush();
                fs.Close();
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            RoutineOpenFileDialog.InitialDirectory = "c:\\";
            RoutineOpenFileDialog.Filter = "routine files (*.rt)|*.rt";
            RoutineOpenFileDialog.RestoreDirectory = true;

            if (RoutineOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fs = new FileStream(RoutineOpenFileDialog.FileName, FileMode.Open);
                sr = new StreamReader(fs);
                for (int i = 0; sr.Peek() >= 0; i++)
                {
                    ProcedureListBox.Items.Add(sr.ReadLine());
                }
                sr.Close();
                fs.Close();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter sw;
            RoutineSaveFileDialog.Filter = "routine files (*.rt)|*.rt";
            RoutineSaveFileDialog.RestoreDirectory = true;

            if (RoutineSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fs = new FileStream(RoutineSaveFileDialog.FileName, FileMode.Create);
                sw = new StreamWriter(fs);
                for (int i = 0; i < ProcedureListBox.Items.Count; i++)
                {
                    sw.WriteLine(ProcedureListBox.Items[i].ToString());
                }
                sw.Flush();
                fs.Close();
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileStream fs = new FileStream(files[0], FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            for (int i = 0; sr.Peek() >= 0; i++)
            {
                ProcedureListBox.Items.Add(sr.ReadLine());
            }
            sr.Close();
            fs.Close();
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    xPosTextBox.Text = "" + Cursor.Position.X;
                    yPosTextBox.Text = "" + Cursor.Position.Y;
                    break;
            }
        }
    }
}

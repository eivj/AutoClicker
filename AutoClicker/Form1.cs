using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoClicker
{
    public partial class AutoClicker : Form
    {
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;

        private volatile bool _active = false;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        private const int HOTKEY_ID_Z = 1;
        private const int HOTKEY_ID_X = 2;
        private const int HOTKEY_ID_C = 3;

        private const int VK_Z = 0x5A;
        private const int VK_X = 0x58;
        private const int VK_C = 0x43;

        public AutoClicker()
        {
            InitializeComponent();   

            timer.Start();

            RegisterHotKey(this.Handle, HOTKEY_ID_Z, 0, VK_Z);
            RegisterHotKey(this.Handle, HOTKEY_ID_X, 0, VK_X);
            RegisterHotKey(this.Handle, HOTKEY_ID_C, 0, VK_C);

            textBoxSetCoordinateX.KeyPress += textBoxSetCoordinate_KeyPress;
            textBoxSetCoordinateY.KeyPress += textBoxSetCoordinate_KeyPress;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                int hotkeyId = m.WParam.ToInt32();

                if (hotkeyId == HOTKEY_ID_Z)
                {
                    IsStartClick();
                }
                else if (hotkeyId == HOTKEY_ID_X)
                {
                    if (_active)
                    {
                        _active = false;
                    }
                }
                else if(hotkeyId == HOTKEY_ID_C)
                {
                    textBoxSetCoordinateX.Text = textBoxCurrentCursorPositionX.Text;
                    textBoxSetCoordinateY.Text = textBoxCurrentCursorPositionY.Text;
                    MessageBox.Show("Координаты установлены!");
                }
            }
        }

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        /// <summary>
        /// Launches the clicker
        /// </summary>
        public void StartClick()
        {
            if (textBoxSetCoordinateX.Text != string.Empty && textBoxSetCoordinateY.Text != string.Empty)
            {        
                while (_active)
                {       
                    Cursor.Position = new Point(Convert.ToInt32(textBoxSetCoordinateX.Text), Convert.ToInt32(textBoxSetCoordinateY.Text));
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    Thread.Sleep(1);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                }
                MessageBox.Show("Кликер завершил работу!");
            }
        }

        /// <summary>
        /// Checking if the clicker is working
        /// </summary>
        public void IsStartClick()
        {
            if (!_active)
            {
                if (textBoxSetCoordinateX.Text != string.Empty && textBoxSetCoordinateY.Text != string.Empty)
                {
                    this.WindowState = FormWindowState.Minimized;
                    _active = true;
                    Thread threadClick = new Thread(StartClick);
                    threadClick.Start();
                }
                else
                {
                    MessageBox.Show("Установите координаты!");
                }
            }
            else
            {
                MessageBox.Show("Кликер уже работает!");
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            IsStartClick();
        }

        private void textBoxSetCoordinate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Disables string input
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            textBoxCurrentCursorPositionX.Text = Cursor.Position.X.ToString();
            textBoxCurrentCursorPositionY.Text = Cursor.Position.Y.ToString();
        }
    }
}

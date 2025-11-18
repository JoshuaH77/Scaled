using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Scaled
{
    public partial class Scaled : Form
    {
        public Scaled()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
            int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_MAXIMIZE = 3;


        static readonly IntPtr HWND_TOP = new IntPtr(0);
        const uint SWP_SHOWWINDOW = 0x0040;


        delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
        List<string> allWindows = new List<string>();

        private void Scaled_Load(object sender, EventArgs e)
        {
            LoadWindows();
        }
        //
        static void scale_window(string windowName)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;

            IntPtr hWnd = FindWindow(null, windowName);

            if (hWnd != IntPtr.Zero)
            {
                ShowWindow(hWnd, SW_MAXIMIZE);

                SetWindowPos(hWnd, HWND_TOP, 0, 0, width, height, SWP_SHOWWINDOW);
            }
            else
            {
                MessageBox.Show("window not found: " + windowName);
            }
        }
        private void scale_btn_Click(object sender, EventArgs e)
        {
            if (window_list.SelectedItem != null)
                scale_window(window_list.SelectedItem.ToString());
            else
                MessageBox.Show("please select a window first");
        }

        void LoadWindows()
        {

            window_list.Items.Clear();
            allWindows.Clear();

            progress_bar.Value = 0;
            progress_bar.Maximum = 100;
            progress_bar.Step = 1;

            EnumWindows((hWnd, lParam) =>
            {
                if (IsWindowVisible(hWnd))
                {
                    StringBuilder sb = new StringBuilder(256);
                    GetWindowText(hWnd, sb, sb.Capacity);

                    string title = sb.ToString();
                    if (!string.IsNullOrWhiteSpace(title))
                    {
                        if (title != "Scaled")
                        {
                            allWindows.Add(title);
                            window_list.Items.Add(title);
                        }
                    }
                }

                if (progress_bar.Value < progress_bar.Maximum)
                    progress_bar.PerformStep();

                return true;
            }, IntPtr.Zero);

            progress_bar.Value = progress_bar.Maximum;
        }
        //

        private void window_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            string search = search_box.Text.ToLower();
            window_list.Items.Clear();

            foreach (var win in allWindows)
                if (win.ToLower().Contains(search))
                    window_list.Items.Add(win);
        }

        private void progress_bar_Click(object sender, EventArgs e)
        {

        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            LoadWindows();
            search_box.Clear();
        }
    }
}

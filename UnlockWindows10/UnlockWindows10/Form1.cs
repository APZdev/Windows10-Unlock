using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;

namespace UnlockWindows10
{
    public partial class windowForm : Form
    {

        public windowForm()
        {
            InitializeComponent();
            dropDown.SelectedIndex = 0;
            nameLabel.Text = Environment.UserName;
            userImage.Image = GetUserImage();
            infomationText.Visible = false;
            UpdateStatusText();
        }

        #region Moving Bar
        bool isDragging;
        int movX;
        int movY;

        private void movingBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void movingBar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            movX = e.X;
            movY = e.Y;
        }

        private void movingBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        #endregion

        private void activateButton_Click(object sender, EventArgs e)
        {
            switch(dropDown.SelectedIndex)
            {
                case 0:
                    ExecCmdCommands("W269N-WFGWX-YVC9B-4J6C9-T83GX");
                    break;
                case 1:
                    ExecCmdCommands("KTNPV-KTRK4-3RRR8-39X6W-W44T3");
                    break;
                case 2:
                    ExecCmdCommands("NW6C2-QMPVW-D7KKK-3GKT6-VCFB2");
                    break;
                case 3:
                    ExecCmdCommands("NPPR9-FWDCX-D2C8J-H872K-2YT43");
                    break;
            }
        }

        private async void ExecCmdCommands(string key)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/c slmgr //b /ipk {key} /c slmgr /skms kms.digiboy.ir /c slmgr /ato";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();

            infomationText.ForeColor = Color.FromArgb(188, 195, 201);
            infomationText.Visible = true;
            infomationText.Text = "The process take seconds";

            UpdateStatusText();
            await Task.Delay(2000);
            infomationText.Visible = false;

            await Task.Delay(1000);
            infomationText.Visible = true;
            infomationText.ForeColor = Color.Green;
            infomationText.Text = "Success !";

            await Task.Delay(1500);
            infomationText.Visible = false;
        }

        private void UpdateStatusText()
        {
            bool status = IsWindowsActivated();
            statusText.Text = status ? "Activated" : "Not Activated";
            statusText.ForeColor = status ? Color.Green : Color.Red;
        }

        #region Get Windows Image
        //Code : https://stackoverflow.com/questions/7253833/c-sharp-get-user-picture-avatar
        //Get the image 
        [DllImport("shell32.dll", EntryPoint = "#261", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern void GetUserTilePath(string username,
                                                  /*0x80000000*/ UInt32 whatever, 
                                                  StringBuilder picpath, 
                                                  int maxLength);

        public static string GetUserTilePath()
        {   
            // username: use null for current user
            var finalPath = new StringBuilder(1000);
            GetUserTilePath(Environment.UserName, 0x80000000, finalPath, finalPath.Capacity);
            return finalPath.ToString();
        }

        //Return 
        public static Image GetUserImage()
        {
            return Image.FromFile(GetUserTilePath());
        }
        #endregion

        #region Get Windows License Status
        //Code : https://stackoverflow.com/questions/39231105/how-to-check-windows-license-status-in-c
        public static bool IsWindowsActivated()
        {
            //Get the largest scope to search 
            ManagementScope scope = new ManagementScope(@"\\" + Environment.MachineName + @"\root\cimv2");
            scope.Connect();

            SelectQuery searchQuery = new SelectQuery("SELECT * FROM SoftwareLicensingProduct WHERE ApplicationID = '55c92734-d682-4d71-983e-d6ec3f16059f' and LicenseStatus = 1");
            ManagementObjectSearcher searcherObj = new ManagementObjectSearcher(scope, searchQuery);
            //ManagementObjectSearcher xd = new ManagementObjectSearcher();

            using (ManagementObjectCollection obj = searcherObj.Get())
            {
                return obj.Count > 0;
            }
        }
        #endregion

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace AudioCodes_First_Task___Almog_Geva
{
    public partial class MainForm : Form
    {
        private string m_SelectedPath = null;
        private MongoDBCRUD m_mongoCRUD = new MongoDBCRUD("files");
        private readonly Extension r_FileExtension = Extension.mp3;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_OpenFolderBrowser_Click(object sender, EventArgs e)
        {
            var browsThread = new Thread((ThreadStart) =>
            {
                folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = false;
                folderBrowserDialog.ShowDialog();
                m_SelectedPath = folderBrowserDialog.SelectedPath;
            });

            browsThread.SetApartmentState(ApartmentState.STA);
            browsThread.Start();
            browsThread.Join();
        }


        private void button_UpdateMongoDB_Click(object sender, EventArgs e)
        {
            if (m_SelectedPath == null)
            {
                MessageBox.Show("Please Choose a File Path");
            }
            else if (checkedListBox_Files.Items.Count == 0)
            {
                MessageBox.Show("Please Fetch Files To Sync");
            }
            else
            {
                string tableName = string.Format("{0}_files", r_FileExtension.ToString());
                m_mongoCRUD.PopulateDB<IDirFile>(tableName, checkedListBox_Files.Items.OfType<IDirFile>().ToList());
                MessageBox.Show("Data Synced in: " + tableName);
            }
        }


        private void button_FetchFiles_Click(object sender, EventArgs e)
        {
            if (m_SelectedPath == null)
            {
                MessageBox.Show("Please Choose a File Path");
            }
            else
            {
                FileInfo pathCheck = new FileInfo(m_SelectedPath);

                List<IDirFile> filesListByExtension = FileExtract.GetDirFilesInfo(m_SelectedPath, r_FileExtension);

                if (filesListByExtension.Count == 0)
                {
                    MessageBox.Show(String.Format("No .{0} files were found in {1}", r_FileExtension.ToString(), m_SelectedPath));
                }
                else
                {
                    checkedListBox_Files.DataSource = filesListByExtension;
                    //UpdateListBox(filesListByExtension);
                    checkedListBox_Files.DisplayMember = "Name"; 
                    updateValidCheckedListBoxFiles();
                }
            }
        }

        private void updateValidCheckedListBoxFiles()
        {
            bool currItemValidity;

            for (int index = 0; index < checkedListBox_Files.Items.Count; index++)
            {
                currItemValidity = (checkedListBox_Files.Items[index] as Mp3File).IsValid; 
                checkedListBox_Files.SetItemChecked(index, currItemValidity);
            }
        }

        private void UpdateListBox(List<IDirFile> i_FilesList)
        {
            foreach (var item in i_FilesList)
            {
                checkedListBox_Files.Items.Add(item);
            }
        }

        private void checkedListBox_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFileInfoLabels();
        }

        private void updateFileInfoLabels()
        {
            panel_InnerInfoPanel.Visible = true;
            int selectedIndex = checkedListBox_Files.SelectedIndex;
            try
            {
                Mp3File fileMask = checkedListBox_Files.Items[selectedIndex] as Mp3File;
                label_FileNameLabel.Text = fileMask.Name;
                label_FileLengthLabel.Text = fileMask.Length.ToString();
                label_FileSizeLabel.Text = fileMask.ByteSize.ToString();
                label_FileValidLabel.Text = fileMask.IsValid.ToString();
            }
            catch( Exception)
            {
                string defaultValue = "Not-Found";
                label_FileNameLabel.Text = defaultValue;
                label_FileLengthLabel.Text = defaultValue;
                label_FileSizeLabel.Text = defaultValue;
                label_FileValidLabel.Text = defaultValue;
           }            
        }

        private void checkedListBox_Files_ItemCheck(object sender, ItemCheckEventArgs e)
        {            
            int selectedIndex = checkedListBox_Files.SelectedIndex;

            if (selectedIndex != -1)
            {
                (checkedListBox_Files.Items[selectedIndex] as Mp3File).IsValid = e.NewValue == CheckState.Checked;
                m_mongoCRUD.UpdateAndReplaceRecord(m_mongoCRUD.LastUsedTable, (checkedListBox_Files.Items[selectedIndex] as Mp3File));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assigment_2_Daniel_Copin
{
    public partial class Text_Editor : Form
    {
        public Text_Editor()
        {
            InitializeComponent();
        }

        //Close Function
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Help Function
        private void help_Click(object sender, EventArgs e)
        {

        }

        //Bold Function
        private void bold_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Bold);
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Italic Function
        private void italic_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Italic);
        }

        //Underline Function
        private void underline_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.Font, FontStyle.Underline);
        }


        //Copy Function ToolStripButton
        private void copy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }           
        }

        //Cut Function ToolStripButton
        private void cut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        //Paste Function ToolStripButton
        private void paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                richTextBox1.Paste();
            }
        }

        //Cut Function Menu
        private void cutMenu_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)

                richTextBox1.Cut();
        }

        //Copy Function Menu
        private void copyMenu_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        //Paste Function Menu
        private void pasteMenu_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                richTextBox1.Paste();
            }
        }

        //Size Function 
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if((string)toolStripComboBox1.SelectedItem == "8")
            {
                string fontName = richTextBox1.SelectionFont.Name;
                richTextBox1.SelectionFont = new Font(fontName, 8);
            }
            else if ((string)toolStripComboBox1.SelectedItem == "10")
            {
                string fontName = richTextBox1.SelectionFont.Name;
                richTextBox1.SelectionFont = new Font(fontName, 10);
            }
            else if ((string)toolStripComboBox1.SelectedItem == "12")
            {
                string fontName = richTextBox1.SelectionFont.Name;
                richTextBox1.SelectionFont = new Font(fontName, 12);
            }
            else if ((string)toolStripComboBox1.SelectedItem == "14")
            {
                string fontName = richTextBox1.SelectionFont.Name;
                richTextBox1.SelectionFont = new Font(fontName, 14);
            }
            else if ((string)toolStripComboBox1.SelectedItem == "16")
            {
                string fontName = richTextBox1.SelectionFont.Name;
                richTextBox1.SelectionFont = new Font(fontName, 16);
            }
            else if ((string)toolStripComboBox1.SelectedItem == "18")
            {
                string fontName = richTextBox1.SelectionFont.Name;
                richTextBox1.SelectionFont = new Font(fontName, 18);
            }
            else
            {
                string fontName = richTextBox1.SelectionFont.Name;
                richTextBox1.SelectionFont = new Font(fontName, 20);
            }
        }

        //New Function ToolStripButton
        private void new_Click(object sender, EventArgs e)
        {
                richTextBox1.SelectAll();
                richTextBox1.SelectedText = "";
        }

        //Open Function ToolStripButton
        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "c:\\";

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            ofd.FilterIndex = 2;

            ofd.RestoreDirectory = true;



            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(ofd.FileName);

                richTextBox1.Find("Text", RichTextBoxFinds.MatchCase);

                richTextBox1.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);

                richTextBox1.SelectionColor = Color.Red;
            }
        }

        //Save Function ToolStripButton
        private void save_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:\Users\Daniel\Desktop\SavedRTF.rtf", RichTextBoxStreamType.RichText);
        }


        //Open Function Menu
        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "c:\\";

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            ofd.FilterIndex = 2;

            ofd.RestoreDirectory = true;


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(ofd.FileName);

                richTextBox1.Find("Text", RichTextBoxFinds.MatchCase);

                richTextBox1.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);

                richTextBox1.SelectionColor = Color.Red;
            }
        }

        //Save Function Menu
        private void saveMenu_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:\Users\Daniel\Desktop\SavedRTF.rtf", RichTextBoxStreamType.RichText);
        }


        //Save As Function ToolStripButton
        private void saveAs_Click(object sender, EventArgs e)
        {

            /*OpenFileDialog ofd = new OpenFileDialog();
            richTextBox1.SaveFile(ofd.FileName);*/
            //richTextBox1.SaveFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)+ @"\Testdoc.rtf",RichTextBoxStreamType.RichNoOleObjs);

            //richTextBox1.SaveFile(@"C:\Users\Daniel\Desktop\SavedRTF.rtf", RichTextBoxStreamType.RichText);

            // Text from the rich textbox rtfMain
            string chaine = richTextBox1.Text;
            // Create a new SaveFileDialog object
            using (SaveFileDialog saveDialog = new SaveFileDialog())
                try
                {
                    // Available file extensions
                    saveDialog.Filter = "All Files (.)|*.*";
                    // SaveFileDialog title
                    saveDialog.Title = "Save";
                    // Show SaveFileDialog
                    if (saveDialog.ShowDialog() == DialogResult.OK && saveDialog.FileName.Length > 0)
                    {
                        // Save file as utf8 without byte order mark (BOM)

                        UTF8Encoding encode = new UTF8Encoding();
                        StreamWriter swriter = new StreamWriter(saveDialog.FileName, false, encode);
                        swriter.Write(chaine);
                        swriter.Close();
                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show(errorMessage.Message);
                }
        }

        //New Function Menu
        private void newMenu_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectedText = "";
        }

        //Save As Function Menu
        private void saveAsMenu_Click(object sender, EventArgs e)
        {

            /*OpenFileDialog ofd = new OpenFileDialog();
            richTextBox1.SaveFile(ofd.FileName);*/
            //richTextBox1.SaveFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)+ @"\Testdoc.rtf",RichTextBoxStreamType.RichNoOleObjs);

            //richTextBox1.SaveFile(@"C:\Users\Daniel\Desktop\SavedRTF.rtf", RichTextBoxStreamType.RichText);

            // Text from the rich textbox rtfMain
            string chaine = richTextBox1.Text;
            // Create a new SaveFileDialog object
            using (SaveFileDialog saveDialog = new SaveFileDialog())
                try
                {
                    // Available file extensions
                    saveDialog.Filter = "All Files (.)|*.*";
                    // SaveFileDialog title
                    saveDialog.Title = "Save";
                    // Show SaveFileDialog
                    if (saveDialog.ShowDialog() == DialogResult.OK && saveDialog.FileName.Length > 0)
                    {
                        // Save file as utf8 without byte order mark (BOM)

                        UTF8Encoding encode = new UTF8Encoding();
                        StreamWriter swriter = new StreamWriter(saveDialog.FileName, false, encode);
                        swriter.Write(chaine);
                        swriter.Close();
                    }
                }
                catch (Exception errorMessage)
                {
                    MessageBox.Show(errorMessage.Message);
                }
        }
    } 
}

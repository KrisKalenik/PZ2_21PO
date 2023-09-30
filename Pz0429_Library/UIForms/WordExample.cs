using Pz0429_Library.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pz0429_Library.UIForms
{
    public partial class WordExample : Form
    {
        WordDocument _wordDocument = null;
        String path = null;

        public WordExample()
        {
            InitializeComponent();
        }

        private string pathToTemplate
        {
            get
            {
                if (path == null)
                    return $@"{Application.StartupPath}\{tbTemplateName.Text}";
                return path;
            }
        }

        private void btnOpenTemplate_Click(object sender, EventArgs e)
        {
            if (ofdWordTemplate.ShowDialog() == DialogResult.OK)
            {
                tbTemplateName.Text = ofdWordTemplate.SafeFileName;
                path = ofdWordTemplate.FileName;
            }
        }

        private void btnOpenEmptyDoc_Click(object sender, EventArgs e)
        {
            try
            {
                _wordDocument = new WordDocument(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenTemplateDoc_Click(object sender, EventArgs e)
        {
            try
            {
                _wordDocument = new WordDocument(pathToTemplate);
                btnTextReplace.Enabled = true;
                btnInsert.Enabled = true;
                btnInsertTextToBookmark.Enabled = true;
                btnFormat.Enabled = true;
                gbTableFunctions.Visible = true;
                btnInsertImg.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            _wordDocument.Visible = true;
        }

        private void WordExample_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_wordDocument != null &&
                !_wordDocument.Closed)
                _wordDocument.Close();
        }

        private void btnTextReplace_Click(object sender, EventArgs e)
        {
            if (_wordDocument != null)
            {
                try
                {
                    if (cbReplaceAll.Checked)
                        _wordDocument.ReplaceAllStrings(tbTextToFind.Text,
                            tbReplaceText.Text);
                    else
                    {
                        _wordDocument.ReplaceFirstString(tbTextToFind.Text,
                            tbReplaceText.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnInsertTextToBookmark_Click(object sender, EventArgs e)
        {
            try
            {
                _wordDocument.SetSelectionToBookmark(tbBookmarkName.Text, cbAsParagraph.Checked);
                _wordDocument.Selection.Text = tbInsertText.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(_wordDocument, complexTextInsert);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void complexTextInsert(WordDocument word)
        {
            if (rbBookmark.Checked)
                word.SetSelectionToBookmark(tbBookmarkName.Text);
            else word.SetSelectionToBegin();

            word.InsertParagrephAfter(tbInsertText.Text);
            word.InsertParagrephAfter();
            word.InsertParagrephAfter("New Text");
            word.Selection.Bold = true;
            word.Selection.Italic = true;
            word.Selection.FontSize = 20;
            word.Selection.Aligment = Office.TextAligment.Center;
            word.Selection.Border = Office.BorderStyle.Double;
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(_wordDocument, searchAndFormatText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchAndFormatText(WordDocument word)
        {
            string toFormatStr = tbTextToChangeFormat.Text;

            if (cbFindIn.Checked)
                word.SetSelectionToText(tbContainerString.Text, toFormatStr);
            else word.SetSelectionToText(toFormatStr);

            word.Selection.Bold = cbIsBold.Checked;

            if (cbIsAtCenter.Checked)
                word.Selection.Aligment = TextAligment.Center;

            word.Selection.FontSize = (int)nudFontSize.Value;
        }

        private void btnInsertTable_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(_wordDocument, insertTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertTable(WordDocument word)
        {
            word.SetSelectionToBookmark(tbBookmarkName.Text);

            if (cbNoBorders.Checked)
                word.InsertTable(3, 3, Office.BorderStyle.None);
            word.InsertTable(3, 3);
            word.SetSelectionToCell(1, 1);
            word.Selection.Text = "First Value";
        }

        private void btnInsertIntoTable_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(_wordDocument, fillExistingTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillExistingTable(WordDocument word)
        {
            int n = (int)nudTableId.Value;

            word.SetSelectionToCell(n, 1, 1);
            word.Selection.Text = "First Value";

            int addRows = (int)nudRowNumber.Value;

            for(int i = 1; i<= addRows; i++)
            {
                word.AddRowToTable();
                word.SetSelectionToCell(word.NumberOfRows(), 1);
                word.Selection.Text = $"{word.NumberOfRows()} row";
            }
        }

        private void btnInsertTemplateTable_Click(object sender, EventArgs e)
        {
            try
            {
                WordDocument.FillShowTemplate(_wordDocument, insertTamolAndFill);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertTamolAndFill(WordDocument word)
        {
            WordDocument templDoc = null;

            try
            {
                templDoc = new WordDocument(pathToTemplate);
                for(int i = 1; i <= nudTableNumber.Value; i++)
                {
                    templDoc.Visible = true;
                    complexTextInsert(templDoc);
                    templDoc.InsertPageAfterEnd();
                    //templDoc.Save(pathToTemplate);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertImg_Click(object sender, EventArgs e)
        {
            if (rbBookmark.Checked)
                _wordDocument.SetSelectionToBookmark(tbBookmarkName.Text);
            else _wordDocument.SetSelectionToBegin();

            _wordDocument.InsertImage(tbImagePath.Text);

        }
    }
}

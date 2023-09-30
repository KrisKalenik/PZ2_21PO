//using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Word = Microsoft.Office.Interop.Word;


namespace Pz0429_Library.Office
{
    internal class WordDocument
    {
        Word._Application _application;
        Word._Document _document;

        Object _missingObj = System.Reflection.Missing.Value;
        Object _trueObj = true;
        Object _falseObj = false;

        Object _templatePathObj = null;

        Word.Table _table = null;
        Word.Range _currentRange = null;

        WordSelection _selection;

        public WordDocument(bool startVisible)
        {
            _application = new Word.Application();
            try
            {
                _document = _application.Documents.
                    Add(ref _missingObj, ref _missingObj,
                    ref _missingObj, ref _missingObj);
            }
            catch(Exception ex)
            {
                this.Close();
                throw ex;
            }

            Visible = startVisible;
            
        }

        public WordDocument() : this(false) { }

        public WordDocument(string templatePath, bool startVisible)
        {
            _application = new Word.Application();
            _templatePathObj = templatePath;
            try
            {
                _document = _application.Documents.
                    Add(ref _templatePathObj, ref _missingObj,
                    ref _missingObj, ref _missingObj);
            }
            catch(Exception ex)
            {
                this.Close();
                throw ex;
            }
        }

        public WordDocument(string templatePath) : this(templatePath, false) { }

        public bool Visible
        {
            get
            {
                if (Closed) throw new Exception("Error during changing visability");
                return _application.Visible;
            }
            set
            {
                if (Closed) throw new Exception("Error during changing visability");
                _application.Visible = value;
            }
        }

        public bool Closed
        {
            get
            {
                if (_application == null || _document == null)
                    return true;
                return false;
            }
        }

        public WordSelection Selection
        {
            get
            {
                return _selection;
            }
        }

        public void Close()
        {
            try
            {
                if(_document != null)
                    _document.Close(ref _falseObj, ref _missingObj,
                        _missingObj);
                _application.Quit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _document = null;
                _application = null;
            }
        }

        public void Save(string path)
        {
            Object pathObj = path;
            _document.SaveAs(ref pathObj, 
                Word.WdSaveFormat.wdFormatDocument,
                ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj, ref _missingObj,
                ref _missingObj, ref _missingObj);
        }

        public void SetSelectionToBegin()
        {
            object start = 0;
            object end = 0;
            _currentRange = _document.Range(ref start, ref end);
            _selection = new WordSelection(_currentRange);
        }

        public void SetSelectionToText(string strToFind)
        {
            if (this.Closed) throw new Exception("Doc Closed");
            Word.Range range = null;

            range = findRangeByString(strToFind);
            if (range != null)
            {
                _currentRange = range;
                _selection = new WordSelection(_currentRange, false);
            }
            else throw new Exception("No Matches");  
        }

        public void SetSelectionToText(string strContainer, string strToFind)
        {
            if (this.Closed) throw new Exception("Doc Closed");
            Word.Range rangeContainer = null;
            Word.Range range = null;

            rangeContainer = findRangeByString(strContainer);
            if (rangeContainer != null)
                range = findRangeByString(rangeContainer, strToFind);

            if (range != null)
            {
                _currentRange = range;
                _selection = new WordSelection(_currentRange, false);
            }
            else throw new Exception("No Matches");
        }

        private Word.Range findRangeByString(Word.Range rangeContainer, string strToFind)
        {
            if (this.Closed) throw new Exception("Doc Closed");
            object strToFindObj = strToFind;
            bool wasFound = false;

            wasFound = rangeContainer.Find.Execute(strToFind, 
                _missingObj, _missingObj, _missingObj,
                _missingObj, _missingObj, _missingObj,
                _missingObj, _missingObj, _missingObj,
                _missingObj, _missingObj, _missingObj,
                _missingObj, _missingObj);

            if (wasFound) return rangeContainer;
            return null;

        }

        private Word.Range findRangeByString(string strToFind)
        {
            if (this.Closed) throw new Exception("Doc Closed");
            object strToFindObj = strToFind;
            Word.Range rangeContainer = null;
            bool wasFound = false;
            foreach (Word.Section section in _document.Sections)
            {
                rangeContainer = section.Range;
                wasFound = rangeContainer.Find.Execute(strToFind,
                    _missingObj, _missingObj, _missingObj,
                    _missingObj, _missingObj, _missingObj,
                    _missingObj, _missingObj, _missingObj,
                    _missingObj, _missingObj, _missingObj,
                    _missingObj, _missingObj);
                if (wasFound) return rangeContainer;
            }

            return null;

        }

        public void ReplaceFirstString(string strToFind, string strToReplace)
        {
            if (this.Closed) throw new Exception("Doc Closed");

            SetSelectionToText(strToFind);
            Selection.Text = strToReplace;
        }

        public void ReplaceAllStrings(string strToFind, string strToReplace)
        {
            if (this.Closed) throw new Exception("Doc Closed");

            object strToFindObj = strToFind;
            object strToReplaceObj = strToReplace;

            Word.Range range = null;
            object replaceTypeObj = Word.WdReplace.wdReplaceAll;

            try
            {
                foreach(Word.Section section in _document.Sections)
                {
                    range = section.Range;
                    Word.Find find = range.Find;

                    object[] wFindParams 
                        = { strToFindObj, _missingObj, _missingObj,
                    _missingObj, _missingObj, _missingObj,
                    _missingObj, _missingObj, _missingObj,
                    strToReplaceObj, replaceTypeObj, _missingObj,
                    _missingObj, _missingObj, _missingObj};

                    find.GetType().
                        InvokeMember("Execute", System.Reflection.BindingFlags.InvokeMethod,
                        null, find, wFindParams);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void SetSelectionToBookmark(string bookmarkName, bool isParagraph)
        {
            if (this.Closed) throw new Exception("Doc Closed");

            Object bookmarkObj = bookmarkName;
            Word.Range range = null;

            try
            {
                range = _document.Bookmarks.get_Item(ref bookmarkObj).Range;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            _currentRange = range;
            _selection = new WordSelection(_currentRange, isParagraph);
        }

        public void SetSelectionToBookmark(string bookmarkName)
        {
            SetSelectionToBookmark(bookmarkName, false);
        }

        public void InsertParagrephAfter()
        {
            if (this.Closed) throw new Exception("Doc Closed");

            Object collapseDir = Word.WdCollapseDirection.wdCollapseEnd;
            try
            {
                _currentRange.Collapse(collapseDir);
                _currentRange.InsertParagraphAfter();
                _selection = new WordSelection(_currentRange);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InsertParagrephAfter(string strToInsert)
        {
            InsertParagrephAfter();
            this.Selection.Text = strToInsert;
        }

        public void InsertPageAfterEnd()
        {
            object what = Word.WdGoToItem.wdGoToLine;
            object which = Word.WdGoToDirection.wdGoToLast;
            Word.Range range = _document.GoTo(ref what, ref which,
                ref _missingObj, ref _missingObj);
            range.InsertBreak(Word.WdBreakType.wdPageBreak);
            InsertParagrephAfter();
        }

        public void InsertTable(int numRows, int numCol, BorderStyle border)
        {
            _table = _document.Tables.Add(_currentRange, numRows, numCol,
                ref _missingObj, ref _missingObj);
            switch (border)
            {
                case BorderStyle.Double:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
                    break;
                case BorderStyle.Single:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    break;
                default:
                    _table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                    _table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleNone;
                    break;    
            }

            _currentRange = _table.Range;
            _selection = new WordSelection(_currentRange, false);
        }

        public void InsertTable(int numRows, int numCol)
        {
            InsertTable(numRows, numCol, BorderStyle.Single);
        }

        public void SetColumnWidth(int id, int width)
        {
            if (_table == null) throw new Exception("Error");
            _table.Columns[id].SetWidth(width, Word.WdRulerStyle.wdAdjustNone);
        }

        public void SetSelectionToTable(int table)
        {
            try
            {
                _table = _document.Tables[table];
            }
            catch(Exception ex)
            {
                throw ex;
            }
            _currentRange = _table.Range;
            _selection = new WordSelection(_currentRange, false);
        }

        public void SetSelectionToCell(int row, int column)
        {
            if (_table == null) throw new Exception("Error");
            _currentRange = _table.Cell(row, column).Range;
            _selection = new WordSelection(_currentRange, false);
        }

        public void SetSelectionToCell(int table, int row, int column)
        {
            SetSelectionToTable(table);
            SetSelectionToCell(row, column);
        }

        public void AddRowToTable()
        {
            if (_table == null) throw new Exception("Error");
            _table.Rows.Add(ref _missingObj);
        }

        public int NumberOfRows()
        {
            if (_table == null) throw new Exception("Error");
            return _table.Rows.Count;
        }

        public static void FillShowTemplate(WordDocument word, Action<WordDocument> fillWordDoc)
        {
            try
            {
                fillWordDoc(word);
                word.Visible = true;
            }
            catch (Exception ex)
            {
                if (word != null) word.Close();
                throw ex;
            }
        }

        public void InsertImage(string imagePath)
        {
            if (this.Closed) throw new Exception("Doc Closed");

            
            try
            {
                _currentRange.InlineShapes.AddPicture(
                    imagePath, ref _missingObj, ref _missingObj, _currentRange);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
namespace Pz0429_Library.Office
{
    public enum TextAligment { Left, Center, Right, Justify }

    public enum BorderStyle { None, Single, Double }

    internal class WordSelection
    {
        private Word.Range _range;
        private bool _insertParagrAfterText = true;

        private Word.WdParagraphAlignment _savedAligment;

        public WordSelection(Word.Range inputRange ):
            this(inputRange, true, true)
        {

        }

        public WordSelection(Word.Range inputRange, bool insertParagraphAfterText):
            this(inputRange, insertParagraphAfterText, true)
        {

        }

        public WordSelection(Range inputRange, bool insertParagrAfterText, bool setDefaultStyle) 
        {
            _range = inputRange;
            _insertParagrAfterText = insertParagrAfterText;

            if (setDefaultStyle)
            {
                _range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                _savedAligment = _range.ParagraphFormat.Alignment;
                _range.Italic = 0;
                //_range.Bold = 0;
                Bold = false;
            }
            else
            {
                _savedAligment = _range.ParagraphFormat.Alignment;
            }
        }

        public bool Bold
        {
            get
            {
                if (_range.Bold == 1) return true;
                return false;
            }
            set
            {
                if (value == true) _range.Bold = 1;
                else _range.Bold = 0;
            }
        }

        public bool Italic
        {
            get
            {
                if (_range.Italic == 1) return true;
                return false;
            }
            set
            {
                if (value == true) _range.Italic = 1;
                else _range.Italic = 0;
            }
        }

        public TextAligment Aligment
        {
            get
            {
                if (_range.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphLeft)
                    return TextAligment.Left;
                else if (_range.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphRight)
                    return TextAligment.Right;
                else if (_range.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphCenter)
                    return TextAligment.Center;
                else if (_range.ParagraphFormat.Alignment == Word.WdParagraphAlignment.wdAlignParagraphJustify)
                    return TextAligment.Justify;
                else throw new Exception("error when determining the type of alignment");
            }
            set
            {
                if (value == TextAligment.Left)
                    _range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                else if (value == TextAligment.Right)
                    _range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                else if (value == TextAligment.Center)
                    _range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                else if (value == TextAligment.Justify)
                    _range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;

                else throw new Exception("error when determining the type of alignment");



                _savedAligment = _range.ParagraphFormat.Alignment;
            }
        }

        public BorderStyle Border
        {
            get
            {
                switch(_range.Borders.OutsideLineStyle)
                {
                    case WdLineStyle.wdLineStyleNone:
                        return BorderStyle.None;

                    case WdLineStyle.wdLineStyleSingle:
                        return BorderStyle.Single;

                    case WdLineStyle.wdLineStyleDouble:
                        return BorderStyle.Double;

                    default:
                        throw new Exception("-------");
                }
            }

            set
            {
                switch (value)
                {
                    case BorderStyle.None:
                        _range.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleNone;
                        break;

                    case BorderStyle.Single:
                        _range.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                        break;

                    case BorderStyle.Double:
                        _range.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;
                        break;

                    default:
                        throw new Exception("-------");

                }
            }
        }

        public string Text
        {
            get { return _range.Text; }
            set
            {
                _range.Text = value;
                if (_insertParagrAfterText)
                    _range.InsertParagraphAfter();
                _range.ParagraphFormat.Alignment = this._savedAligment;
            }
        }

        public int FontSize
        {
            get { return Convert.ToInt32(_range.Font.Size); }
            set
            {
                if (value < 8)
                    throw new Exception("Wrong Font Size");
                float fontSize = Convert.ToSingle(value);
                _range.Font.Size = fontSize;
            }
        }
    }
}

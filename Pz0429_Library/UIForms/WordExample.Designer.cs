namespace Pz0429_Library.UIForms
{
    partial class WordExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTableFunctions = new System.Windows.Forms.GroupBox();
            this.btnInsertTemplateTable = new System.Windows.Forms.Button();
            this.btnInsertIntoTable = new System.Windows.Forms.Button();
            this.nudTableNumber = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudRowNumber = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudTableId = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInsertTable = new System.Windows.Forms.Button();
            this.cbNoBorders = new System.Windows.Forms.CheckBox();
            this.cbFindIn = new System.Windows.Forms.CheckBox();
            this.cbIsAtCenter = new System.Windows.Forms.CheckBox();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIsItalic = new System.Windows.Forms.CheckBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.tbTextToChangeFormat = new System.Windows.Forms.TextBox();
            this.tbContainerString = new System.Windows.Forms.TextBox();
            this.cbIsBold = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rbBeforText = new System.Windows.Forms.RadioButton();
            this.rbBookmark = new System.Windows.Forms.RadioButton();
            this.cbAsParagraph = new System.Windows.Forms.CheckBox();
            this.btnInsertTextToBookmark = new System.Windows.Forms.Button();
            this.tbInsertText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBookmarkName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbReplaceAll = new System.Windows.Forms.CheckBox();
            this.btnTextReplace = new System.Windows.Forms.Button();
            this.tbReplaceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTextToFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenTemplateDoc = new System.Windows.Forms.Button();
            this.btnOpenEmptyDoc = new System.Windows.Forms.Button();
            this.tbTemplateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenTemplate = new System.Windows.Forms.Button();
            this.ofdWordTemplate = new System.Windows.Forms.OpenFileDialog();
            this.btnInsertImg = new System.Windows.Forms.Button();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            this.gbTableFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTableFunctions
            // 
            this.gbTableFunctions.Controls.Add(this.btnInsertTemplateTable);
            this.gbTableFunctions.Controls.Add(this.btnInsertIntoTable);
            this.gbTableFunctions.Controls.Add(this.nudTableNumber);
            this.gbTableFunctions.Controls.Add(this.label10);
            this.gbTableFunctions.Controls.Add(this.nudRowNumber);
            this.gbTableFunctions.Controls.Add(this.label9);
            this.gbTableFunctions.Controls.Add(this.nudTableId);
            this.gbTableFunctions.Controls.Add(this.label8);
            this.gbTableFunctions.Controls.Add(this.btnInsertTable);
            this.gbTableFunctions.Controls.Add(this.cbNoBorders);
            this.gbTableFunctions.Location = new System.Drawing.Point(12, 378);
            this.gbTableFunctions.Name = "gbTableFunctions";
            this.gbTableFunctions.Size = new System.Drawing.Size(595, 138);
            this.gbTableFunctions.TabIndex = 63;
            this.gbTableFunctions.TabStop = false;
            this.gbTableFunctions.Text = "Table";
            this.gbTableFunctions.Visible = false;
            // 
            // btnInsertTemplateTable
            // 
            this.btnInsertTemplateTable.Location = new System.Drawing.Point(189, 97);
            this.btnInsertTemplateTable.Name = "btnInsertTemplateTable";
            this.btnInsertTemplateTable.Size = new System.Drawing.Size(151, 23);
            this.btnInsertTemplateTable.TabIndex = 40;
            this.btnInsertTemplateTable.Text = "Insert Template";
            this.btnInsertTemplateTable.UseVisualStyleBackColor = true;
            this.btnInsertTemplateTable.Click += new System.EventHandler(this.btnInsertTemplateTable_Click);
            // 
            // btnInsertIntoTable
            // 
            this.btnInsertIntoTable.Location = new System.Drawing.Point(315, 59);
            this.btnInsertIntoTable.Name = "btnInsertIntoTable";
            this.btnInsertIntoTable.Size = new System.Drawing.Size(151, 23);
            this.btnInsertIntoTable.TabIndex = 39;
            this.btnInsertIntoTable.Text = "Insert Into Table";
            this.btnInsertIntoTable.UseVisualStyleBackColor = true;
            this.btnInsertIntoTable.Click += new System.EventHandler(this.btnInsertIntoTable_Click);
            // 
            // nudTableNumber
            // 
            this.nudTableNumber.Location = new System.Drawing.Point(117, 100);
            this.nudTableNumber.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTableNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTableNumber.Name = "nudTableNumber";
            this.nudTableNumber.Size = new System.Drawing.Size(66, 20);
            this.nudTableNumber.TabIndex = 38;
            this.nudTableNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "number of new sheets:";
            // 
            // nudRowNumber
            // 
            this.nudRowNumber.Location = new System.Drawing.Point(243, 62);
            this.nudRowNumber.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRowNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRowNumber.Name = "nudRowNumber";
            this.nudRowNumber.Size = new System.Drawing.Size(66, 20);
            this.nudRowNumber.TabIndex = 36;
            this.nudRowNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "number of rows:";
            // 
            // nudTableId
            // 
            this.nudTableId.Location = new System.Drawing.Point(68, 62);
            this.nudTableId.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTableId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTableId.Name = "nudTableId";
            this.nudTableId.Size = new System.Drawing.Size(66, 20);
            this.nudTableId.TabIndex = 34;
            this.nudTableId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Table N:";
            // 
            // btnInsertTable
            // 
            this.btnInsertTable.Location = new System.Drawing.Point(117, 24);
            this.btnInsertTable.Name = "btnInsertTable";
            this.btnInsertTable.Size = new System.Drawing.Size(151, 23);
            this.btnInsertTable.TabIndex = 33;
            this.btnInsertTable.Text = "Insert New Table";
            this.btnInsertTable.UseVisualStyleBackColor = true;
            this.btnInsertTable.Click += new System.EventHandler(this.btnInsertTable_Click);
            // 
            // cbNoBorders
            // 
            this.cbNoBorders.AutoSize = true;
            this.cbNoBorders.Location = new System.Drawing.Point(13, 28);
            this.cbNoBorders.Name = "cbNoBorders";
            this.cbNoBorders.Size = new System.Drawing.Size(98, 17);
            this.cbNoBorders.TabIndex = 33;
            this.cbNoBorders.Text = "without borders";
            this.cbNoBorders.UseVisualStyleBackColor = true;
            // 
            // cbFindIn
            // 
            this.cbFindIn.AutoSize = true;
            this.cbFindIn.Location = new System.Drawing.Point(18, 238);
            this.cbFindIn.Name = "cbFindIn";
            this.cbFindIn.Size = new System.Drawing.Size(77, 17);
            this.cbFindIn.TabIndex = 62;
            this.cbFindIn.Text = "find in row:";
            this.cbFindIn.UseVisualStyleBackColor = true;
            // 
            // cbIsAtCenter
            // 
            this.cbIsAtCenter.AutoSize = true;
            this.cbIsAtCenter.Location = new System.Drawing.Point(321, 336);
            this.cbIsAtCenter.Name = "cbIsAtCenter";
            this.cbIsAtCenter.Size = new System.Drawing.Size(57, 17);
            this.cbIsAtCenter.TabIndex = 61;
            this.cbIsAtCenter.Text = "Center";
            this.cbIsAtCenter.UseVisualStyleBackColor = true;
            // 
            // nudFontSize
            // 
            this.nudFontSize.Location = new System.Drawing.Point(183, 333);
            this.nudFontSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudFontSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(66, 20);
            this.nudFontSize.TabIndex = 60;
            this.nudFontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Font size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Text to find and change format:";
            // 
            // cbIsItalic
            // 
            this.cbIsItalic.AutoSize = true;
            this.cbIsItalic.Location = new System.Drawing.Point(71, 334);
            this.cbIsItalic.Name = "cbIsItalic";
            this.cbIsItalic.Size = new System.Drawing.Size(48, 17);
            this.cbIsItalic.TabIndex = 57;
            this.cbIsItalic.Text = "Italic";
            this.cbIsItalic.UseVisualStyleBackColor = true;
            // 
            // btnFormat
            // 
            this.btnFormat.Enabled = false;
            this.btnFormat.Location = new System.Drawing.Point(375, 308);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(151, 23);
            this.btnFormat.TabIndex = 56;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // tbTextToChangeFormat
            // 
            this.tbTextToChangeFormat.Location = new System.Drawing.Point(12, 308);
            this.tbTextToChangeFormat.Name = "tbTextToChangeFormat";
            this.tbTextToChangeFormat.Size = new System.Drawing.Size(351, 20);
            this.tbTextToChangeFormat.TabIndex = 55;
            this.tbTextToChangeFormat.Text = "Word";
            // 
            // tbContainerString
            // 
            this.tbContainerString.Location = new System.Drawing.Point(12, 261);
            this.tbContainerString.Name = "tbContainerString";
            this.tbContainerString.Size = new System.Drawing.Size(351, 20);
            this.tbContainerString.TabIndex = 54;
            this.tbContainerString.Text = "Этот объект представляет текущий экземпляр Word. Объект Application содержит объе" +
    "кты Document, Selection, Bookmark и Range";
            // 
            // cbIsBold
            // 
            this.cbIsBold.AutoSize = true;
            this.cbIsBold.Location = new System.Drawing.Point(18, 334);
            this.cbIsBold.Name = "cbIsBold";
            this.cbIsBold.Size = new System.Drawing.Size(47, 17);
            this.cbIsBold.TabIndex = 53;
            this.cbIsBold.Text = "Bold";
            this.cbIsBold.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(369, 173);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(151, 23);
            this.btnInsert.TabIndex = 52;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // rbBeforText
            // 
            this.rbBeforText.AutoSize = true;
            this.rbBeforText.Location = new System.Drawing.Point(278, 170);
            this.rbBeforText.Name = "rbBeforText";
            this.rbBeforText.Size = new System.Drawing.Size(69, 17);
            this.rbBeforText.TabIndex = 51;
            this.rbBeforText.Text = "befor text";
            this.rbBeforText.UseVisualStyleBackColor = true;
            // 
            // rbBookmark
            // 
            this.rbBookmark.AutoSize = true;
            this.rbBookmark.Checked = true;
            this.rbBookmark.Location = new System.Drawing.Point(163, 170);
            this.rbBookmark.Name = "rbBookmark";
            this.rbBookmark.Size = new System.Drawing.Size(86, 17);
            this.rbBookmark.TabIndex = 50;
            this.rbBookmark.TabStop = true;
            this.rbBookmark.Text = "by bookmark";
            this.rbBookmark.UseVisualStyleBackColor = true;
            // 
            // cbAsParagraph
            // 
            this.cbAsParagraph.AutoSize = true;
            this.cbAsParagraph.Location = new System.Drawing.Point(526, 147);
            this.cbAsParagraph.Name = "cbAsParagraph";
            this.cbAsParagraph.Size = new System.Drawing.Size(88, 17);
            this.cbAsParagraph.TabIndex = 49;
            this.cbAsParagraph.Text = "as paragraph";
            this.cbAsParagraph.UseVisualStyleBackColor = true;
            // 
            // btnInsertTextToBookmark
            // 
            this.btnInsertTextToBookmark.Enabled = false;
            this.btnInsertTextToBookmark.Location = new System.Drawing.Point(369, 144);
            this.btnInsertTextToBookmark.Name = "btnInsertTextToBookmark";
            this.btnInsertTextToBookmark.Size = new System.Drawing.Size(151, 23);
            this.btnInsertTextToBookmark.TabIndex = 48;
            this.btnInsertTextToBookmark.Text = "Insert Text";
            this.btnInsertTextToBookmark.UseVisualStyleBackColor = true;
            this.btnInsertTextToBookmark.Click += new System.EventHandler(this.btnInsertTextToBookmark_Click);
            // 
            // tbInsertText
            // 
            this.tbInsertText.Location = new System.Drawing.Point(160, 144);
            this.tbInsertText.Name = "tbInsertText";
            this.tbInsertText.Size = new System.Drawing.Size(203, 20);
            this.tbInsertText.TabIndex = 47;
            this.tbInsertText.Text = "!!!New Bookmark Text!!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Insert text:";
            // 
            // tbBookmarkName
            // 
            this.tbBookmarkName.Location = new System.Drawing.Point(15, 144);
            this.tbBookmarkName.Name = "tbBookmarkName";
            this.tbBookmarkName.Size = new System.Drawing.Size(139, 20);
            this.tbBookmarkName.TabIndex = 45;
            this.tbBookmarkName.Text = "testBookmark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Bookmark:";
            // 
            // cbReplaceAll
            // 
            this.cbReplaceAll.AutoSize = true;
            this.cbReplaceAll.Location = new System.Drawing.Point(526, 104);
            this.cbReplaceAll.Name = "cbReplaceAll";
            this.cbReplaceAll.Size = new System.Drawing.Size(36, 17);
            this.cbReplaceAll.TabIndex = 43;
            this.cbReplaceAll.Text = "all";
            this.cbReplaceAll.UseVisualStyleBackColor = true;
            // 
            // btnTextReplace
            // 
            this.btnTextReplace.Enabled = false;
            this.btnTextReplace.Location = new System.Drawing.Point(369, 101);
            this.btnTextReplace.Name = "btnTextReplace";
            this.btnTextReplace.Size = new System.Drawing.Size(151, 23);
            this.btnTextReplace.TabIndex = 42;
            this.btnTextReplace.Text = "Replace";
            this.btnTextReplace.UseVisualStyleBackColor = true;
            this.btnTextReplace.Click += new System.EventHandler(this.btnTextReplace_Click);
            // 
            // tbReplaceText
            // 
            this.tbReplaceText.Location = new System.Drawing.Point(160, 101);
            this.tbReplaceText.Name = "tbReplaceText";
            this.tbReplaceText.Size = new System.Drawing.Size(203, 20);
            this.tbReplaceText.TabIndex = 41;
            this.tbReplaceText.Text = "!!!New Text!!!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Replace to:";
            // 
            // tbTextToFind
            // 
            this.tbTextToFind.Location = new System.Drawing.Point(15, 101);
            this.tbTextToFind.Name = "tbTextToFind";
            this.tbTextToFind.Size = new System.Drawing.Size(139, 20);
            this.tbTextToFind.TabIndex = 39;
            this.tbTextToFind.Text = "@@testReplace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Text to find:";
            // 
            // btnOpenTemplateDoc
            // 
            this.btnOpenTemplateDoc.Location = new System.Drawing.Point(369, 52);
            this.btnOpenTemplateDoc.Name = "btnOpenTemplateDoc";
            this.btnOpenTemplateDoc.Size = new System.Drawing.Size(151, 23);
            this.btnOpenTemplateDoc.TabIndex = 37;
            this.btnOpenTemplateDoc.Text = "Open Template Document";
            this.btnOpenTemplateDoc.UseVisualStyleBackColor = true;
            this.btnOpenTemplateDoc.Click += new System.EventHandler(this.btnOpenTemplateDoc_Click);
            // 
            // btnOpenEmptyDoc
            // 
            this.btnOpenEmptyDoc.Location = new System.Drawing.Point(225, 52);
            this.btnOpenEmptyDoc.Name = "btnOpenEmptyDoc";
            this.btnOpenEmptyDoc.Size = new System.Drawing.Size(138, 23);
            this.btnOpenEmptyDoc.TabIndex = 36;
            this.btnOpenEmptyDoc.Text = "Open Empty Document";
            this.btnOpenEmptyDoc.UseVisualStyleBackColor = true;
            this.btnOpenEmptyDoc.Click += new System.EventHandler(this.btnOpenEmptyDoc_Click);
            // 
            // tbTemplateName
            // 
            this.tbTemplateName.Location = new System.Drawing.Point(12, 26);
            this.tbTemplateName.Name = "tbTemplateName";
            this.tbTemplateName.Size = new System.Drawing.Size(351, 20);
            this.tbTemplateName.TabIndex = 35;
            this.tbTemplateName.Text = "testWordTemplate.dot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Template file name:";
            // 
            // btnOpenTemplate
            // 
            this.btnOpenTemplate.Location = new System.Drawing.Point(369, 26);
            this.btnOpenTemplate.Name = "btnOpenTemplate";
            this.btnOpenTemplate.Size = new System.Drawing.Size(151, 23);
            this.btnOpenTemplate.TabIndex = 33;
            this.btnOpenTemplate.Text = "Open Template File";
            this.btnOpenTemplate.UseVisualStyleBackColor = true;
            this.btnOpenTemplate.Click += new System.EventHandler(this.btnOpenTemplate_Click);
            // 
            // ofdWordTemplate
            // 
            this.ofdWordTemplate.FileName = "testWordTemplate";
            this.ofdWordTemplate.InitialDirectory = "D:\\[02 SBMT]\\[СВПП]\\[Проекты]\\PZ2_20PO\\PZ_0913_Word\\bin\\Debug";
            // 
            // btnInsertImg
            // 
            this.btnInsertImg.Enabled = false;
            this.btnInsertImg.Location = new System.Drawing.Point(369, 202);
            this.btnInsertImg.Name = "btnInsertImg";
            this.btnInsertImg.Size = new System.Drawing.Size(151, 23);
            this.btnInsertImg.TabIndex = 65;
            this.btnInsertImg.Text = "Insert Image";
            this.btnInsertImg.UseVisualStyleBackColor = true;
            this.btnInsertImg.Click += new System.EventHandler(this.btnInsertImg_Click);
            // 
            // tbImagePath
            // 
            this.tbImagePath.Location = new System.Drawing.Point(160, 202);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.Size = new System.Drawing.Size(203, 20);
            this.tbImagePath.TabIndex = 64;
            this.tbImagePath.Text = "C:\\Users\\Krystsina\\source\\repos\\PZ2_21PO\\Pz0429_Library\\bin\\Debug\\2f.jpg";
            // 
            // WordExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 528);
            this.Controls.Add(this.btnInsertImg);
            this.Controls.Add(this.gbTableFunctions);
            this.Controls.Add(this.tbImagePath);
            this.Controls.Add(this.cbFindIn);
            this.Controls.Add(this.cbIsAtCenter);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbIsItalic);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.tbTextToChangeFormat);
            this.Controls.Add(this.tbContainerString);
            this.Controls.Add(this.cbIsBold);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rbBeforText);
            this.Controls.Add(this.rbBookmark);
            this.Controls.Add(this.cbAsParagraph);
            this.Controls.Add(this.btnInsertTextToBookmark);
            this.Controls.Add(this.tbInsertText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBookmarkName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbReplaceAll);
            this.Controls.Add(this.btnTextReplace);
            this.Controls.Add(this.tbReplaceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTextToFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenTemplateDoc);
            this.Controls.Add(this.btnOpenEmptyDoc);
            this.Controls.Add(this.tbTemplateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenTemplate);
            this.Name = "WordExample";
            this.Text = "WordExample";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordExample_FormClosed);
            this.gbTableFunctions.ResumeLayout(false);
            this.gbTableFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTableId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTableFunctions;
        private System.Windows.Forms.Button btnInsertTemplateTable;
        private System.Windows.Forms.Button btnInsertIntoTable;
        private System.Windows.Forms.NumericUpDown nudTableNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudRowNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudTableId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsertTable;
        private System.Windows.Forms.CheckBox cbNoBorders;
        private System.Windows.Forms.CheckBox cbFindIn;
        private System.Windows.Forms.CheckBox cbIsAtCenter;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbIsItalic;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TextBox tbTextToChangeFormat;
        private System.Windows.Forms.TextBox tbContainerString;
        private System.Windows.Forms.CheckBox cbIsBold;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RadioButton rbBeforText;
        private System.Windows.Forms.RadioButton rbBookmark;
        private System.Windows.Forms.CheckBox cbAsParagraph;
        private System.Windows.Forms.Button btnInsertTextToBookmark;
        private System.Windows.Forms.TextBox tbInsertText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBookmarkName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbReplaceAll;
        private System.Windows.Forms.Button btnTextReplace;
        private System.Windows.Forms.TextBox tbReplaceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTextToFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenTemplateDoc;
        private System.Windows.Forms.Button btnOpenEmptyDoc;
        private System.Windows.Forms.TextBox tbTemplateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenTemplate;
        private System.Windows.Forms.OpenFileDialog ofdWordTemplate;
        private System.Windows.Forms.Button btnInsertImg;
        private System.Windows.Forms.TextBox tbImagePath;
    }
}
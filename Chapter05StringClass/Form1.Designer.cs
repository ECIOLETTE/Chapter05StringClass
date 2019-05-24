namespace Chapter05StringClass
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLastIndexOf = new System.Windows.Forms.Label();
            this.lblIndexOf = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtToUpper = new System.Windows.Forms.TextBox();
            this.txtToLower = new System.Windows.Forms.TextBox();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.TxtSearchIndex = new System.Windows.Forms.TextBox();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.txtSubstringResult = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.txtReaplaceWith = new System.Windows.Forms.TextBox();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to test:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "String.Length:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(33, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "String.ToUpper( ):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(33, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "String.ToLower( ):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(33, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search for character:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(33, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search for last character:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(33, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Extract Substring from index:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(33, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "txtInput.Remove( ):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(33, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Find:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(33, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "txtInput.Replace( )=:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblLastIndexOf
            // 
            this.lblLastIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastIndexOf.Location = new System.Drawing.Point(219, 164);
            this.lblLastIndexOf.Name = "lblLastIndexOf";
            this.lblLastIndexOf.Size = new System.Drawing.Size(333, 20);
            this.lblLastIndexOf.TabIndex = 1;
            this.lblLastIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIndexOf
            // 
            this.lblIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndexOf.Location = new System.Drawing.Point(219, 139);
            this.lblIndexOf.Name = "lblIndexOf";
            this.lblIndexOf.Size = new System.Drawing.Size(333, 20);
            this.lblIndexOf.TabIndex = 2;
            this.lblIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(219, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "for this many characters:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubstring
            // 
            this.lblSubstring.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubstring.Location = new System.Drawing.Point(399, 189);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(153, 20);
            this.lblSubstring.TabIndex = 4;
            this.lblSubstring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(298, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Reaplace with:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(33, 311);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "&Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(548, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(189, 38);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(434, 20);
            this.txtInput.TabIndex = 8;
            this.txtInput.Text = "This is a test of various string METHODS, 1234567890 and z";
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(189, 65);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(434, 20);
            this.txtLength.TabIndex = 9;
            // 
            // txtToUpper
            // 
            this.txtToUpper.Location = new System.Drawing.Point(189, 91);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(434, 20);
            this.txtToUpper.TabIndex = 10;
            // 
            // txtToLower
            // 
            this.txtToLower.Location = new System.Drawing.Point(189, 114);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(434, 20);
            this.txtToLower.TabIndex = 11;
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(189, 139);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(24, 20);
            this.txtSearchChar.TabIndex = 12;
            this.txtSearchChar.Text = "v";
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(189, 166);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(24, 20);
            this.txtLastChar.TabIndex = 13;
            this.txtLastChar.Text = "s";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(189, 189);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(24, 20);
            this.txtStartIndex.TabIndex = 14;
            this.txtStartIndex.Text = "18";
            // 
            // TxtSearchIndex
            // 
            this.TxtSearchIndex.Location = new System.Drawing.Point(558, 140);
            this.TxtSearchIndex.Name = "TxtSearchIndex";
            this.TxtSearchIndex.Size = new System.Drawing.Size(65, 20);
            this.TxtSearchIndex.TabIndex = 15;
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(558, 166);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(65, 20);
            this.txtLastIndexOf.TabIndex = 16;
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(353, 190);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(40, 20);
            this.txtEndIndex.TabIndex = 17;
            this.txtEndIndex.Text = "7";
            // 
            // txtSubstringResult
            // 
            this.txtSubstringResult.Location = new System.Drawing.Point(558, 189);
            this.txtSubstringResult.Name = "txtSubstringResult";
            this.txtSubstringResult.Size = new System.Drawing.Size(65, 20);
            this.txtSubstringResult.TabIndex = 18;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(189, 216);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(82, 20);
            this.txtRemove.TabIndex = 19;
            this.txtRemove.Text = "string";
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(277, 216);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(346, 20);
            this.txtRemoveResult.TabIndex = 20;
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(189, 239);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(103, 20);
            this.txtReplaceChars.TabIndex = 21;
            this.txtReplaceChars.Text = "1234567890";
            // 
            // txtReaplaceWith
            // 
            this.txtReaplaceWith.Location = new System.Drawing.Point(432, 239);
            this.txtReaplaceWith.Name = "txtReaplaceWith";
            this.txtReaplaceWith.Size = new System.Drawing.Size(191, 20);
            this.txtReaplaceWith.TabIndex = 22;
            this.txtReaplaceWith.Text = "***";
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(189, 265);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(434, 20);
            this.txtReplaceResult.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(583, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Eder Ciolette";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 376);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.txtReaplaceWith);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtSubstringResult);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.TxtSearchIndex);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblLastIndexOf);
            this.Controls.Add(this.lblIndexOf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "String Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLastIndexOf;
        private System.Windows.Forms.Label lblIndexOf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtToUpper;
        private System.Windows.Forms.TextBox txtToLower;
        private System.Windows.Forms.TextBox txtSearchChar;
        private System.Windows.Forms.TextBox txtLastChar;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.TextBox TxtSearchIndex;
        private System.Windows.Forms.TextBox txtLastIndexOf;
        private System.Windows.Forms.TextBox txtEndIndex;
        private System.Windows.Forms.TextBox txtSubstringResult;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.TextBox txtRemoveResult;
        private System.Windows.Forms.TextBox txtReplaceChars;
        private System.Windows.Forms.TextBox txtReaplaceWith;
        private System.Windows.Forms.TextBox txtReplaceResult;
        private System.Windows.Forms.Label label11;
    }
}


namespace gxv3240_mpk
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTest3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnTest4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnTest5 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnDoLogin = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.tbBrowserSorce = new System.Windows.Forms.TextBox();
            this.btnTestBrowser = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.trackTimerDelay = new System.Windows.Forms.TrackBar();
            this.lTimerDelay = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.cbUrl = new System.Windows.Forms.ComboBox();
            this.btnUrlClear = new System.Windows.Forms.Button();
            this.gbTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTimerDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(255, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(758, 459);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // btnTest1
            // 
            this.btnTest1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTest1.Location = new System.Drawing.Point(16, -27);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 23);
            this.btnTest1.TabIndex = 1;
            this.btnTest1.Text = "test1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "phone1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "1";
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(97, 19);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 23);
            this.btnTest2.TabIndex = 4;
            this.btnTest2.Text = "test2[clear]";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnTest3
            // 
            this.btnTest3.Location = new System.Drawing.Point(178, 19);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(75, 23);
            this.btnTest3.TabIndex = 5;
            this.btnTest3.Text = "test3[vis]";
            this.btnTest3.UseVisualStyleBackColor = true;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "10";
            // 
            // btnTest4
            // 
            this.btnTest4.Location = new System.Drawing.Point(259, 19);
            this.btnTest4.Name = "btnTest4";
            this.btnTest4.Size = new System.Drawing.Size(75, 23);
            this.btnTest4.TabIndex = 7;
            this.btnTest4.Text = "test4[login]";
            this.btnTest4.UseVisualStyleBackColor = true;
            this.btnTest4.Click += new System.EventHandler(this.btnTest4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(334, 48);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "40";
            // 
            // tbMain
            // 
            this.tbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMain.Location = new System.Drawing.Point(12, 70);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMain.Size = new System.Drawing.Size(237, 321);
            this.tbMain.TabIndex = 9;
            this.tbMain.Text = resources.GetString("tbMain.Text");
            this.tbMain.WordWrap = false;
            this.tbMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMain_KeyDown);
            // 
            // btnTest5
            // 
            this.btnTest5.Location = new System.Drawing.Point(340, 19);
            this.btnTest5.Name = "btnTest5";
            this.btnTest5.Size = new System.Drawing.Size(75, 23);
            this.btnTest5.TabIndex = 10;
            this.btnTest5.Text = "test5[add]";
            this.btnTest5.UseVisualStyleBackColor = true;
            this.btnTest5.Click += new System.EventHandler(this.btnTest5_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnDoLogin
            // 
            this.btnDoLogin.Location = new System.Drawing.Point(174, 12);
            this.btnDoLogin.Name = "btnDoLogin";
            this.btnDoLogin.Size = new System.Drawing.Size(75, 23);
            this.btnDoLogin.TabIndex = 12;
            this.btnDoLogin.Text = "Login";
            this.btnDoLogin.UseVisualStyleBackColor = true;
            this.btnDoLogin.Click += new System.EventHandler(this.btnDoLogin_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(12, 12);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(75, 20);
            this.tbLogin.TabIndex = 13;
            this.tbLogin.Text = "admin";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(93, 12);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '1';
            this.tbPass.Size = new System.Drawing.Size(75, 20);
            this.tbPass.TabIndex = 14;
            this.tbPass.Text = "admin";
            // 
            // btnNavigate
            // 
            this.btnNavigate.Location = new System.Drawing.Point(174, 41);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(75, 21);
            this.btnNavigate.TabIndex = 15;
            this.btnNavigate.Text = "Go";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(93, 448);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear MPK";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbTest
            // 
            this.gbTest.Controls.Add(this.tbBrowserSorce);
            this.gbTest.Controls.Add(this.btnTestBrowser);
            this.gbTest.Controls.Add(this.btnTest1);
            this.gbTest.Controls.Add(this.btnTest2);
            this.gbTest.Controls.Add(this.btnTest3);
            this.gbTest.Controls.Add(this.btnTest4);
            this.gbTest.Controls.Add(this.btnTest5);
            this.gbTest.Controls.Add(this.textBox1);
            this.gbTest.Controls.Add(this.textBox2);
            this.gbTest.Controls.Add(this.textBox3);
            this.gbTest.Controls.Add(this.textBox4);
            this.gbTest.Location = new System.Drawing.Point(278, 70);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(442, 245);
            this.gbTest.TabIndex = 17;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "gbTest";
            this.gbTest.Visible = false;
            // 
            // tbBrowserSorce
            // 
            this.tbBrowserSorce.Location = new System.Drawing.Point(16, 74);
            this.tbBrowserSorce.Multiline = true;
            this.tbBrowserSorce.Name = "tbBrowserSorce";
            this.tbBrowserSorce.Size = new System.Drawing.Size(146, 128);
            this.tbBrowserSorce.TabIndex = 12;
            this.tbBrowserSorce.Text = resources.GetString("tbBrowserSorce.Text");
            // 
            // btnTestBrowser
            // 
            this.btnTestBrowser.Location = new System.Drawing.Point(16, 208);
            this.btnTestBrowser.Name = "btnTestBrowser";
            this.btnTestBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnTestBrowser.TabIndex = 11;
            this.btnTestBrowser.Text = "browser";
            this.btnTestBrowser.UseVisualStyleBackColor = true;
            this.btnTestBrowser.Click += new System.EventHandler(this.btnTestBrowser_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWrite.Location = new System.Drawing.Point(174, 448);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 18;
            this.btnWrite.Text = "Write MPK";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnGet
            // 
            this.btnGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGet.Location = new System.Drawing.Point(12, 448);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 19;
            this.btnGet.Text = "Get MPK";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // trackTimerDelay
            // 
            this.trackTimerDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackTimerDelay.Location = new System.Drawing.Point(12, 397);
            this.trackTimerDelay.Maximum = 20;
            this.trackTimerDelay.Minimum = 3;
            this.trackTimerDelay.Name = "trackTimerDelay";
            this.trackTimerDelay.Size = new System.Drawing.Size(237, 45);
            this.trackTimerDelay.TabIndex = 20;
            this.trackTimerDelay.Value = 3;
            this.trackTimerDelay.Scroll += new System.EventHandler(this.trackTimerDelay_Scroll);
            // 
            // lTimerDelay
            // 
            this.lTimerDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTimerDelay.AutoSize = true;
            this.lTimerDelay.Location = new System.Drawing.Point(12, 429);
            this.lTimerDelay.Name = "lTimerDelay";
            this.lTimerDelay.Size = new System.Drawing.Size(109, 13);
            this.lTimerDelay.TabIndex = 21;
            this.lTimerDelay.Text = "WriteMPK delay: 1.5s";
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // cbUrl
            // 
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Location = new System.Drawing.Point(12, 41);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(137, 21);
            this.cbUrl.TabIndex = 22;
            this.cbUrl.Text = "http://";
            this.cbUrl.SelectedIndexChanged += new System.EventHandler(this.cbUrl_SelectedIndexChanged);
            this.cbUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUrl_KeyPress);
            // 
            // btnUrlClear
            // 
            this.btnUrlClear.Location = new System.Drawing.Point(145, 41);
            this.btnUrlClear.Name = "btnUrlClear";
            this.btnUrlClear.Size = new System.Drawing.Size(23, 22);
            this.btnUrlClear.TabIndex = 23;
            this.btnUrlClear.Text = "x";
            this.btnUrlClear.UseVisualStyleBackColor = true;
            this.btnUrlClear.Click += new System.EventHandler(this.btnUrlClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 483);
            this.Controls.Add(this.btnUrlClear);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.lTimerDelay);
            this.Controls.Add(this.trackTimerDelay);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.gbTest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnDoLogin);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.webBrowser);
            this.Name = "Form1";
            this.Text = "gxv3240_mpk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbTest.ResumeLayout(false);
            this.gbTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTimerDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTest3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnTest4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button btnTest5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnDoLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnTestBrowser;
        private System.Windows.Forms.TextBox tbBrowserSorce;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TrackBar trackTimerDelay;
        private System.Windows.Forms.Label lTimerDelay;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ComboBox cbUrl;
        private System.Windows.Forms.Button btnUrlClear;
    }
}


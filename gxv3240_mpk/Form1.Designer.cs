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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbMain = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnDoLogin = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.trackTimerDelay = new System.Windows.Forms.TrackBar();
            this.lTimerDelay = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.cbUrl = new System.Windows.Forms.ComboBox();
            this.btnUrlClear = new System.Windows.Forms.Button();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnTestBrowser = new System.Windows.Forms.Button();
            this.tbBrowserSorce = new System.Windows.Forms.TextBox();
            this.gbTest = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGbTestHide = new System.Windows.Forms.Button();
            this.btnUrlAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackTimerDelay)).BeginInit();
            this.gbTest.SuspendLayout();
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
            this.webBrowser.Size = new System.Drawing.Size(711, 459);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnNavigate.Location = new System.Drawing.Point(204, 41);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(45, 21);
            this.btnNavigate.TabIndex = 15;
            this.btnNavigate.Text = "➜";
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
            this.cbUrl.DropDownWidth = 236;
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Location = new System.Drawing.Point(12, 41);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(139, 21);
            this.cbUrl.TabIndex = 22;
            this.cbUrl.Text = "http://";
            this.cbUrl.SelectedIndexChanged += new System.EventHandler(this.cbUrl_SelectedIndexChanged);
            this.cbUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUrl_KeyPress);
            // 
            // btnUrlClear
            // 
            this.btnUrlClear.Location = new System.Drawing.Point(179, 41);
            this.btnUrlClear.Name = "btnUrlClear";
            this.btnUrlClear.Size = new System.Drawing.Size(23, 21);
            this.btnUrlClear.TabIndex = 23;
            this.btnUrlClear.Text = "❌";
            this.btnUrlClear.UseVisualStyleBackColor = true;
            this.btnUrlClear.Click += new System.EventHandler(this.btnUrlClear_Click);
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(6, 65);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 23);
            this.btnTest1.TabIndex = 1;
            this.btnTest1.Text = "test1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // btnTestBrowser
            // 
            this.btnTestBrowser.Location = new System.Drawing.Point(6, 19);
            this.btnTestBrowser.Name = "btnTestBrowser";
            this.btnTestBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnTestBrowser.TabIndex = 11;
            this.btnTestBrowser.Text = "browser";
            this.btnTestBrowser.UseVisualStyleBackColor = true;
            this.btnTestBrowser.Click += new System.EventHandler(this.btnTestBrowser_Click);
            // 
            // tbBrowserSorce
            // 
            this.tbBrowserSorce.Location = new System.Drawing.Point(583, 24);
            this.tbBrowserSorce.Multiline = true;
            this.tbBrowserSorce.Name = "tbBrowserSorce";
            this.tbBrowserSorce.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbBrowserSorce.Size = new System.Drawing.Size(355, 168);
            this.tbBrowserSorce.TabIndex = 12;
            this.tbBrowserSorce.Text = resources.GetString("tbBrowserSorce.Text");
            this.tbBrowserSorce.Visible = false;
            this.tbBrowserSorce.WordWrap = false;
            // 
            // gbTest
            // 
            this.gbTest.Controls.Add(this.button2);
            this.gbTest.Controls.Add(this.button1);
            this.gbTest.Controls.Add(this.btnGbTestHide);
            this.gbTest.Controls.Add(this.btnTestBrowser);
            this.gbTest.Controls.Add(this.btnTest1);
            this.gbTest.Location = new System.Drawing.Point(255, 3);
            this.gbTest.Name = "gbTest";
            this.gbTest.Size = new System.Drawing.Size(292, 109);
            this.gbTest.TabIndex = 17;
            this.gbTest.TabStop = false;
            this.gbTest.Text = "gbTest";
            this.gbTest.Visible = false;
            this.gbTest.MouseHover += new System.EventHandler(this.gbTest_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGbTestHide
            // 
            this.btnGbTestHide.Location = new System.Drawing.Point(242, 19);
            this.btnGbTestHide.Name = "btnGbTestHide";
            this.btnGbTestHide.Size = new System.Drawing.Size(44, 23);
            this.btnGbTestHide.TabIndex = 12;
            this.btnGbTestHide.Text = "^";
            this.btnGbTestHide.UseVisualStyleBackColor = true;
            this.btnGbTestHide.Click += new System.EventHandler(this.btnGbTestHide_Click);
            // 
            // btnUrlAdd
            // 
            this.btnUrlAdd.Location = new System.Drawing.Point(154, 41);
            this.btnUrlAdd.Name = "btnUrlAdd";
            this.btnUrlAdd.Size = new System.Drawing.Size(23, 21);
            this.btnUrlAdd.TabIndex = 24;
            this.btnUrlAdd.Text = "➕";
            this.btnUrlAdd.UseVisualStyleBackColor = true;
            this.btnUrlAdd.Click += new System.EventHandler(this.btnUrlAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 483);
            this.Controls.Add(this.btnUrlAdd);
            this.Controls.Add(this.tbBrowserSorce);
            this.Controls.Add(this.btnUrlClear);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.lTimerDelay);
            this.Controls.Add(this.trackTimerDelay);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.gbTest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btnDoLogin);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "gxv3240_mpk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.trackTimerDelay)).EndInit();
            this.gbTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnDoLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TrackBar trackTimerDelay;
        private System.Windows.Forms.Label lTimerDelay;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ComboBox cbUrl;
        private System.Windows.Forms.Button btnUrlClear;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnTestBrowser;
        private System.Windows.Forms.TextBox tbBrowserSorce;
        private System.Windows.Forms.GroupBox gbTest;
        private System.Windows.Forms.Button btnGbTestHide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUrlAdd;
    }
}


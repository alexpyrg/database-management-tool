namespace dbVisualapp
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusstaticLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.usernameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.databaseLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.transactionCB = new System.Windows.Forms.CheckBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.othcomms = new System.Windows.Forms.GroupBox();
            this.groupbyStat = new System.Windows.Forms.Button();
            this.orderbyStat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dropTable = new System.Windows.Forms.Button();
            this.alterTableButton = new System.Windows.Forms.Button();
            this.createtableButton = new System.Windows.Forms.Button();
            this.selectPreset = new System.Windows.Forms.Button();
            this.updatePreset = new System.Windows.Forms.Button();
            this.insertPreset = new System.Windows.Forms.Button();
            this.deletePreset = new System.Windows.Forms.Button();
            this.queryLabel = new System.Windows.Forms.Label();
            this.execQuery = new System.Windows.Forms.Button();
            this.queryBox = new System.Windows.Forms.RichTextBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clearQueryButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.clearConsoleButton = new System.Windows.Forms.Button();
            this.clearResButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.uidBox = new System.Windows.Forms.TextBox();
            this.databaseBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sqlServer = new System.Windows.Forms.RadioButton();
            this.mysqlServer = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.conButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.visualPage = new System.Windows.Forms.TabPage();
            this.dataVisual = new System.Windows.Forms.DataGridView();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.othcomms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.visualPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusstaticLabel,
            this.statusLabel,
            this.usernameLabel,
            this.databaseLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 873);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(926, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusstaticLabel
            // 
            this.statusstaticLabel.Name = "statusstaticLabel";
            this.statusstaticLabel.Size = new System.Drawing.Size(42, 17);
            this.statusstaticLabel.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(24, 17);
            this.statusLabel.Text = "NA";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 17);
            this.usernameLabel.Text = "Connected as: NA";
            // 
            // databaseLabel
            // 
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(61, 17);
            this.databaseLabel.Text = "Database: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Controls.Add(this.visualPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 651);
            this.tabControl1.TabIndex = 20;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.transactionCB);
            this.mainTab.Controls.Add(this.resultLabel);
            this.mainTab.Controls.Add(this.resultBox);
            this.mainTab.Controls.Add(this.othcomms);
            this.mainTab.Controls.Add(this.groupBox1);
            this.mainTab.Controls.Add(this.queryLabel);
            this.mainTab.Controls.Add(this.execQuery);
            this.mainTab.Controls.Add(this.queryBox);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(918, 625);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Database Controls";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // transactionCB
            // 
            this.transactionCB.Appearance = System.Windows.Forms.Appearance.Button;
            this.transactionCB.AutoSize = true;
            this.transactionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.transactionCB.Location = new System.Drawing.Point(741, 458);
            this.transactionCB.Name = "transactionCB";
            this.transactionCB.Size = new System.Drawing.Size(113, 30);
            this.transactionCB.TabIndex = 30;
            this.transactionCB.Text = "Transaction";
            this.transactionCB.UseVisualStyleBackColor = true;
            this.transactionCB.CheckedChanged += new System.EventHandler(this.transactionCB_CheckedChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resultLabel.Location = new System.Drawing.Point(8, -4);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(60, 21);
            this.resultLabel.TabIndex = 29;
            this.resultLabel.Text = "Result:";
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resultBox.ForeColor = System.Drawing.Color.MediumOrchid;
            this.resultBox.Location = new System.Drawing.Point(8, 18);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(487, 601);
            this.resultBox.TabIndex = 28;
            this.resultBox.Text = "";
            // 
            // othcomms
            // 
            this.othcomms.Controls.Add(this.groupbyStat);
            this.othcomms.Controls.Add(this.orderbyStat);
            this.othcomms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.othcomms.Location = new System.Drawing.Point(695, 396);
            this.othcomms.Name = "othcomms";
            this.othcomms.Size = new System.Drawing.Size(216, 56);
            this.othcomms.TabIndex = 26;
            this.othcomms.TabStop = false;
            this.othcomms.Text = "Other Commands";
            // 
            // groupbyStat
            // 
            this.groupbyStat.BackColor = System.Drawing.Color.Snow;
            this.groupbyStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupbyStat.Location = new System.Drawing.Point(6, 23);
            this.groupbyStat.Name = "groupbyStat";
            this.groupbyStat.Size = new System.Drawing.Size(96, 27);
            this.groupbyStat.TabIndex = 13;
            this.groupbyStat.Text = "GROUP BY";
            this.groupbyStat.UseVisualStyleBackColor = false;
            this.groupbyStat.Click += new System.EventHandler(this.groupbyStat_Click_1);
            // 
            // orderbyStat
            // 
            this.orderbyStat.BackColor = System.Drawing.Color.Snow;
            this.orderbyStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.orderbyStat.Location = new System.Drawing.Point(108, 23);
            this.orderbyStat.Name = "orderbyStat";
            this.orderbyStat.Size = new System.Drawing.Size(96, 27);
            this.orderbyStat.TabIndex = 12;
            this.orderbyStat.Text = "ORDER BY";
            this.orderbyStat.UseVisualStyleBackColor = false;
            this.orderbyStat.Click += new System.EventHandler(this.orderbyStat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dropTable);
            this.groupBox1.Controls.Add(this.alterTableButton);
            this.groupBox1.Controls.Add(this.createtableButton);
            this.groupBox1.Controls.Add(this.selectPreset);
            this.groupBox1.Controls.Add(this.updatePreset);
            this.groupBox1.Controls.Add(this.insertPreset);
            this.groupBox1.Controls.Add(this.deletePreset);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(510, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 220);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Presets";
            // 
            // dropTable
            // 
            this.dropTable.BackColor = System.Drawing.Color.Snow;
            this.dropTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dropTable.ForeColor = System.Drawing.Color.Red;
            this.dropTable.Location = new System.Drawing.Point(6, 186);
            this.dropTable.Name = "dropTable";
            this.dropTable.Size = new System.Drawing.Size(166, 27);
            this.dropTable.TabIndex = 11;
            this.dropTable.Text = "DROP TABLE";
            this.dropTable.UseVisualStyleBackColor = false;
            this.dropTable.Click += new System.EventHandler(this.dropTable_Click_1);
            // 
            // alterTableButton
            // 
            this.alterTableButton.BackColor = System.Drawing.Color.Snow;
            this.alterTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.alterTableButton.Location = new System.Drawing.Point(6, 124);
            this.alterTableButton.Name = "alterTableButton";
            this.alterTableButton.Size = new System.Drawing.Size(166, 27);
            this.alterTableButton.TabIndex = 10;
            this.alterTableButton.Text = "ALTER TABLE";
            this.alterTableButton.UseVisualStyleBackColor = false;
            this.alterTableButton.Click += new System.EventHandler(this.alterTableButton_Click_1);
            // 
            // createtableButton
            // 
            this.createtableButton.BackColor = System.Drawing.Color.Snow;
            this.createtableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.createtableButton.Location = new System.Drawing.Point(6, 91);
            this.createtableButton.Name = "createtableButton";
            this.createtableButton.Size = new System.Drawing.Size(166, 27);
            this.createtableButton.TabIndex = 9;
            this.createtableButton.Text = "CREATE TABLE";
            this.createtableButton.UseVisualStyleBackColor = false;
            this.createtableButton.Click += new System.EventHandler(this.createtableButton_Click_1);
            // 
            // selectPreset
            // 
            this.selectPreset.BackColor = System.Drawing.Color.Snow;
            this.selectPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.selectPreset.Location = new System.Drawing.Point(6, 24);
            this.selectPreset.Name = "selectPreset";
            this.selectPreset.Size = new System.Drawing.Size(75, 27);
            this.selectPreset.TabIndex = 5;
            this.selectPreset.Text = "SELECT";
            this.selectPreset.UseVisualStyleBackColor = false;
            this.selectPreset.Click += new System.EventHandler(this.selectPreset_Click_1);
            // 
            // updatePreset
            // 
            this.updatePreset.BackColor = System.Drawing.Color.Snow;
            this.updatePreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.updatePreset.Location = new System.Drawing.Point(97, 24);
            this.updatePreset.Name = "updatePreset";
            this.updatePreset.Size = new System.Drawing.Size(75, 27);
            this.updatePreset.TabIndex = 6;
            this.updatePreset.Text = "UPDATE";
            this.updatePreset.UseVisualStyleBackColor = false;
            this.updatePreset.Click += new System.EventHandler(this.updatePreset_Click_1);
            // 
            // insertPreset
            // 
            this.insertPreset.BackColor = System.Drawing.Color.Snow;
            this.insertPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.insertPreset.Location = new System.Drawing.Point(6, 57);
            this.insertPreset.Name = "insertPreset";
            this.insertPreset.Size = new System.Drawing.Size(75, 27);
            this.insertPreset.TabIndex = 8;
            this.insertPreset.Text = "INSERT";
            this.insertPreset.UseVisualStyleBackColor = false;
            this.insertPreset.Click += new System.EventHandler(this.insertPreset_Click_1);
            // 
            // deletePreset
            // 
            this.deletePreset.BackColor = System.Drawing.Color.Snow;
            this.deletePreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deletePreset.Location = new System.Drawing.Point(97, 57);
            this.deletePreset.Name = "deletePreset";
            this.deletePreset.Size = new System.Drawing.Size(75, 27);
            this.deletePreset.TabIndex = 7;
            this.deletePreset.Text = "DELETE";
            this.deletePreset.UseVisualStyleBackColor = false;
            this.deletePreset.Click += new System.EventHandler(this.deletePreset_Click);
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.queryLabel.Location = new System.Drawing.Point(512, -4);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(61, 21);
            this.queryLabel.TabIndex = 24;
            this.queryLabel.Text = "Query:";
            // 
            // execQuery
            // 
            this.execQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.execQuery.Location = new System.Drawing.Point(695, 494);
            this.execQuery.Name = "execQuery";
            this.execQuery.Size = new System.Drawing.Size(216, 39);
            this.execQuery.TabIndex = 21;
            this.execQuery.Text = "Execute Query";
            this.execQuery.UseVisualStyleBackColor = true;
            this.execQuery.Click += new System.EventHandler(this.execQuery_Click_1);
            // 
            // queryBox
            // 
            this.queryBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.queryBox.ForeColor = System.Drawing.Color.MediumOrchid;
            this.queryBox.Location = new System.Drawing.Point(510, 20);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(401, 370);
            this.queryBox.TabIndex = 20;
            this.queryBox.Text = "SELECT * FROM `table`";
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.SystemColors.Control;
            this.settingsTab.Controls.Add(this.resetButton);
            this.settingsTab.Controls.Add(this.groupBox4);
            this.settingsTab.Controls.Add(this.groupBox3);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(918, 625);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Settings";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resetButton.Location = new System.Drawing.Point(26, 262);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(216, 39);
            this.resetButton.TabIndex = 33;
            this.resetButton.Text = "Reset Exec Button";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clearQueryButton);
            this.groupBox4.Controls.Add(this.clearAllButton);
            this.groupBox4.Controls.Add(this.clearConsoleButton);
            this.groupBox4.Controls.Add(this.clearResButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox4.Location = new System.Drawing.Point(20, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 226);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clear Options";
            // 
            // clearQueryButton
            // 
            this.clearQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearQueryButton.Location = new System.Drawing.Point(6, 38);
            this.clearQueryButton.Name = "clearQueryButton";
            this.clearQueryButton.Size = new System.Drawing.Size(216, 39);
            this.clearQueryButton.TabIndex = 28;
            this.clearQueryButton.Text = "Clear Query";
            this.clearQueryButton.UseVisualStyleBackColor = true;
            this.clearQueryButton.Click += new System.EventHandler(this.clearQueryButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearAllButton.Location = new System.Drawing.Point(6, 175);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(216, 39);
            this.clearAllButton.TabIndex = 31;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // clearConsoleButton
            // 
            this.clearConsoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearConsoleButton.Location = new System.Drawing.Point(6, 83);
            this.clearConsoleButton.Name = "clearConsoleButton";
            this.clearConsoleButton.Size = new System.Drawing.Size(216, 39);
            this.clearConsoleButton.TabIndex = 29;
            this.clearConsoleButton.Text = "Clear Console";
            this.clearConsoleButton.UseVisualStyleBackColor = true;
            this.clearConsoleButton.Click += new System.EventHandler(this.clearConsoleButton_Click);
            // 
            // clearResButton
            // 
            this.clearResButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearResButton.Location = new System.Drawing.Point(6, 130);
            this.clearResButton.Name = "clearResButton";
            this.clearResButton.Size = new System.Drawing.Size(216, 39);
            this.clearResButton.TabIndex = 30;
            this.clearResButton.Text = "Clear Results";
            this.clearResButton.UseVisualStyleBackColor = true;
            this.clearResButton.Click += new System.EventHandler(this.clearResButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.passwordBox);
            this.groupBox3.Controls.Add(this.ipBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.portBox);
            this.groupBox3.Controls.Add(this.uidBox);
            this.groupBox3.Controls.Add(this.databaseBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.conButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox3.Location = new System.Drawing.Point(497, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 391);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login Credentials";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "IP Address:";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordBox.Location = new System.Drawing.Point(166, 168);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(232, 29);
            this.passwordBox.TabIndex = 18;
            // 
            // ipBox
            // 
            this.ipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ipBox.Location = new System.Drawing.Point(166, 28);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(232, 29);
            this.ipBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(63, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Password:";
            // 
            // portBox
            // 
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.portBox.Location = new System.Drawing.Point(166, 63);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(232, 29);
            this.portBox.TabIndex = 15;
            this.portBox.Text = "3306";
            // 
            // uidBox
            // 
            this.uidBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.uidBox.Location = new System.Drawing.Point(166, 133);
            this.uidBox.Name = "uidBox";
            this.uidBox.Size = new System.Drawing.Size(232, 29);
            this.uidBox.TabIndex = 17;
            // 
            // databaseBox
            // 
            this.databaseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.databaseBox.Location = new System.Drawing.Point(166, 98);
            this.databaseBox.Name = "databaseBox";
            this.databaseBox.Size = new System.Drawing.Size(232, 29);
            this.databaseBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(23, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Username/UID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sqlServer);
            this.groupBox2.Controls.Add(this.mysqlServer);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox2.Location = new System.Drawing.Point(15, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Type";
            // 
            // sqlServer
            // 
            this.sqlServer.AutoSize = true;
            this.sqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sqlServer.Location = new System.Drawing.Point(15, 30);
            this.sqlServer.Name = "sqlServer";
            this.sqlServer.Size = new System.Drawing.Size(135, 28);
            this.sqlServer.TabIndex = 19;
            this.sqlServer.TabStop = true;
            this.sqlServer.Text = "SQL Server";
            this.sqlServer.UseVisualStyleBackColor = true;
            // 
            // mysqlServer
            // 
            this.mysqlServer.AutoSize = true;
            this.mysqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mysqlServer.Location = new System.Drawing.Point(15, 64);
            this.mysqlServer.Name = "mysqlServer";
            this.mysqlServer.Size = new System.Drawing.Size(95, 28);
            this.mysqlServer.TabIndex = 20;
            this.mysqlServer.TabStop = true;
            this.mysqlServer.Text = "MySQL";
            this.mysqlServer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Database Name:";
            // 
            // conButton
            // 
            this.conButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conButton.BackColor = System.Drawing.Color.Peru;
            this.conButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.conButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.conButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.conButton.Location = new System.Drawing.Point(15, 337);
            this.conButton.Name = "conButton";
            this.conButton.Size = new System.Drawing.Size(372, 45);
            this.conButton.TabIndex = 21;
            this.conButton.Text = "Connect";
            this.conButton.UseVisualStyleBackColor = false;
            this.conButton.Click += new System.EventHandler(this.conButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(112, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Port:";
            // 
            // visualPage
            // 
            this.visualPage.Controls.Add(this.dataVisual);
            this.visualPage.Location = new System.Drawing.Point(4, 22);
            this.visualPage.Name = "visualPage";
            this.visualPage.Padding = new System.Windows.Forms.Padding(3);
            this.visualPage.Size = new System.Drawing.Size(918, 625);
            this.visualPage.TabIndex = 2;
            this.visualPage.Text = "DB Visual";
            this.visualPage.UseVisualStyleBackColor = true;
            // 
            // dataVisual
            // 
            this.dataVisual.AllowUserToAddRows = false;
            this.dataVisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVisual.Location = new System.Drawing.Point(9, 7);
            this.dataVisual.Name = "dataVisual";
            this.dataVisual.ReadOnly = true;
            this.dataVisual.Size = new System.Drawing.Size(901, 612);
            this.dataVisual.TabIndex = 0;
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.consoleBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.consoleBox.ForeColor = System.Drawing.Color.LightGray;
            this.consoleBox.Location = new System.Drawing.Point(4, 654);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(918, 216);
            this.consoleBox.TabIndex = 23;
            this.consoleBox.Text = "Console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(926, 895);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Database Connector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.othcomms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.visualPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusstaticLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel usernameLabel;
        private System.Windows.Forms.ToolStripStatusLabel databaseLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.CheckBox transactionCB;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.GroupBox othcomms;
        private System.Windows.Forms.Button groupbyStat;
        private System.Windows.Forms.Button orderbyStat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dropTable;
        private System.Windows.Forms.Button alterTableButton;
        private System.Windows.Forms.Button createtableButton;
        private System.Windows.Forms.Button selectPreset;
        private System.Windows.Forms.Button updatePreset;
        private System.Windows.Forms.Button insertPreset;
        private System.Windows.Forms.Button deletePreset;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Button execQuery;
        private System.Windows.Forms.RichTextBox queryBox;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox uidBox;
        private System.Windows.Forms.TextBox databaseBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sqlServer;
        private System.Windows.Forms.RadioButton mysqlServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button conButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button clearQueryButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button clearConsoleButton;
        private System.Windows.Forms.Button clearResButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TabPage visualPage;
        private System.Windows.Forms.DataGridView dataVisual;
    }
}


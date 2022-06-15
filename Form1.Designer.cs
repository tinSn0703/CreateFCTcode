
namespace CreateFCTcode
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.openInputFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.プロパティEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
			this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.InputPath = new System.Windows.Forms.TextBox();
			this.ActionButton = new System.Windows.Forms.Button();
			this.InputFileOpenButton = new System.Windows.Forms.Button();
			this.OutputPath = new System.Windows.Forms.TextBox();
			this.OutputFileOpenButton = new System.Windows.Forms.Button();
			this.openOutputFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.OutputPathLabel = new System.Windows.Forms.Label();
			this.InputPathLabel = new System.Windows.Forms.Label();
			this.InputConfigText = new System.Windows.Forms.Label();
			this.OutputConfigText = new System.Windows.Forms.Label();
			this.RsCommandLabel = new System.Windows.Forms.Label();
			this.RsCommandNameText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.RamCommandNameText = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.MaxWriteBlockText = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.MaxWriteSizeText = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.MinWriteSizeText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.MaxWriteAddrText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.MinWriteAddrText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.CommentText = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openInputFileDialog
			// 
			this.openInputFileDialog.FileName = "openInputFileDialog";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.編集EToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(564, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.プロパティEToolStripMenuItem,
            this.toolStripTextBox1});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
			this.toolStripMenuItem1.Text = "ファイル(F)";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem2.Text = "新規作成(N)";
			this.toolStripMenuItem2.Visible = false;
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem3.Text = "開く(O)";
			this.toolStripMenuItem3.Visible = false;
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(145, 22);
			this.toolStripMenuItem4.Text = "上書き保存(S)";
			this.toolStripMenuItem4.Visible = false;
			// 
			// プロパティEToolStripMenuItem
			// 
			this.プロパティEToolStripMenuItem.Name = "プロパティEToolStripMenuItem";
			this.プロパティEToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.プロパティEToolStripMenuItem.Text = "プロパティ(E)";
			this.プロパティEToolStripMenuItem.Click += new System.EventHandler(this.property_ToolStripMenuItem_Click);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(145, 22);
			this.toolStripTextBox1.Text = "終了(X)";
			// 
			// 編集EToolStripMenuItem
			// 
			this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
			this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.編集EToolStripMenuItem.Text = "編集(E)";
			this.編集EToolStripMenuItem.Visible = false;
			// 
			// 表示VToolStripMenuItem
			// 
			this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
			this.表示VToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.表示VToolStripMenuItem.Text = "表示(V)";
			// 
			// ヘルプHToolStripMenuItem
			// 
			this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
			this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.ヘルプHToolStripMenuItem.Text = "ヘルプ(H)";
			// 
			// InputPath
			// 
			this.InputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InputPath.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.InputPath.Location = new System.Drawing.Point(25, 33);
			this.InputPath.Name = "InputPath";
			this.InputPath.Size = new System.Drawing.Size(369, 19);
			this.InputPath.TabIndex = 1;
			// 
			// ActionButton
			// 
			this.ActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ActionButton.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ActionButton.Location = new System.Drawing.Point(424, 321);
			this.ActionButton.Name = "ActionButton";
			this.ActionButton.Size = new System.Drawing.Size(95, 29);
			this.ActionButton.TabIndex = 3;
			this.ActionButton.Text = "実行";
			this.ActionButton.UseVisualStyleBackColor = true;
			this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
			// 
			// InputFileOpenButton
			// 
			this.InputFileOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.InputFileOpenButton.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.InputFileOpenButton.Location = new System.Drawing.Point(424, 33);
			this.InputFileOpenButton.Name = "InputFileOpenButton";
			this.InputFileOpenButton.Size = new System.Drawing.Size(95, 29);
			this.InputFileOpenButton.TabIndex = 0;
			this.InputFileOpenButton.Text = "開く";
			this.InputFileOpenButton.UseVisualStyleBackColor = true;
			this.InputFileOpenButton.Click += new System.EventHandler(this.InputFileOpenButton_Click);
			// 
			// OutputPath
			// 
			this.OutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputPath.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.OutputPath.Location = new System.Drawing.Point(25, 104);
			this.OutputPath.Name = "OutputPath";
			this.OutputPath.Size = new System.Drawing.Size(369, 19);
			this.OutputPath.TabIndex = 7;
			// 
			// OutputFileOpenButton
			// 
			this.OutputFileOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputFileOpenButton.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.OutputFileOpenButton.Location = new System.Drawing.Point(424, 103);
			this.OutputFileOpenButton.Name = "OutputFileOpenButton";
			this.OutputFileOpenButton.Size = new System.Drawing.Size(95, 29);
			this.OutputFileOpenButton.TabIndex = 8;
			this.OutputFileOpenButton.Text = "開く";
			this.OutputFileOpenButton.UseVisualStyleBackColor = true;
			this.OutputFileOpenButton.Click += new System.EventHandler(this.OutputFileOpenButton_Click_1);
			// 
			// openOutputFileDialog
			// 
			this.openOutputFileDialog.FileName = "openOutputFileDialog";
			// 
			// OutputPathLabel
			// 
			this.OutputPathLabel.AutoSize = true;
			this.OutputPathLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.OutputPathLabel.Location = new System.Drawing.Point(22, 88);
			this.OutputPathLabel.Name = "OutputPathLabel";
			this.OutputPathLabel.Size = new System.Drawing.Size(124, 13);
			this.OutputPathLabel.TabIndex = 9;
			this.OutputPathLabel.Text = "出力先ディレクトリ";
			// 
			// InputPathLabel
			// 
			this.InputPathLabel.AutoSize = true;
			this.InputPathLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.InputPathLabel.Location = new System.Drawing.Point(22, 17);
			this.InputPathLabel.Name = "InputPathLabel";
			this.InputPathLabel.Size = new System.Drawing.Size(85, 13);
			this.InputPathLabel.TabIndex = 10;
			this.InputPathLabel.Text = "入力ファイル";
			// 
			// InputConfigText
			// 
			this.InputConfigText.AutoSize = true;
			this.InputConfigText.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.InputConfigText.Location = new System.Drawing.Point(25, 55);
			this.InputConfigText.Name = "InputConfigText";
			this.InputConfigText.Size = new System.Drawing.Size(215, 12);
			this.InputConfigText.TabIndex = 16;
			this.InputConfigText.Text = "NVMデータファイルを選択してください";
			// 
			// OutputConfigText
			// 
			this.OutputConfigText.AutoSize = true;
			this.OutputConfigText.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.OutputConfigText.Location = new System.Drawing.Point(26, 125);
			this.OutputConfigText.Name = "OutputConfigText";
			this.OutputConfigText.Size = new System.Drawing.Size(383, 12);
			this.OutputConfigText.TabIndex = 17;
			this.OutputConfigText.Text = "生成したNVM書き込みコードのファイルの保存場所を選択してください";
			// 
			// RsCommandLabel
			// 
			this.RsCommandLabel.AutoSize = true;
			this.RsCommandLabel.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.RsCommandLabel.Location = new System.Drawing.Point(22, 154);
			this.RsCommandLabel.Name = "RsCommandLabel";
			this.RsCommandLabel.Size = new System.Drawing.Size(86, 13);
			this.RsCommandLabel.TabIndex = 21;
			this.RsCommandLabel.Text = "RSコマンド名";
			// 
			// RsCommandNameText
			// 
			this.RsCommandNameText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RsCommandNameText.Location = new System.Drawing.Point(25, 170);
			this.RsCommandNameText.MaxLength = 12;
			this.RsCommandNameText.Name = "RsCommandNameText";
			this.RsCommandNameText.Size = new System.Drawing.Size(107, 23);
			this.RsCommandNameText.TabIndex = 20;
			this.RsCommandNameText.TextChanged += new System.EventHandler(this.RsCommandNameText_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(147, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "RAMモニタコマンド名";
			// 
			// RamCommandNameText
			// 
			this.RamCommandNameText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RamCommandNameText.Location = new System.Drawing.Point(150, 170);
			this.RamCommandNameText.MaxLength = 12;
			this.RamCommandNameText.Name = "RamCommandNameText";
			this.RamCommandNameText.Size = new System.Drawing.Size(107, 23);
			this.RamCommandNameText.TabIndex = 22;
			this.RamCommandNameText.TextChanged += new System.EventHandler(this.RamCommandNameText_TextChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("BIZ UDPゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tabControl1.Location = new System.Drawing.Point(0, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(564, 386);
			this.tabControl1.TabIndex = 24;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.MaxWriteBlockText);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.MaxWriteSizeText);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.MinWriteSizeText);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.MaxWriteAddrText);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.MinWriteAddrText);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.checkBox1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.CommentText);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.OutputConfigText);
			this.tabPage1.Controls.Add(this.RsCommandNameText);
			this.tabPage1.Controls.Add(this.InputConfigText);
			this.tabPage1.Controls.Add(this.RamCommandNameText);
			this.tabPage1.Controls.Add(this.RsCommandLabel);
			this.tabPage1.Controls.Add(this.OutputFileOpenButton);
			this.tabPage1.Controls.Add(this.InputPath);
			this.tabPage1.Controls.Add(this.InputFileOpenButton);
			this.tabPage1.Controls.Add(this.OutputPath);
			this.tabPage1.Controls.Add(this.ActionButton);
			this.tabPage1.Controls.Add(this.OutputPathLabel);
			this.tabPage1.Controls.Add(this.InputPathLabel);
			this.tabPage1.Font = new System.Drawing.Font("BIZ UDPゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tabPage1.Location = new System.Drawing.Point(4, 21);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(556, 361);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "NVM書き込み";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// MaxWriteBlockText
			// 
			this.MaxWriteBlockText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxWriteBlockText.Location = new System.Drawing.Point(217, 219);
			this.MaxWriteBlockText.MaxLength = 12;
			this.MaxWriteBlockText.Name = "MaxWriteBlockText";
			this.MaxWriteBlockText.Size = new System.Drawing.Size(40, 23);
			this.MaxWriteBlockText.TabIndex = 36;
			this.MaxWriteBlockText.Text = "3";
			this.MaxWriteBlockText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MaxWriteBlockText.TextChanged += new System.EventHandler(this.MaxWriteBlockText_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.Location = new System.Drawing.Point(214, 203);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(176, 13);
			this.label8.TabIndex = 37;
			this.label8.Text = "最大書き込み可能ブロック数";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("BIZ UDゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(23, 300);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(413, 12);
			this.label7.TabIndex = 35;
			this.label7.Text = "最小値は、1[LSB]につき何byte分のアドレス範囲を表しているかを示します";
			// 
			// MaxWriteSizeText
			// 
			this.MaxWriteSizeText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxWriteSizeText.Location = new System.Drawing.Point(98, 274);
			this.MaxWriteSizeText.MaxLength = 12;
			this.MaxWriteSizeText.Name = "MaxWriteSizeText";
			this.MaxWriteSizeText.Size = new System.Drawing.Size(40, 23);
			this.MaxWriteSizeText.TabIndex = 33;
			this.MaxWriteSizeText.Text = "64";
			this.MaxWriteSizeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MaxWriteSizeText.TextChanged += new System.EventHandler(this.MaxWriteSizeText_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(72, 278);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 13);
			this.label5.TabIndex = 34;
			this.label5.Text = "～";
			// 
			// MinWriteSizeText
			// 
			this.MinWriteSizeText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinWriteSizeText.Location = new System.Drawing.Point(25, 274);
			this.MinWriteSizeText.MaxLength = 12;
			this.MinWriteSizeText.Name = "MinWriteSizeText";
			this.MinWriteSizeText.Size = new System.Drawing.Size(40, 23);
			this.MinWriteSizeText.TabIndex = 31;
			this.MinWriteSizeText.Text = "1";
			this.MinWriteSizeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MinWriteSizeText.TextChanged += new System.EventHandler(this.MinWriteSizeText_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(22, 258);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(137, 13);
			this.label6.TabIndex = 32;
			this.label6.Text = "書き込みデータサイズ";
			// 
			// MaxWriteAddrText
			// 
			this.MaxWriteAddrText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxWriteAddrText.Location = new System.Drawing.Point(114, 219);
			this.MaxWriteAddrText.MaxLength = 12;
			this.MaxWriteAddrText.Name = "MaxWriteAddrText";
			this.MaxWriteAddrText.Size = new System.Drawing.Size(61, 23);
			this.MaxWriteAddrText.TabIndex = 29;
			this.MaxWriteAddrText.Text = "FFFF";
			this.MaxWriteAddrText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MaxWriteAddrText.TextChanged += new System.EventHandler(this.MaxWriteAddrText_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(91, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 13);
			this.label4.TabIndex = 30;
			this.label4.Text = "～";
			// 
			// MinWriteAddrText
			// 
			this.MinWriteAddrText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinWriteAddrText.Location = new System.Drawing.Point(25, 219);
			this.MinWriteAddrText.MaxLength = 12;
			this.MinWriteAddrText.Name = "MinWriteAddrText";
			this.MinWriteAddrText.Size = new System.Drawing.Size(61, 23);
			this.MinWriteAddrText.TabIndex = 27;
			this.MinWriteAddrText.Text = "0000";
			this.MinWriteAddrText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MinWriteAddrText.TextChanged += new System.EventHandler(this.MinWriteAddrText_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(22, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 13);
			this.label3.TabIndex = 28;
			this.label3.Text = "書き込みアドレス範囲(0x)";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Font = new System.Drawing.Font("BIZ UDPゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.checkBox1.Location = new System.Drawing.Point(25, 328);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(229, 16);
			this.checkBox1.TabIndex = 26;
			this.checkBox1.Text = "アドレスの下位上位を反転させますか?";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("BIZ UDゴシック", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(307, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 25;
			this.label2.Text = "コメント";
			// 
			// CommentText
			// 
			this.CommentText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CommentText.Font = new System.Drawing.Font("BIZ UDPゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CommentText.Location = new System.Drawing.Point(310, 170);
			this.CommentText.MaximumSize = new System.Drawing.Size(1000, 22);
			this.CommentText.MaxLength = 50;
			this.CommentText.MinimumSize = new System.Drawing.Size(200, 22);
			this.CommentText.Name = "CommentText";
			this.CommentText.Size = new System.Drawing.Size(210, 20);
			this.CommentText.TabIndex = 24;
			this.CommentText.TextChanged += new System.EventHandler(this.CommentText_TextChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 21);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(556, 361);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "    ";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 411);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(1160, 450);
			this.MinimumSize = new System.Drawing.Size(580, 450);
			this.Name = "Form1";
			this.Text = "App";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openInputFileDialog;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripTextBox1;
		private System.Windows.Forms.TextBox InputPath;
		private System.Windows.Forms.Button ActionButton;
		private System.Windows.Forms.Button InputFileOpenButton;
		private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
		private System.Windows.Forms.TextBox OutputPath;
		private System.Windows.Forms.Button OutputFileOpenButton;
		private System.Windows.Forms.OpenFileDialog openOutputFileDialog;
		private System.Windows.Forms.Label OutputPathLabel;
		private System.Windows.Forms.Label InputPathLabel;
		private System.Windows.Forms.ToolStripMenuItem プロパティEToolStripMenuItem;
		private System.Windows.Forms.Label InputConfigText;
		private System.Windows.Forms.Label OutputConfigText;
		private System.Windows.Forms.Label RsCommandLabel;
		private System.Windows.Forms.TextBox RsCommandNameText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox RamCommandNameText;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CommentText;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox MaxWriteAddrText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox MinWriteAddrText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox MaxWriteSizeText;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox MinWriteSizeText;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox MaxWriteBlockText;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}


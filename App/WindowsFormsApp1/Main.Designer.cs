namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.connectT = new System.Windows.Forms.TextBox();
            this.MTT = new System.Windows.Forms.TextBox();
            this.VertexList = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.reference = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.userName = new System.Windows.Forms.Label();
            this.autorisation = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.create = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.File1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectT
            // 
            this.connectT.Location = new System.Drawing.Point(12, 124);
            this.connectT.Name = "connectT";
            this.connectT.Size = new System.Drawing.Size(138, 23);
            this.connectT.TabIndex = 6;
            this.connectT.Text = "\"p1\" \"p2\" \"count\"";
            this.connectT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.connectT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connectT_MouseClick);
            this.connectT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.connectT_KeyPress);
            // 
            // MTT
            // 
            this.MTT.Location = new System.Drawing.Point(9, 153);
            this.MTT.Name = "MTT";
            this.MTT.Size = new System.Drawing.Size(141, 23);
            this.MTT.TabIndex = 8;
            this.MTT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTT_KeyPress);
            // 
            // VertexList
            // 
            this.VertexList.Location = new System.Drawing.Point(645, 53);
            this.VertexList.Name = "VertexList";
            this.VertexList.Size = new System.Drawing.Size(69, 381);
            this.VertexList.TabIndex = 9;
            this.VertexList.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.reference});
            this.toolStrip1.Location = new System.Drawing.Point(9, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(141, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // reference
            // 
            this.reference.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reference.Image = ((System.Drawing.Image)(resources.GetObject("reference.Image")));
            this.reference.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reference.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(23, 24);
            this.reference.Text = "Справка";
            this.reference.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.reference.Click += new System.EventHandler(this.reference_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(667, 21);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(40, 15);
            this.userName.TabIndex = 12;
            this.userName.Text = "label1";
            this.userName.UseWaitCursor = true;
            this.userName.Visible = false;
            // 
            // autorisation
            // 
            this.autorisation.AutoSize = true;
            this.autorisation.LinkColor = System.Drawing.Color.Black;
            this.autorisation.Location = new System.Drawing.Point(644, 21);
            this.autorisation.Name = "autorisation";
            this.autorisation.Size = new System.Drawing.Size(72, 15);
            this.autorisation.TabIndex = 13;
            this.autorisation.TabStop = true;
            this.autorisation.Text = "autorisation";
            this.autorisation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.autorisation_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Controls.Add(this.create, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.File1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(141, 76);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // create
            // 
            this.create.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.create.Location = new System.Drawing.Point(3, 3);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(61, 24);
            this.create.TabIndex = 0;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "MT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // File1
            // 
            this.File1.Location = new System.Drawing.Point(70, 3);
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(71, 27);
            this.File1.TabIndex = 3;
            this.File1.Text = "File";
            this.File1.UseVisualStyleBackColor = true;
            this.File1.Click += new System.EventHandler(this.File1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.autorisation);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.VertexList);
            this.Controls.Add(this.MTT);
            this.Controls.Add(this.connectT);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.DoubleClick += new System.EventHandler(this.Main_DoubleClick);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.TextBox connectT;
        private System.Windows.Forms.TextBox MTT;
        private System.Windows.Forms.RichTextBox VertexList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Label userName;
        public System.Windows.Forms.LinkLabel autorisation;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button File1;
        private System.Windows.Forms.ToolStripButton reference;
    }
}


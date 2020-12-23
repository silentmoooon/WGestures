using System.Windows.Forms;
using WGestures.App.Gui.Windows.Controls;

namespace WGestures.App.Gui.Windows
{
    partial class EditAppForm
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

            if (disposing)
            {
                _editingApp = null;
                _intentStore = null;
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
            this.components = new System.ComponentModel.Container();
            this.dlgSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.groupSelectedApp = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lnkSelectedAppPath = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSelectedAppNae = new System.Windows.Forms.TextBox();
            this.flowAlert = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_errMsg = new System.Windows.Forms.Label();
            this.pictureSelectedAppIcon = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelFileDrop = new System.Windows.Forms.Panel();
            this.pictureWindowSelector = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lineFlowLayout1 = new WGestures.App.Gui.Windows.Controls.LineFlowLayout();
            this.label1 = new System.Windows.Forms.Label();
            this.lineFlowLayout2 = new WGestures.App.Gui.Windows.Controls.LineFlowLayout();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_RemoveGesture = new WGestures.App.Gui.Windows.Controls.MetroButton();
            this.groupSelectedApp.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelectedAppIcon)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWindowSelector)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.lineFlowLayout1.SuspendLayout();
            this.lineFlowLayout2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgSelectFile
            // 
            this.dlgSelectFile.DefaultExt = "exe";
            this.dlgSelectFile.FileName = "App";
            this.dlgSelectFile.Filter = "exe|*.exe";
            this.dlgSelectFile.Title = "选择要添加的程序";
            // 
            // groupSelectedApp
            // 
            this.groupSelectedApp.AutoSize = true;
            this.groupSelectedApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupSelectedApp.Controls.Add(this.btn_RemoveGesture);
            this.groupSelectedApp.Controls.Add(this.listBox1);
            this.groupSelectedApp.Controls.Add(this.flowLayoutPanel6);
            this.groupSelectedApp.Controls.Add(this.pictureSelectedAppIcon);
            this.groupSelectedApp.Location = new System.Drawing.Point(10, 216);
            this.groupSelectedApp.Margin = new System.Windows.Forms.Padding(10);
            this.groupSelectedApp.Name = "groupSelectedApp";
            this.groupSelectedApp.Padding = new System.Windows.Forms.Padding(2);
            this.groupSelectedApp.Size = new System.Drawing.Size(525, 195);
            this.groupSelectedApp.TabIndex = 1;
            this.groupSelectedApp.TabStop = false;
            this.groupSelectedApp.Text = "选中";
            this.groupSelectedApp.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(11, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(509, 124);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel6.Controls.Add(this.flowAlert);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(79, 30);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(438, 115);
            this.flowLayoutPanel6.TabIndex = 8;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.Controls.Add(this.label10);
            this.flowLayoutPanel7.Controls.Add(this.lnkSelectedAppPath);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(430, 30);
            this.flowLayoutPanel7.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "路径:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkSelectedAppPath
            // 
            this.lnkSelectedAppPath.AutoEllipsis = true;
            this.lnkSelectedAppPath.Location = new System.Drawing.Point(57, 4);
            this.lnkSelectedAppPath.Margin = new System.Windows.Forms.Padding(4);
            this.lnkSelectedAppPath.Name = "lnkSelectedAppPath";
            this.lnkSelectedAppPath.Size = new System.Drawing.Size(369, 22);
            this.lnkSelectedAppPath.TabIndex = 1;
            this.lnkSelectedAppPath.TabStop = true;
            this.lnkSelectedAppPath.Text = "linkLabel1";
            this.lnkSelectedAppPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkSelectedAppPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectedAppPath_LinkClicked);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel8.Controls.Add(this.label11);
            this.flowLayoutPanel8.Controls.Add(this.txtSelectedAppNae);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(4, 42);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(429, 33);
            this.flowLayoutPanel8.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "名称:";
            // 
            // txtSelectedAppNae
            // 
            this.txtSelectedAppNae.CausesValidation = false;
            this.flowLayoutPanel8.SetFlowBreak(this.txtSelectedAppNae, true);
            this.txtSelectedAppNae.HideSelection = false;
            this.txtSelectedAppNae.Location = new System.Drawing.Point(57, 4);
            this.txtSelectedAppNae.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelectedAppNae.Name = "txtSelectedAppNae";
            this.txtSelectedAppNae.Size = new System.Drawing.Size(368, 25);
            this.txtSelectedAppNae.TabIndex = 2;
            this.txtSelectedAppNae.WordWrap = false;
            this.txtSelectedAppNae.TextChanged += new System.EventHandler(this.txtSelectedAppNae_TextChanged);
            // 
            // flowAlert
            // 
            this.flowAlert.Controls.Add(this.pictureBox1);
            this.flowAlert.Controls.Add(this.lb_errMsg);
            this.flowAlert.Location = new System.Drawing.Point(4, 83);
            this.flowAlert.Margin = new System.Windows.Forms.Padding(4);
            this.flowAlert.Name = "flowAlert";
            this.flowAlert.Size = new System.Drawing.Size(429, 28);
            this.flowAlert.TabIndex = 7;
            this.flowAlert.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WGestures.App.Properties.Resources.Alert;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lb_errMsg
            // 
            this.lb_errMsg.AutoSize = true;
            this.lb_errMsg.ForeColor = System.Drawing.Color.Red;
            this.lb_errMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_errMsg.Location = new System.Drawing.Point(32, 4);
            this.lb_errMsg.Margin = new System.Windows.Forms.Padding(4);
            this.lb_errMsg.Name = "lb_errMsg";
            this.lb_errMsg.Size = new System.Drawing.Size(233, 15);
            this.lb_errMsg.TabIndex = 4;
            this.lb_errMsg.Text = "应用程序已在列表中, 请重新选择";
            // 
            // pictureSelectedAppIcon
            // 
            this.pictureSelectedAppIcon.Location = new System.Drawing.Point(11, 32);
            this.pictureSelectedAppIcon.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.pictureSelectedAppIcon.Name = "pictureSelectedAppIcon";
            this.pictureSelectedAppIcon.Size = new System.Drawing.Size(60, 60);
            this.pictureSelectedAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSelectedAppIcon.TabIndex = 3;
            this.pictureSelectedAppIcon.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(432, 10);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 12, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(328, 10);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 32);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "保存";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.btnCancel);
            this.flowLayoutPanel4.Controls.Add(this.btnOk);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 480);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel4.Size = new System.Drawing.Size(540, 52);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel5.Controls.Add(this.panel1);
            this.flowLayoutPanel5.Controls.Add(this.groupSelectedApp);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(540, 480);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.lineFlowLayout1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panelFileDrop);
            this.panel1.Controls.Add(this.lineFlowLayout2);
            this.panel1.Controls.Add(this.pictureWindowSelector);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 186);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.label9);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(385, 116);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(112, 48);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "从对话框选择";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "exe或快捷方式";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WGestures.App.Properties.Resources.block;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.btnSelectFile);
            this.panel3.Location = new System.Drawing.Point(391, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 80);
            this.panel3.TabIndex = 3;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(188)))), ((int)(((byte)(216)))));
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectFile.Location = new System.Drawing.Point(9, 22);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(62, 32);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.TabStop = false;
            this.btnSelectFile.Text = "选择...";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 116);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(112, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "拖拽十字符号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "到目标窗口上";
            // 
            // panelFileDrop
            // 
            this.panelFileDrop.AllowDrop = true;
            this.panelFileDrop.BackgroundImage = global::WGestures.App.Properties.Resources.dropTarget;
            this.panelFileDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFileDrop.Location = new System.Drawing.Point(211, 26);
            this.panelFileDrop.Margin = new System.Windows.Forms.Padding(2);
            this.panelFileDrop.Name = "panelFileDrop";
            this.panelFileDrop.Size = new System.Drawing.Size(80, 80);
            this.panelFileDrop.TabIndex = 3;
            this.panelFileDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFileDrop_DragDrop);
            this.panelFileDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFileDrop_DragEnter);
            // 
            // pictureWindowSelector
            // 
            this.pictureWindowSelector.BackColor = System.Drawing.Color.Transparent;
            this.pictureWindowSelector.Image = global::WGestures.App.Properties.Resources.cross;
            this.pictureWindowSelector.Location = new System.Drawing.Point(31, 26);
            this.pictureWindowSelector.Margin = new System.Windows.Forms.Padding(2);
            this.pictureWindowSelector.Name = "pictureWindowSelector";
            this.pictureWindowSelector.Size = new System.Drawing.Size(80, 80);
            this.pictureWindowSelector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureWindowSelector.TabIndex = 1;
            this.pictureWindowSelector.TabStop = false;
            this.pictureWindowSelector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureWindowSelector_MouseDown);
            this.pictureWindowSelector.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureWindowSelector_MouseMove);
            this.pictureWindowSelector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureWindowSelector_MouseUp);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(206, 116);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(112, 48);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "拖放exe文件或";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "快捷方式到此";
            // 
            // lineFlowLayout1
            // 
            this.lineFlowLayout1.Controls.Add(this.label1);
            this.lineFlowLayout1.ForeColor = System.Drawing.Color.Gray;
            this.lineFlowLayout1.Location = new System.Drawing.Point(141, 21);
            this.lineFlowLayout1.Margin = new System.Windows.Forms.Padding(2);
            this.lineFlowLayout1.Name = "lineFlowLayout1";
            this.lineFlowLayout1.Size = new System.Drawing.Size(41, 155);
            this.lineFlowLayout1.TabIndex = 0;
            this.lineFlowLayout1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 58, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "或者";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineFlowLayout2
            // 
            this.lineFlowLayout2.Controls.Add(this.label2);
            this.lineFlowLayout2.ForeColor = System.Drawing.Color.Gray;
            this.lineFlowLayout2.Location = new System.Drawing.Point(321, 21);
            this.lineFlowLayout2.Margin = new System.Windows.Forms.Padding(2);
            this.lineFlowLayout2.Name = "lineFlowLayout2";
            this.lineFlowLayout2.Size = new System.Drawing.Size(41, 155);
            this.lineFlowLayout2.TabIndex = 0;
            this.lineFlowLayout2.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 58, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "或者";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_RemoveGesture
            // 
            this.btn_RemoveGesture.Enabled = false;
            this.btn_RemoveGesture.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold);
            this.btn_RemoveGesture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_RemoveGesture.Image = global::WGestures.App.Properties.Resources.remove;
            this.btn_RemoveGesture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_RemoveGesture.Location = new System.Drawing.Point(11, 150);
            this.btn_RemoveGesture.Margin = new System.Windows.Forms.Padding(0);
            this.btn_RemoveGesture.Name = "btn_RemoveGesture";
            this.btn_RemoveGesture.Size = new System.Drawing.Size(38, 25);
            this.btn_RemoveGesture.TabIndex = 10;
            this.btn_RemoveGesture.UseVisualStyleBackColor = true;
            this.btn_RemoveGesture.Click += new System.EventHandler(this.btn_RemoveGesture_Click);
            // 
            // EditAppForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(540, 532);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EditAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加应用程序";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditAppForm_Load);
            this.groupSelectedApp.ResumeLayout(false);
            this.groupSelectedApp.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowAlert.ResumeLayout(false);
            this.flowAlert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelectedAppIcon)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWindowSelector)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.lineFlowLayout1.ResumeLayout(false);
            this.lineFlowLayout1.PerformLayout();
            this.lineFlowLayout2.ResumeLayout(false);
            this.lineFlowLayout2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LineFlowLayout lineFlowLayout1;
        private System.Windows.Forms.Label label1;
        private LineFlowLayout lineFlowLayout2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureWindowSelector;
        private System.Windows.Forms.Panel panelFileDrop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.OpenFileDialog dlgSelectFile;
        private System.Windows.Forms.GroupBox groupSelectedApp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel lnkSelectedAppPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSelectedAppNae;
        private System.Windows.Forms.PictureBox pictureSelectedAppIcon;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label lb_errMsg;
        private System.Windows.Forms.FlowLayoutPanel flowAlert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanel8;
        private Panel panel1;
        private ListBox listBox1;
        private MetroButton btn_RemoveGesture;
    }
}
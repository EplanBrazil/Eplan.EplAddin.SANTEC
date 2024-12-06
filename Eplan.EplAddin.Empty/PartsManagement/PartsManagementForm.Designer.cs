namespace Eplan.EplAddin.Santec
{
    partial class PartsManagementForm
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
                RemoveExtraRows();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsManagementForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.okButton = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.topFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.digits1to3FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.digits1to3Label = new MaterialSkin.Controls.MaterialLabel();
            this.digits1to3ComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.digits4to7FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.digits4to7Label = new MaterialSkin.Controls.MaterialLabel();
            this.digits4to7ComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.digits8to9FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.digits8to9Label = new MaterialSkin.Controls.MaterialLabel();
            this.digits8to9ComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.centerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemDescriptionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemDescriptionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.itemDescriptionTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.itemCodeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemCodeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.itemCodeTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.manufacturerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manufacturerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.providerTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.newItemFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newItemLabel = new MaterialSkin.Controls.MaterialLabel();
            this.newItemCheckBox = new System.Windows.Forms.CheckBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.topFlowLayoutPanel.SuspendLayout();
            this.digits1to3FlowLayoutPanel.SuspendLayout();
            this.digits4to7FlowLayoutPanel.SuspendLayout();
            this.digits8to9FlowLayoutPanel.SuspendLayout();
            this.centerFlowLayoutPanel.SuspendLayout();
            this.itemDescriptionFlowLayoutPanel.SuspendLayout();
            this.itemCodeFlowLayoutPanel.SuspendLayout();
            this.manufacturerFlowLayoutPanel.SuspendLayout();
            this.newItemFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.bottomToolStrip, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(3, 64);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(552, 314);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // bottomToolStrip
            // 
            this.bottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bottomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelButton,
            this.toolStripSeparator1,
            this.okButton});
            this.bottomToolStrip.Location = new System.Drawing.Point(3, 285);
            this.bottomToolStrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bottomToolStrip.Size = new System.Drawing.Size(546, 27);
            this.bottomToolStrip.TabIndex = 2;
            this.bottomToolStrip.Text = "toolStrip1";
            // 
            // cancelButton
            // 
            this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 24);
            this.cancelButton.Text = "Cancelar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // okButton
            // 
            this.okButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(127, 28);
            this.okButton.Text = "Inserir Novo Item";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.centerFlowLayoutPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.topFlowLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 277);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // topFlowLayoutPanel
            // 
            this.topFlowLayoutPanel.AutoScroll = true;
            this.topFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topFlowLayoutPanel.Controls.Add(this.digits1to3FlowLayoutPanel);
            this.topFlowLayoutPanel.Controls.Add(this.digits4to7FlowLayoutPanel);
            this.topFlowLayoutPanel.Controls.Add(this.digits8to9FlowLayoutPanel);
            this.topFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topFlowLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.topFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topFlowLayoutPanel.Name = "topFlowLayoutPanel";
            this.topFlowLayoutPanel.Size = new System.Drawing.Size(267, 273);
            this.topFlowLayoutPanel.TabIndex = 1;
            // 
            // digits1to3FlowLayoutPanel
            // 
            this.digits1to3FlowLayoutPanel.AutoSize = true;
            this.digits1to3FlowLayoutPanel.Controls.Add(this.digits1to3Label);
            this.digits1to3FlowLayoutPanel.Controls.Add(this.digits1to3ComboBox);
            this.digits1to3FlowLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.digits1to3FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.digits1to3FlowLayoutPanel.Name = "digits1to3FlowLayoutPanel";
            this.digits1to3FlowLayoutPanel.Size = new System.Drawing.Size(255, 58);
            this.digits1to3FlowLayoutPanel.TabIndex = 4;
            // 
            // digits1to3Label
            // 
            this.digits1to3Label.AutoSize = true;
            this.digits1to3Label.Depth = 0;
            this.digits1to3Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.digits1to3Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.digits1to3Label.Location = new System.Drawing.Point(3, 0);
            this.digits1to3Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.digits1to3Label.Name = "digits1to3Label";
            this.digits1to3Label.Size = new System.Drawing.Size(108, 19);
            this.digits1to3Label.TabIndex = 0;
            this.digits1to3Label.Text = "Digitos 01 a 03";
            this.digits1to3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // digits1to3ComboBox
            // 
            this.digits1to3ComboBox.AutoResize = false;
            this.digits1to3ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digits1to3ComboBox.Depth = 0;
            this.digits1to3ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.digits1to3ComboBox.DropDownHeight = 118;
            this.digits1to3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.digits1to3ComboBox.DropDownWidth = 121;
            this.digits1to3ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.digits1to3ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.digits1to3ComboBox.FormattingEnabled = true;
            this.digits1to3ComboBox.IntegralHeight = false;
            this.digits1to3ComboBox.ItemHeight = 29;
            this.digits1to3ComboBox.Location = new System.Drawing.Point(3, 21);
            this.digits1to3ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.digits1to3ComboBox.MaxDropDownItems = 4;
            this.digits1to3ComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.digits1to3ComboBox.Name = "digits1to3ComboBox";
            this.digits1to3ComboBox.Size = new System.Drawing.Size(249, 35);
            this.digits1to3ComboBox.StartIndex = 0;
            this.digits1to3ComboBox.TabIndex = 1;
            this.digits1to3ComboBox.UseAccent = false;
            this.digits1to3ComboBox.UseTallSize = false;
            // 
            // digits4to7FlowLayoutPanel
            // 
            this.digits4to7FlowLayoutPanel.AutoSize = true;
            this.digits4to7FlowLayoutPanel.Controls.Add(this.digits4to7Label);
            this.digits4to7FlowLayoutPanel.Controls.Add(this.digits4to7ComboBox);
            this.digits4to7FlowLayoutPanel.Location = new System.Drawing.Point(3, 64);
            this.digits4to7FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.digits4to7FlowLayoutPanel.Name = "digits4to7FlowLayoutPanel";
            this.digits4to7FlowLayoutPanel.Size = new System.Drawing.Size(255, 58);
            this.digits4to7FlowLayoutPanel.TabIndex = 5;
            // 
            // digits4to7Label
            // 
            this.digits4to7Label.AutoSize = true;
            this.digits4to7Label.Depth = 0;
            this.digits4to7Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.digits4to7Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.digits4to7Label.Location = new System.Drawing.Point(3, 0);
            this.digits4to7Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.digits4to7Label.Name = "digits4to7Label";
            this.digits4to7Label.Size = new System.Drawing.Size(108, 19);
            this.digits4to7Label.TabIndex = 2;
            this.digits4to7Label.Text = "Digitos 04 a 07";
            this.digits4to7Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // digits4to7ComboBox
            // 
            this.digits4to7ComboBox.AutoResize = false;
            this.digits4to7ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digits4to7ComboBox.Depth = 0;
            this.digits4to7ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.digits4to7ComboBox.DropDownHeight = 118;
            this.digits4to7ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.digits4to7ComboBox.DropDownWidth = 121;
            this.digits4to7ComboBox.Enabled = false;
            this.digits4to7ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.digits4to7ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.digits4to7ComboBox.FormattingEnabled = true;
            this.digits4to7ComboBox.IntegralHeight = false;
            this.digits4to7ComboBox.ItemHeight = 29;
            this.digits4to7ComboBox.Location = new System.Drawing.Point(3, 21);
            this.digits4to7ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.digits4to7ComboBox.MaxDropDownItems = 4;
            this.digits4to7ComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.digits4to7ComboBox.Name = "digits4to7ComboBox";
            this.digits4to7ComboBox.Size = new System.Drawing.Size(249, 35);
            this.digits4to7ComboBox.StartIndex = 0;
            this.digits4to7ComboBox.TabIndex = 3;
            this.digits4to7ComboBox.UseAccent = false;
            this.digits4to7ComboBox.UseTallSize = false;
            // 
            // digits8to9FlowLayoutPanel
            // 
            this.digits8to9FlowLayoutPanel.AutoSize = true;
            this.digits8to9FlowLayoutPanel.Controls.Add(this.digits8to9Label);
            this.digits8to9FlowLayoutPanel.Controls.Add(this.digits8to9ComboBox);
            this.digits8to9FlowLayoutPanel.Location = new System.Drawing.Point(3, 126);
            this.digits8to9FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.digits8to9FlowLayoutPanel.Name = "digits8to9FlowLayoutPanel";
            this.digits8to9FlowLayoutPanel.Size = new System.Drawing.Size(255, 58);
            this.digits8to9FlowLayoutPanel.TabIndex = 6;
            // 
            // digits8to9Label
            // 
            this.digits8to9Label.AutoSize = true;
            this.digits8to9Label.Depth = 0;
            this.digits8to9Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.digits8to9Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.digits8to9Label.Location = new System.Drawing.Point(3, 0);
            this.digits8to9Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.digits8to9Label.Name = "digits8to9Label";
            this.digits8to9Label.Size = new System.Drawing.Size(107, 19);
            this.digits8to9Label.TabIndex = 2;
            this.digits8to9Label.Text = "Digitos 08 e 09";
            this.digits8to9Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // digits8to9ComboBox
            // 
            this.digits8to9ComboBox.AutoResize = false;
            this.digits8to9ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digits8to9ComboBox.Depth = 0;
            this.digits8to9ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.digits8to9ComboBox.DropDownHeight = 118;
            this.digits8to9ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.digits8to9ComboBox.DropDownWidth = 121;
            this.digits8to9ComboBox.Enabled = false;
            this.digits8to9ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.digits8to9ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.digits8to9ComboBox.FormattingEnabled = true;
            this.digits8to9ComboBox.IntegralHeight = false;
            this.digits8to9ComboBox.ItemHeight = 29;
            this.digits8to9ComboBox.Location = new System.Drawing.Point(3, 21);
            this.digits8to9ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.digits8to9ComboBox.MaxDropDownItems = 4;
            this.digits8to9ComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.digits8to9ComboBox.Name = "digits8to9ComboBox";
            this.digits8to9ComboBox.Size = new System.Drawing.Size(249, 35);
            this.digits8to9ComboBox.StartIndex = 0;
            this.digits8to9ComboBox.TabIndex = 3;
            this.digits8to9ComboBox.UseAccent = false;
            this.digits8to9ComboBox.UseTallSize = false;
            // 
            // centerFlowLayoutPanel
            // 
            this.centerFlowLayoutPanel.AutoScroll = true;
            this.centerFlowLayoutPanel.AutoSize = true;
            this.centerFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centerFlowLayoutPanel.Controls.Add(this.itemDescriptionFlowLayoutPanel);
            this.centerFlowLayoutPanel.Controls.Add(this.itemCodeFlowLayoutPanel);
            this.centerFlowLayoutPanel.Controls.Add(this.manufacturerFlowLayoutPanel);
            this.centerFlowLayoutPanel.Controls.Add(this.newItemFlowLayoutPanel);
            this.centerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerFlowLayoutPanel.Location = new System.Drawing.Point(276, 2);
            this.centerFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.centerFlowLayoutPanel.Name = "centerFlowLayoutPanel";
            this.centerFlowLayoutPanel.Size = new System.Drawing.Size(267, 273);
            this.centerFlowLayoutPanel.TabIndex = 5;
            // 
            // itemDescriptionFlowLayoutPanel
            // 
            this.itemDescriptionFlowLayoutPanel.AutoSize = true;
            this.itemDescriptionFlowLayoutPanel.Controls.Add(this.itemDescriptionLabel);
            this.itemDescriptionFlowLayoutPanel.Controls.Add(this.itemDescriptionTextBox);
            this.itemDescriptionFlowLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.itemDescriptionFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemDescriptionFlowLayoutPanel.Name = "itemDescriptionFlowLayoutPanel";
            this.itemDescriptionFlowLayoutPanel.Size = new System.Drawing.Size(257, 59);
            this.itemDescriptionFlowLayoutPanel.TabIndex = 7;
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Depth = 0;
            this.itemDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemDescriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemDescriptionLabel.Location = new System.Drawing.Point(3, 0);
            this.itemDescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(71, 19);
            this.itemDescriptionLabel.TabIndex = 2;
            this.itemDescriptionLabel.Text = "Descrição";
            this.itemDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.AnimateReadOnly = false;
            this.itemDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemDescriptionTextBox.Depth = 0;
            this.itemDescriptionTextBox.Enabled = false;
            this.itemDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemDescriptionTextBox.LeadingIcon = null;
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(3, 21);
            this.itemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemDescriptionTextBox.MaxLength = 1000;
            this.itemDescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.itemDescriptionTextBox.Multiline = false;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(251, 36);
            this.itemDescriptionTextBox.TabIndex = 4;
            this.itemDescriptionTextBox.Text = "";
            this.itemDescriptionTextBox.TrailingIcon = null;
            this.itemDescriptionTextBox.UseTallSize = false;
            // 
            // itemCodeFlowLayoutPanel
            // 
            this.itemCodeFlowLayoutPanel.AutoSize = true;
            this.itemCodeFlowLayoutPanel.Controls.Add(this.itemCodeLabel);
            this.itemCodeFlowLayoutPanel.Controls.Add(this.itemCodeTextBox);
            this.itemCodeFlowLayoutPanel.Location = new System.Drawing.Point(3, 65);
            this.itemCodeFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemCodeFlowLayoutPanel.Name = "itemCodeFlowLayoutPanel";
            this.itemCodeFlowLayoutPanel.Size = new System.Drawing.Size(257, 59);
            this.itemCodeFlowLayoutPanel.TabIndex = 7;
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.Depth = 0;
            this.itemCodeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemCodeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemCodeLabel.Location = new System.Drawing.Point(3, 0);
            this.itemCodeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(51, 19);
            this.itemCodeLabel.TabIndex = 2;
            this.itemCodeLabel.Text = "Código";
            this.itemCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.AnimateReadOnly = false;
            this.itemCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemCodeTextBox.Depth = 0;
            this.itemCodeTextBox.Enabled = false;
            this.itemCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemCodeTextBox.LeadingIcon = null;
            this.itemCodeTextBox.Location = new System.Drawing.Point(3, 21);
            this.itemCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemCodeTextBox.MaxLength = 1000;
            this.itemCodeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.itemCodeTextBox.Multiline = false;
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(251, 36);
            this.itemCodeTextBox.TabIndex = 3;
            this.itemCodeTextBox.Text = "";
            this.itemCodeTextBox.TrailingIcon = null;
            this.itemCodeTextBox.UseTallSize = false;
            // 
            // manufacturerFlowLayoutPanel
            // 
            this.manufacturerFlowLayoutPanel.AutoSize = true;
            this.manufacturerFlowLayoutPanel.Controls.Add(this.manufacturerLabel);
            this.manufacturerFlowLayoutPanel.Controls.Add(this.providerTextBox);
            this.manufacturerFlowLayoutPanel.Location = new System.Drawing.Point(3, 128);
            this.manufacturerFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manufacturerFlowLayoutPanel.Name = "manufacturerFlowLayoutPanel";
            this.manufacturerFlowLayoutPanel.Size = new System.Drawing.Size(257, 59);
            this.manufacturerFlowLayoutPanel.TabIndex = 8;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Depth = 0;
            this.manufacturerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.manufacturerLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.manufacturerLabel.Location = new System.Drawing.Point(3, 0);
            this.manufacturerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(80, 19);
            this.manufacturerLabel.TabIndex = 2;
            this.manufacturerLabel.Text = "Fornecedor";
            this.manufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // providerTextBox
            // 
            this.providerTextBox.AnimateReadOnly = false;
            this.providerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.providerTextBox.Depth = 0;
            this.providerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.providerTextBox.LeadingIcon = null;
            this.providerTextBox.Location = new System.Drawing.Point(3, 21);
            this.providerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.providerTextBox.MaxLength = 1000;
            this.providerTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.providerTextBox.Multiline = false;
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.Size = new System.Drawing.Size(251, 36);
            this.providerTextBox.TabIndex = 3;
            this.providerTextBox.Text = "";
            this.providerTextBox.TrailingIcon = null;
            this.providerTextBox.UseTallSize = false;
            // 
            // newItemFlowLayoutPanel
            // 
            this.newItemFlowLayoutPanel.AutoSize = true;
            this.newItemFlowLayoutPanel.Controls.Add(this.newItemLabel);
            this.newItemFlowLayoutPanel.Controls.Add(this.newItemCheckBox);
            this.newItemFlowLayoutPanel.Enabled = false;
            this.newItemFlowLayoutPanel.Location = new System.Drawing.Point(3, 191);
            this.newItemFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newItemFlowLayoutPanel.Name = "newItemFlowLayoutPanel";
            this.newItemFlowLayoutPanel.Size = new System.Drawing.Size(103, 23);
            this.newItemFlowLayoutPanel.TabIndex = 9;
            // 
            // newItemLabel
            // 
            this.newItemLabel.AutoSize = true;
            this.newItemLabel.Depth = 0;
            this.newItemLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.newItemLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newItemLabel.Location = new System.Drawing.Point(3, 0);
            this.newItemLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.newItemLabel.Name = "newItemLabel";
            this.newItemLabel.Size = new System.Drawing.Size(73, 23);
            this.newItemLabel.TabIndex = 2;
            this.newItemLabel.Text = "Novo Item";
            this.newItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newItemCheckBox
            // 
            this.newItemCheckBox.AutoSize = true;
            this.newItemCheckBox.Location = new System.Drawing.Point(82, 3);
            this.newItemCheckBox.Name = "newItemCheckBox";
            this.newItemCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newItemCheckBox.Size = new System.Drawing.Size(18, 17);
            this.newItemCheckBox.TabIndex = 5;
            this.newItemCheckBox.UseVisualStyleBackColor = true;
            // 
            // PartsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 380);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PartsManagementForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Gerenciamento de Itens";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.topFlowLayoutPanel.ResumeLayout(false);
            this.topFlowLayoutPanel.PerformLayout();
            this.digits1to3FlowLayoutPanel.ResumeLayout(false);
            this.digits1to3FlowLayoutPanel.PerformLayout();
            this.digits4to7FlowLayoutPanel.ResumeLayout(false);
            this.digits4to7FlowLayoutPanel.PerformLayout();
            this.digits8to9FlowLayoutPanel.ResumeLayout(false);
            this.digits8to9FlowLayoutPanel.PerformLayout();
            this.centerFlowLayoutPanel.ResumeLayout(false);
            this.centerFlowLayoutPanel.PerformLayout();
            this.itemDescriptionFlowLayoutPanel.ResumeLayout(false);
            this.itemDescriptionFlowLayoutPanel.PerformLayout();
            this.itemCodeFlowLayoutPanel.ResumeLayout(false);
            this.itemCodeFlowLayoutPanel.PerformLayout();
            this.manufacturerFlowLayoutPanel.ResumeLayout(false);
            this.manufacturerFlowLayoutPanel.PerformLayout();
            this.newItemFlowLayoutPanel.ResumeLayout(false);
            this.newItemFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton okButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel centerFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel itemDescriptionFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel itemDescriptionLabel;
        private MaterialSkin.Controls.MaterialTextBox itemDescriptionTextBox;
        private System.Windows.Forms.FlowLayoutPanel itemCodeFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel itemCodeLabel;
        private MaterialSkin.Controls.MaterialTextBox itemCodeTextBox;
        private System.Windows.Forms.FlowLayoutPanel manufacturerFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel manufacturerLabel;
        private MaterialSkin.Controls.MaterialTextBox providerTextBox;
        private System.Windows.Forms.FlowLayoutPanel newItemFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel newItemLabel;
        private System.Windows.Forms.CheckBox newItemCheckBox;
        private System.Windows.Forms.FlowLayoutPanel topFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel digits1to3FlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel digits1to3Label;
        private MaterialSkin.Controls.MaterialComboBox digits1to3ComboBox;
        private System.Windows.Forms.FlowLayoutPanel digits4to7FlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel digits4to7Label;
        private MaterialSkin.Controls.MaterialComboBox digits4to7ComboBox;
        private System.Windows.Forms.FlowLayoutPanel digits8to9FlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel digits8to9Label;
        private MaterialSkin.Controls.MaterialComboBox digits8to9ComboBox;
    }
}
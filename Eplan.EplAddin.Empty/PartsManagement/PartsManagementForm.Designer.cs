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
            this.cancelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.okButton = new System.Windows.Forms.ToolStripButton();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.providerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.providerTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.topFlowLayoutPanel.SuspendLayout();
            this.digits1to3FlowLayoutPanel.SuspendLayout();
            this.digits4to7FlowLayoutPanel.SuspendLayout();
            this.digits8to9FlowLayoutPanel.SuspendLayout();
            this.centerFlowLayoutPanel.SuspendLayout();
            this.itemDescriptionFlowLayoutPanel.SuspendLayout();
            this.itemCodeFlowLayoutPanel.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.topFlowLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.bottomToolStrip, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.centerFlowLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(2, 52);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(290, 235);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // topFlowLayoutPanel
            // 
            this.topFlowLayoutPanel.AutoScroll = true;
            this.topFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topFlowLayoutPanel.Controls.Add(this.digits1to3FlowLayoutPanel);
            this.topFlowLayoutPanel.Controls.Add(this.digits4to7FlowLayoutPanel);
            this.topFlowLayoutPanel.Controls.Add(this.digits8to9FlowLayoutPanel);
            this.topFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topFlowLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.topFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topFlowLayoutPanel.Name = "topFlowLayoutPanel";
            this.topFlowLayoutPanel.Size = new System.Drawing.Size(286, 64);
            this.topFlowLayoutPanel.TabIndex = 0;
            // 
            // digits1to3FlowLayoutPanel
            // 
            this.digits1to3FlowLayoutPanel.AutoSize = true;
            this.digits1to3FlowLayoutPanel.Controls.Add(this.digits1to3Label);
            this.digits1to3FlowLayoutPanel.Controls.Add(this.digits1to3ComboBox);
            this.digits1to3FlowLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.digits1to3FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.digits1to3FlowLayoutPanel.Name = "digits1to3FlowLayoutPanel";
            this.digits1to3FlowLayoutPanel.Size = new System.Drawing.Size(192, 58);
            this.digits1to3FlowLayoutPanel.TabIndex = 4;
            // 
            // digits1to3Label
            // 
            this.digits1to3Label.AutoSize = true;
            this.digits1to3Label.Depth = 0;
            this.digits1to3Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.digits1to3Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.digits1to3Label.Location = new System.Drawing.Point(2, 0);
            this.digits1to3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.digits1to3ComboBox.Location = new System.Drawing.Point(2, 21);
            this.digits1to3ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.digits1to3ComboBox.MaxDropDownItems = 4;
            this.digits1to3ComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.digits1to3ComboBox.Name = "digits1to3ComboBox";
            this.digits1to3ComboBox.Size = new System.Drawing.Size(188, 35);
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
            this.digits4to7FlowLayoutPanel.Location = new System.Drawing.Point(2, 64);
            this.digits4to7FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.digits4to7FlowLayoutPanel.Name = "digits4to7FlowLayoutPanel";
            this.digits4to7FlowLayoutPanel.Size = new System.Drawing.Size(192, 58);
            this.digits4to7FlowLayoutPanel.TabIndex = 5;
            // 
            // digits4to7Label
            // 
            this.digits4to7Label.AutoSize = true;
            this.digits4to7Label.Depth = 0;
            this.digits4to7Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.digits4to7Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.digits4to7Label.Location = new System.Drawing.Point(2, 0);
            this.digits4to7Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.digits4to7ComboBox.Location = new System.Drawing.Point(2, 21);
            this.digits4to7ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.digits4to7ComboBox.MaxDropDownItems = 4;
            this.digits4to7ComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.digits4to7ComboBox.Name = "digits4to7ComboBox";
            this.digits4to7ComboBox.Size = new System.Drawing.Size(188, 35);
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
            this.digits8to9FlowLayoutPanel.Location = new System.Drawing.Point(2, 126);
            this.digits8to9FlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.digits8to9FlowLayoutPanel.Name = "digits8to9FlowLayoutPanel";
            this.digits8to9FlowLayoutPanel.Size = new System.Drawing.Size(192, 58);
            this.digits8to9FlowLayoutPanel.TabIndex = 6;
            // 
            // digits8to9Label
            // 
            this.digits8to9Label.AutoSize = true;
            this.digits8to9Label.Depth = 0;
            this.digits8to9Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.digits8to9Label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.digits8to9Label.Location = new System.Drawing.Point(2, 0);
            this.digits8to9Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.digits8to9ComboBox.Location = new System.Drawing.Point(2, 21);
            this.digits8to9ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.digits8to9ComboBox.MaxDropDownItems = 4;
            this.digits8to9ComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.digits8to9ComboBox.Name = "digits8to9ComboBox";
            this.digits8to9ComboBox.Size = new System.Drawing.Size(188, 35);
            this.digits8to9ComboBox.StartIndex = 0;
            this.digits8to9ComboBox.TabIndex = 3;
            this.digits8to9ComboBox.UseAccent = false;
            this.digits8to9ComboBox.UseTallSize = false;
            // 
            // centerFlowLayoutPanel
            // 
            this.centerFlowLayoutPanel.AutoSize = true;
            this.centerFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centerFlowLayoutPanel.Controls.Add(this.itemDescriptionFlowLayoutPanel);
            this.centerFlowLayoutPanel.Controls.Add(this.itemCodeFlowLayoutPanel);
            this.centerFlowLayoutPanel.Controls.Add(this.flowLayoutPanel1);
            this.centerFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerFlowLayoutPanel.Location = new System.Drawing.Point(2, 70);
            this.centerFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.centerFlowLayoutPanel.Name = "centerFlowLayoutPanel";
            this.centerFlowLayoutPanel.Size = new System.Drawing.Size(286, 134);
            this.centerFlowLayoutPanel.TabIndex = 3;
            // 
            // itemDescriptionFlowLayoutPanel
            // 
            this.itemDescriptionFlowLayoutPanel.AutoSize = true;
            this.itemDescriptionFlowLayoutPanel.Controls.Add(this.itemDescriptionLabel);
            this.itemDescriptionFlowLayoutPanel.Controls.Add(this.itemDescriptionTextBox);
            this.itemDescriptionFlowLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.itemDescriptionFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.itemDescriptionFlowLayoutPanel.Name = "itemDescriptionFlowLayoutPanel";
            this.itemDescriptionFlowLayoutPanel.Size = new System.Drawing.Size(267, 40);
            this.itemDescriptionFlowLayoutPanel.TabIndex = 7;
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Depth = 0;
            this.itemDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemDescriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemDescriptionLabel.Location = new System.Drawing.Point(2, 0);
            this.itemDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemDescriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(71, 40);
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
            this.itemDescriptionTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemDescriptionTextBox.LeadingIcon = null;
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(77, 2);
            this.itemDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemDescriptionTextBox.MaxLength = 1000;
            this.itemDescriptionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.itemDescriptionTextBox.Multiline = false;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(188, 36);
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
            this.itemCodeFlowLayoutPanel.Location = new System.Drawing.Point(2, 46);
            this.itemCodeFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.itemCodeFlowLayoutPanel.Name = "itemCodeFlowLayoutPanel";
            this.itemCodeFlowLayoutPanel.Size = new System.Drawing.Size(247, 40);
            this.itemCodeFlowLayoutPanel.TabIndex = 7;
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.Depth = 0;
            this.itemCodeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemCodeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemCodeLabel.Location = new System.Drawing.Point(2, 0);
            this.itemCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemCodeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(51, 40);
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
            this.itemCodeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.itemCodeTextBox.LeadingIcon = null;
            this.itemCodeTextBox.Location = new System.Drawing.Point(57, 2);
            this.itemCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemCodeTextBox.MaxLength = 1000;
            this.itemCodeTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.itemCodeTextBox.Multiline = false;
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(188, 36);
            this.itemCodeTextBox.TabIndex = 3;
            this.itemCodeTextBox.Text = "";
            this.itemCodeTextBox.TrailingIcon = null;
            this.itemCodeTextBox.UseTallSize = false;
            // 
            // cancelButton
            // 
            this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(57, 22);
            this.cancelButton.Text = "Cancelar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // okButton
            // 
            this.okButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(102, 22);
            this.okButton.Text = "Inserir Novo Item";
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
            this.bottomToolStrip.Location = new System.Drawing.Point(2, 208);
            this.bottomToolStrip.Margin = new System.Windows.Forms.Padding(2);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bottomToolStrip.Size = new System.Drawing.Size(286, 25);
            this.bottomToolStrip.TabIndex = 2;
            this.bottomToolStrip.Text = "toolStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.providerLabel);
            this.flowLayoutPanel1.Controls.Add(this.providerTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 90);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 40);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Depth = 0;
            this.providerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.providerLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.providerLabel.Location = new System.Drawing.Point(2, 0);
            this.providerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.providerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(80, 40);
            this.providerLabel.TabIndex = 2;
            this.providerLabel.Text = "Fornecedor";
            this.providerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // providerTextBox
            // 
            this.providerTextBox.AnimateReadOnly = false;
            this.providerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.providerTextBox.Depth = 0;
            this.providerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.providerTextBox.LeadingIcon = null;
            this.providerTextBox.Location = new System.Drawing.Point(86, 2);
            this.providerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.providerTextBox.MaxLength = 1000;
            this.providerTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.providerTextBox.Multiline = false;
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.Size = new System.Drawing.Size(188, 36);
            this.providerTextBox.TabIndex = 3;
            this.providerTextBox.Text = "";
            this.providerTextBox.TrailingIcon = null;
            this.providerTextBox.UseTallSize = false;
            // 
            // PartsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 289);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PartsManagementForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Gerenciamento de Itens";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
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
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel topFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel digits1to3Label;
        private MaterialSkin.Controls.MaterialComboBox digits1to3ComboBox;
        private MaterialSkin.Controls.MaterialLabel digits4to7Label;
        private MaterialSkin.Controls.MaterialComboBox digits4to7ComboBox;
        private System.Windows.Forms.FlowLayoutPanel digits1to3FlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel digits4to7FlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel digits8to9FlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel digits8to9Label;
        private MaterialSkin.Controls.MaterialComboBox digits8to9ComboBox;
        private System.Windows.Forms.FlowLayoutPanel centerFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel itemCodeFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel itemCodeLabel;
        private System.Windows.Forms.FlowLayoutPanel itemDescriptionFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel itemDescriptionLabel;
        private MaterialSkin.Controls.MaterialTextBox itemCodeTextBox;
        private MaterialSkin.Controls.MaterialTextBox itemDescriptionTextBox;
        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.ToolStripButton cancelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton okButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel providerLabel;
        private MaterialSkin.Controls.MaterialTextBox providerTextBox;
    }
}
namespace MegaDesk_2
{
    partial class AddQuote
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
            this.closeAddQuoteBtn = new System.Windows.Forms.Button();
            this.custFullNameLabel = new System.Windows.Forms.Label();
            this.CustomerFullName = new System.Windows.Forms.TextBox();
            this.labelDeskWidth = new System.Windows.Forms.Label();
            this.labelDeskDepth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SurfaceMaterialType = new System.Windows.Forms.ComboBox();
            this.labelSurfaceType = new System.Windows.Forms.Label();
            this.labelRushOptions = new System.Windows.Forms.Label();
            this.rushOrder = new System.Windows.Forms.CheckBox();
            this.rushDays = new System.Windows.Forms.ComboBox();
            this.labelAddQuote = new System.Windows.Forms.Label();
            this.CalculateQuoteBtn = new System.Windows.Forms.Button();
            this.DeskWidth = new System.Windows.Forms.NumericUpDown();
            this.DeskDepth = new System.Windows.Forms.NumericUpDown();
            this.DrawerCount = new System.Windows.Forms.NumericUpDown();
            this.Dimensions = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerCount)).BeginInit();
            this.Dimensions.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeAddQuoteBtn
            // 
            this.closeAddQuoteBtn.AutoSize = true;
            this.closeAddQuoteBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeAddQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAddQuoteBtn.Location = new System.Drawing.Point(473, 425);
            this.closeAddQuoteBtn.Name = "closeAddQuoteBtn";
            this.closeAddQuoteBtn.Size = new System.Drawing.Size(75, 34);
            this.closeAddQuoteBtn.TabIndex = 10;
            this.closeAddQuoteBtn.Text = "Close";
            this.closeAddQuoteBtn.UseVisualStyleBackColor = true;
            this.closeAddQuoteBtn.Click += new System.EventHandler(this.CloseAddQuoteBtn_Click);
            // 
            // custFullNameLabel
            // 
            this.custFullNameLabel.AutoSize = true;
            this.custFullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custFullNameLabel.Location = new System.Drawing.Point(63, 118);
            this.custFullNameLabel.Name = "custFullNameLabel";
            this.custFullNameLabel.Size = new System.Drawing.Size(153, 20);
            this.custFullNameLabel.TabIndex = 1;
            this.custFullNameLabel.Text = "Customer Full Name";
            // 
            // CustomerFullName
            // 
            this.CustomerFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFullName.Location = new System.Drawing.Point(222, 115);
            this.CustomerFullName.Name = "CustomerFullName";
            this.CustomerFullName.Size = new System.Drawing.Size(170, 26);
            this.CustomerFullName.TabIndex = 1;
            this.CustomerFullName.TextChanged += new System.EventHandler(this.CustomerFullName_TextChanged);
            this.CustomerFullName.Leave += new System.EventHandler(this.CustomerFullName_TextChanged);
            // 
            // labelDeskWidth
            // 
            this.labelDeskWidth.AutoSize = true;
            this.labelDeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeskWidth.Location = new System.Drawing.Point(31, 21);
            this.labelDeskWidth.Name = "labelDeskWidth";
            this.labelDeskWidth.Size = new System.Drawing.Size(162, 20);
            this.labelDeskWidth.TabIndex = 3;
            this.labelDeskWidth.Text = "Desk Width (24\"- 96\")";
            // 
            // labelDeskDepth
            // 
            this.labelDeskDepth.AutoSize = true;
            this.labelDeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeskDepth.Location = new System.Drawing.Point(13, 70);
            this.labelDeskDepth.Name = "labelDeskDepth";
            this.labelDeskDepth.Size = new System.Drawing.Size(180, 20);
            this.labelDeskDepth.TabIndex = 5;
            this.labelDeskDepth.Text = "Depth of desk (12\"- 48\")";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of drawers (0-7)";
            // 
            // SurfaceMaterialType
            // 
            this.SurfaceMaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialType.FormattingEnabled = true;
            this.SurfaceMaterialType.Location = new System.Drawing.Point(223, 304);
            this.SurfaceMaterialType.Name = "SurfaceMaterialType";
            this.SurfaceMaterialType.Size = new System.Drawing.Size(170, 28);
            this.SurfaceMaterialType.TabIndex = 6;

            // 
            // labelSurfaceType
            // 
            this.labelSurfaceType.AutoSize = true;
            this.labelSurfaceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurfaceType.Location = new System.Drawing.Point(91, 307);
            this.labelSurfaceType.Name = "labelSurfaceType";
            this.labelSurfaceType.Size = new System.Drawing.Size(125, 20);
            this.labelSurfaceType.TabIndex = 10;
            this.labelSurfaceType.Text = "Surface material";
            // 
            // labelRushOptions
            // 
            this.labelRushOptions.AutoSize = true;
            this.labelRushOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRushOptions.Location = new System.Drawing.Point(114, 375);
            this.labelRushOptions.Name = "labelRushOptions";
            this.labelRushOptions.Size = new System.Drawing.Size(103, 20);
            this.labelRushOptions.TabIndex = 11;
            this.labelRushOptions.Text = "Rush options";
            // 
            // rushOrder
            // 
            this.rushOrder.AutoSize = true;
            this.rushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrder.Location = new System.Drawing.Point(49, 339);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(116, 24);
            this.rushOrder.TabIndex = 7;
            this.rushOrder.Text = "Rush order?";
            this.rushOrder.UseVisualStyleBackColor = true;
            this.rushOrder.CheckedChanged += new System.EventHandler(this.RushOrder_CheckedChanged);
            // 
            // rushDays
            // 
            this.rushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDays.FormattingEnabled = true;
            this.rushDays.Items.AddRange(new object[] {
            "RUSH - 3 days",
            "RUSH - 5 days",
            "RUSH - 7 days",
            "No rush"});
            this.rushDays.Location = new System.Drawing.Point(223, 372);
            this.rushDays.Name = "rushDays";
            this.rushDays.Size = new System.Drawing.Size(170, 28);
            this.rushDays.TabIndex = 8;
            // 
            // labelAddQuote
            // 
            this.labelAddQuote.AutoSize = true;
            this.labelAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddQuote.Location = new System.Drawing.Point(35, 32);
            this.labelAddQuote.Name = "labelAddQuote";
            this.labelAddQuote.Size = new System.Drawing.Size(438, 36);
            this.labelAddQuote.TabIndex = 14;
            this.labelAddQuote.Text = "Enter information for desk quote";
            // 
            // CalculateQuoteBtn
            // 
            this.CalculateQuoteBtn.AutoSize = true;
            this.CalculateQuoteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculateQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateQuoteBtn.Location = new System.Drawing.Point(214, 425);
            this.CalculateQuoteBtn.Name = "CalculateQuoteBtn";
            this.CalculateQuoteBtn.Size = new System.Drawing.Size(178, 36);
            this.CalculateQuoteBtn.TabIndex = 9;
            this.CalculateQuoteBtn.Text = "Calculate Quote";
            this.CalculateQuoteBtn.UseVisualStyleBackColor = false;
            this.CalculateQuoteBtn.Click += new System.EventHandler(this.CalculateQuoteBtn_Click);
            // 
            // DeskWidth
            // 
            this.DeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(199, 19);
            this.DeskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.DeskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(170, 26);
            this.DeskWidth.TabIndex = 3;
            this.DeskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // DeskDepth
            // 
            this.DeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(199, 68);
            this.DeskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DeskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(170, 26);
            this.DeskDepth.TabIndex = 4;
            this.DeskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // DrawerCount
            // 
            this.DrawerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerCount.Location = new System.Drawing.Point(223, 264);
            this.DrawerCount.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.DrawerCount.Name = "DrawerCount";
            this.DrawerCount.Size = new System.Drawing.Size(170, 26);
            this.DrawerCount.TabIndex = 5;
            // 
            // Dimensions
            // 
            this.Dimensions.Controls.Add(this.DeskDepth);
            this.Dimensions.Controls.Add(this.DeskWidth);
            this.Dimensions.Controls.Add(this.labelDeskDepth);
            this.Dimensions.Controls.Add(this.labelDeskWidth);
            this.Dimensions.Location = new System.Drawing.Point(24, 147);
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.Size = new System.Drawing.Size(396, 111);
            this.Dimensions.TabIndex = 2;
            this.Dimensions.TabStop = false;
            this.Dimensions.Text = "Dimensions";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeAddQuoteBtn;
            this.ClientSize = new System.Drawing.Size(560, 471);
            this.Controls.Add(this.Dimensions);
            this.Controls.Add(this.DrawerCount);
            this.Controls.Add(this.CalculateQuoteBtn);
            this.Controls.Add(this.labelAddQuote);
            this.Controls.Add(this.rushDays);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.labelRushOptions);
            this.Controls.Add(this.labelSurfaceType);
            this.Controls.Add(this.SurfaceMaterialType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerFullName);
            this.Controls.Add(this.custFullNameLabel);
            this.Controls.Add(this.closeAddQuoteBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.DeskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawerCount)).EndInit();
            this.Dimensions.ResumeLayout(false);
            this.Dimensions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button closeAddQuoteBtn;
        private System.Windows.Forms.Label custFullNameLabel;
        private System.Windows.Forms.TextBox CustomerFullName;
        private System.Windows.Forms.Label labelDeskWidth;
        private System.Windows.Forms.Label labelDeskDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SurfaceMaterialType;
        private System.Windows.Forms.Label labelSurfaceType;
        private System.Windows.Forms.Label labelRushOptions;
        private System.Windows.Forms.CheckBox rushOrder;
        private System.Windows.Forms.ComboBox rushDays;
        private System.Windows.Forms.Label labelAddQuote;
        private System.Windows.Forms.Button CalculateQuoteBtn;
        private System.Windows.Forms.NumericUpDown DeskWidth;
        private System.Windows.Forms.NumericUpDown DeskDepth;
        private System.Windows.Forms.NumericUpDown DrawerCount;
        private System.Windows.Forms.GroupBox Dimensions;

        #endregion
        /*
         This form provides the user input interface
         */


    }
}
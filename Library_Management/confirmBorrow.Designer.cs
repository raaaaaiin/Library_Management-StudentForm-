namespace Library_Management
{
    partial class confirmBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmBorrow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.duration = new Bunifu.UI.WinForms.BunifuDropdown();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.datereturn = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dateborrow = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(52, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 237);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 438);
            this.panel2.TabIndex = 102;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-52, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 215);
            this.panel3.TabIndex = 104;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.duration);
            this.panel4.Controls.Add(this.password);
            this.panel4.Controls.Add(this.bunifuButton1);
            this.panel4.Controls.Add(this.Close);
            this.panel4.Controls.Add(this.datereturn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Dateborrow);
            this.panel4.Location = new System.Drawing.Point(36, -5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 218);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel5.Location = new System.Drawing.Point(1, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 1);
            this.panel5.TabIndex = 150;
            // 
            // duration
            // 
            this.duration.AllowDrop = true;
            this.duration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.duration.BorderRadius = 1;
            this.duration.Color = System.Drawing.Color.Gold;
            this.duration.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.duration.DisabledColor = System.Drawing.SystemColors.ControlDarkDark;
            this.duration.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.duration.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.duration.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.duration.FillDropDown = false;
            this.duration.FillIndicator = false;
            this.duration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.duration.ForeColor = System.Drawing.Color.White;
            this.duration.FormattingEnabled = true;
            this.duration.Icon = null;
            this.duration.IndicatorColor = System.Drawing.Color.Gold;
            this.duration.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.duration.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.duration.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.duration.ItemForeColor = System.Drawing.Color.White;
            this.duration.ItemHeight = 18;
            this.duration.ItemHighLightColor = System.Drawing.Color.Gold;
            this.duration.Location = new System.Drawing.Point(120, 82);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(140, 24);
            this.duration.TabIndex = 149;
            this.duration.Text = null;
            this.duration.SelectedIndexChanged += new System.EventHandler(this.duration_SelectedIndexChanged_1);
            // 
            // password
            // 
            this.password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Roboto", 10F);
            this.password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.Gold;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.password.LineThickness = 2;
            this.password.Location = new System.Drawing.Point(22, 36);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(239, 35);
            this.password.TabIndex = 11;
            this.password.Text = "Enter Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.Gray;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Add";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Gray;
            this.bunifuButton1.IdleBorderRadius = 3;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(190, 179);
            this.bunifuButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.Gold;
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Gold;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Goldenrod;
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Goldenrod;
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(71, 27);
            this.bunifuButton1.TabIndex = 4;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // Close
            // 
            this.Close.AllowToggling = false;
            this.Close.AnimationSpeed = 200;
            this.Close.AutoGenerateColors = false;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackColor1 = System.Drawing.Color.Gray;
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Close.ButtonText = "Close";
            this.Close.ButtonTextMarginLeft = 0;
            this.Close.ColorContrastOnClick = 45;
            this.Close.ColorContrastOnHover = 45;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.Close.CustomizableEdges = borderEdges2;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Close.DisabledBorderColor = System.Drawing.Color.Empty;
            this.Close.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Close.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Close.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Close.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Close.IconMarginLeft = 11;
            this.Close.IconPadding = 10;
            this.Close.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Close.IdleBorderColor = System.Drawing.Color.Gray;
            this.Close.IdleBorderRadius = 3;
            this.Close.IdleBorderThickness = 1;
            this.Close.IdleFillColor = System.Drawing.Color.Gray;
            this.Close.IdleIconLeftImage = null;
            this.Close.IdleIconRightImage = null;
            this.Close.IndicateFocus = false;
            this.Close.Location = new System.Drawing.Point(120, 179);
            this.Close.Margin = new System.Windows.Forms.Padding(2);
            this.Close.Name = "Close";
            stateProperties3.BorderColor = System.Drawing.Color.Gold;
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.Gold;
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.Close.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Goldenrod;
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.Goldenrod;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.Close.OnPressedState = stateProperties4;
            this.Close.Size = new System.Drawing.Size(66, 27);
            this.Close.TabIndex = 10;
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.TextMarginLeft = 0;
            this.Close.UseDefaultRadiusAndThickness = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // datereturn
            // 
            this.datereturn.AllowDrop = true;
            this.datereturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.datereturn.BorderRadius = 1;
            this.datereturn.Color = System.Drawing.Color.Gray;
            this.datereturn.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.datereturn.DisabledColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datereturn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.datereturn.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.datereturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.datereturn.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.datereturn.DropDownWidth = 180;
            this.datereturn.FillDropDown = false;
            this.datereturn.FillIndicator = false;
            this.datereturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datereturn.ForeColor = System.Drawing.Color.White;
            this.datereturn.FormattingEnabled = true;
            this.datereturn.Icon = null;
            this.datereturn.IndicatorColor = System.Drawing.Color.Gold;
            this.datereturn.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.datereturn.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.datereturn.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.datereturn.ItemForeColor = System.Drawing.Color.White;
            this.datereturn.ItemHeight = 24;
            this.datereturn.ItemHighLightColor = System.Drawing.Color.Gold;
            this.datereturn.Location = new System.Drawing.Point(120, 145);
            this.datereturn.Margin = new System.Windows.Forms.Padding(2);
            this.datereturn.Name = "datereturn";
            this.datereturn.Size = new System.Drawing.Size(141, 30);
            this.datereturn.TabIndex = 9;
            this.datereturn.Text = null;
            this.datereturn.SelectedIndexChanged += new System.EventHandler(this.datereturn_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(18, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Borrowed";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(43, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Until When";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Dateborrow
            // 
            this.Dateborrow.AllowDrop = true;
            this.Dateborrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Dateborrow.BorderRadius = 1;
            this.Dateborrow.Color = System.Drawing.Color.Gray;
            this.Dateborrow.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.Dateborrow.DisabledColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dateborrow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dateborrow.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.Dateborrow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dateborrow.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Dateborrow.DropDownWidth = 180;
            this.Dateborrow.FillDropDown = false;
            this.Dateborrow.FillIndicator = false;
            this.Dateborrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dateborrow.ForeColor = System.Drawing.Color.White;
            this.Dateborrow.FormattingEnabled = true;
            this.Dateborrow.Icon = null;
            this.Dateborrow.IndicatorColor = System.Drawing.Color.Gold;
            this.Dateborrow.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Dateborrow.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Dateborrow.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Dateborrow.ItemForeColor = System.Drawing.Color.White;
            this.Dateborrow.ItemHeight = 24;
            this.Dateborrow.ItemHighLightColor = System.Drawing.Color.Gold;
            this.Dateborrow.Location = new System.Drawing.Point(120, 111);
            this.Dateborrow.Margin = new System.Windows.Forms.Padding(2);
            this.Dateborrow.Name = "Dateborrow";
            this.Dateborrow.Size = new System.Drawing.Size(141, 30);
            this.Dateborrow.TabIndex = 8;
            this.Dateborrow.Text = null;
            this.Dateborrow.SelectedIndexChanged += new System.EventHandler(this.Dateborrow_SelectedIndexChanged);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel16.Location = new System.Drawing.Point(6, 10);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(515, 438);
            this.panel16.TabIndex = 103;
            // 
            // confirmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(277, 237);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "confirmBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmBorrow";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Close;
        private Bunifu.UI.WinForms.BunifuDropdown datereturn;
        private Bunifu.UI.WinForms.BunifuDropdown Dateborrow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel16;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.UI.WinForms.BunifuDropdown duration;
    }
}
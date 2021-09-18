namespace Library_Management
{
    partial class showBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showBooks));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Next = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 24);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(764, 714);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // search
            // 
            this.search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.search.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.search.HintForeColor = System.Drawing.Color.Empty;
            this.search.HintText = "";
            this.search.isPassword = false;
            this.search.LineFocusedColor = System.Drawing.Color.Gold;
            this.search.LineIdleColor = System.Drawing.Color.Gray;
            this.search.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.search.LineThickness = 3;
            this.search.Location = new System.Drawing.Point(149, -1);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.MaxLength = 32767;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(134, 23);
            this.search.TabIndex = 6;
            this.search.Text = "Search Bar";
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // Next
            // 
            this.Next.AllowToggling = false;
            this.Next.AnimationSpeed = 200;
            this.Next.AutoGenerateColors = false;
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Next.BackgroundImage")));
            this.Next.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Next.ButtonText = "Previous";
            this.Next.ButtonTextMarginLeft = 0;
            this.Next.ColorContrastOnClick = 45;
            this.Next.ColorContrastOnHover = 45;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.Next.CustomizableEdges = borderEdges5;
            this.Next.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Next.DisabledBorderColor = System.Drawing.Color.Empty;
            this.Next.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Next.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Next.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Next.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.Next.IconMarginLeft = 11;
            this.Next.IconPadding = 10;
            this.Next.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Next.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Next.IdleBorderRadius = 3;
            this.Next.IdleBorderThickness = 1;
            this.Next.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Next.IdleIconLeftImage = null;
            this.Next.IdleIconRightImage = null;
            this.Next.IndicateFocus = false;
            this.Next.Location = new System.Drawing.Point(0, 6);
            this.Next.Margin = new System.Windows.Forms.Padding(2);
            this.Next.Name = "Next";
            stateProperties9.BorderColor = System.Drawing.Color.Gold;
            stateProperties9.BorderRadius = 3;
            stateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.Gold;
            stateProperties9.ForeColor = System.Drawing.Color.White;
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this.Next.onHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Goldenrod;
            stateProperties10.BorderRadius = 3;
            stateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties10.BorderThickness = 1;
            stateProperties10.FillColor = System.Drawing.Color.Goldenrod;
            stateProperties10.ForeColor = System.Drawing.Color.White;
            stateProperties10.IconLeftImage = null;
            stateProperties10.IconRightImage = null;
            this.Next.OnPressedState = stateProperties10;
            this.Next.Size = new System.Drawing.Size(68, 18);
            this.Next.TabIndex = 4;
            this.Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Next.TextMarginLeft = 0;
            this.Next.UseDefaultRadiusAndThickness = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Next";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges6;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bunifuButton2.IdleBorderRadius = 3;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(75, 6);
            this.bunifuButton2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties11.BorderColor = System.Drawing.Color.Gold;
            stateProperties11.BorderRadius = 3;
            stateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties11.BorderThickness = 1;
            stateProperties11.FillColor = System.Drawing.Color.Gold;
            stateProperties11.ForeColor = System.Drawing.Color.White;
            stateProperties11.IconLeftImage = null;
            stateProperties11.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Goldenrod;
            stateProperties12.BorderRadius = 3;
            stateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties12.BorderThickness = 1;
            stateProperties12.FillColor = System.Drawing.Color.Goldenrod;
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.IconLeftImage = null;
            stateProperties12.IconRightImage = null;
            this.bunifuButton2.OnPressedState = stateProperties12;
            this.bunifuButton2.Size = new System.Drawing.Size(68, 18);
            this.bunifuButton2.TabIndex = 8;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // showBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(858, 753);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "showBooks";
            this.Text = "ShowBooks";
            this.Load += new System.EventHandler(this.showBooks_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Next;
        private Bunifu.Framework.UI.BunifuMaterialTextbox search;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
    }
}
namespace SortWFv5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2PictureBoxVisualization = new Guna.UI2.WinForms.Guna2PictureBox();
            panel1 = new Panel();
            iconPictureBoxSortIcon = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            iconButtonClose = new FontAwesome.Sharp.IconButton();
            guna2ComboBoxSort = new Guna.UI2.WinForms.Guna2ComboBox();
            ButtonShuffle = new Guna.UI2.WinForms.Guna2Button();
            ButtonSort = new Guna.UI2.WinForms.Guna2Button();
            timer1 = new System.Windows.Forms.Timer(components);
            labelSortDesc = new Label();
            ButtonStop = new Guna.UI2.WinForms.Guna2Button();
            guna2ComboBoxF = new Guna.UI2.WinForms.Guna2ComboBox();
            timer2 = new System.Windows.Forms.Timer(components);
            labelTime = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBoxVisualization).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxSortIcon).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2PictureBoxVisualization
            // 
            guna2PictureBoxVisualization.BorderRadius = 20;
            guna2PictureBoxVisualization.CustomizableEdges = customizableEdges13;
            guna2PictureBoxVisualization.FillColor = SystemColors.ControlLight;
            guna2PictureBoxVisualization.ImageRotate = 0F;
            guna2PictureBoxVisualization.Location = new Point(336, 93);
            guna2PictureBoxVisualization.Name = "guna2PictureBoxVisualization";
            guna2PictureBoxVisualization.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2PictureBoxVisualization.Size = new Size(850, 530);
            guna2PictureBoxVisualization.TabIndex = 0;
            guna2PictureBoxVisualization.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(iconPictureBoxSortIcon);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconButtonMinimize);
            panel1.Controls.Add(iconButtonClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 42);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // iconPictureBoxSortIcon
            // 
            iconPictureBoxSortIcon.BackColor = SystemColors.ControlLight;
            iconPictureBoxSortIcon.ForeColor = SystemColors.ControlText;
            iconPictureBoxSortIcon.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            iconPictureBoxSortIcon.IconColor = SystemColors.ControlText;
            iconPictureBoxSortIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBoxSortIcon.IconSize = 40;
            iconPictureBoxSortIcon.Location = new Point(9, 5);
            iconPictureBoxSortIcon.Name = "iconPictureBoxSortIcon";
            iconPictureBoxSortIcon.Size = new Size(40, 40);
            iconPictureBoxSortIcon.TabIndex = 8;
            iconPictureBoxSortIcon.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(55, 9);
            label2.Name = "label2";
            label2.Size = new Size(354, 28);
            label2.TabIndex = 4;
            label2.Text = "Visualization of sorting algorithms";
            // 
            // iconButtonMinimize
            // 
            iconButtonMinimize.FlatAppearance.BorderSize = 0;
            iconButtonMinimize.FlatStyle = FlatStyle.Flat;
            iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButtonMinimize.IconColor = SystemColors.ControlText;
            iconButtonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMinimize.IconSize = 40;
            iconButtonMinimize.Location = new Point(1098, -2);
            iconButtonMinimize.Name = "iconButtonMinimize";
            iconButtonMinimize.Size = new Size(50, 50);
            iconButtonMinimize.TabIndex = 3;
            iconButtonMinimize.UseVisualStyleBackColor = true;
            iconButtonMinimize.Click += iconButtonMinimize_Click;
            // 
            // iconButtonClose
            // 
            iconButtonClose.FlatAppearance.BorderSize = 0;
            iconButtonClose.FlatStyle = FlatStyle.Flat;
            iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButtonClose.IconColor = SystemColors.ControlText;
            iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonClose.IconSize = 40;
            iconButtonClose.Location = new Point(1148, -2);
            iconButtonClose.Name = "iconButtonClose";
            iconButtonClose.Size = new Size(50, 50);
            iconButtonClose.TabIndex = 2;
            iconButtonClose.UseVisualStyleBackColor = true;
            iconButtonClose.Click += iconButtonClose_Click;
            // 
            // guna2ComboBoxSort
            // 
            guna2ComboBoxSort.BackColor = Color.Transparent;
            guna2ComboBoxSort.BorderRadius = 10;
            guna2ComboBoxSort.BorderThickness = 0;
            guna2ComboBoxSort.CustomizableEdges = customizableEdges15;
            guna2ComboBoxSort.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBoxSort.FillColor = SystemColors.ControlLight;
            guna2ComboBoxSort.FocusedColor = SystemColors.ControlLight;
            guna2ComboBoxSort.FocusedState.BorderColor = SystemColors.ControlLight;
            guna2ComboBoxSort.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guna2ComboBoxSort.ForeColor = SystemColors.ControlText;
            guna2ComboBoxSort.ItemHeight = 30;
            guna2ComboBoxSort.Items.AddRange(new object[] { "Bubble", "Insertion", "Selection", "Merge", "Patience", "CockTailShaker", "DoubleSelection" });
            guna2ComboBoxSort.Location = new Point(9, 51);
            guna2ComboBoxSort.Name = "guna2ComboBoxSort";
            guna2ComboBoxSort.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2ComboBoxSort.Size = new Size(321, 36);
            guna2ComboBoxSort.StartIndex = 0;
            guna2ComboBoxSort.TabIndex = 2;
            guna2ComboBoxSort.SelectedIndexChanged += guna2ComboBoxSort_SelectedIndexChanged;
            // 
            // ButtonShuffle
            // 
            ButtonShuffle.BorderRadius = 10;
            ButtonShuffle.CustomizableEdges = customizableEdges17;
            ButtonShuffle.DisabledState.BorderColor = Color.DarkGray;
            ButtonShuffle.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonShuffle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonShuffle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonShuffle.FillColor = SystemColors.ControlLight;
            ButtonShuffle.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonShuffle.ForeColor = Color.Black;
            ButtonShuffle.Location = new Point(9, 517);
            ButtonShuffle.Name = "ButtonShuffle";
            ButtonShuffle.ShadowDecoration.CustomizableEdges = customizableEdges18;
            ButtonShuffle.Size = new Size(321, 50);
            ButtonShuffle.TabIndex = 4;
            ButtonShuffle.Text = "Shuffle";
            ButtonShuffle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ButtonShuffle.Click += ButtonShuffle_Click;
            // 
            // ButtonSort
            // 
            ButtonSort.BorderRadius = 10;
            ButtonSort.CustomizableEdges = customizableEdges19;
            ButtonSort.DisabledState.BorderColor = Color.DarkGray;
            ButtonSort.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonSort.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonSort.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonSort.FillColor = SystemColors.ControlLight;
            ButtonSort.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonSort.ForeColor = Color.Black;
            ButtonSort.Location = new Point(9, 573);
            ButtonSort.Name = "ButtonSort";
            ButtonSort.ShadowDecoration.CustomizableEdges = customizableEdges20;
            ButtonSort.Size = new Size(321, 50);
            ButtonSort.TabIndex = 5;
            ButtonSort.Text = "Sort";
            ButtonSort.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ButtonSort.Click += ButtonSort_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // labelSortDesc
            // 
            labelSortDesc.AutoEllipsis = true;
            labelSortDesc.Font = new Font("Constantia", 13.8F);
            labelSortDesc.Location = new Point(9, 90);
            labelSortDesc.MaximumSize = new Size(321, 0);
            labelSortDesc.Name = "labelSortDesc";
            labelSortDesc.Size = new Size(321, 421);
            labelSortDesc.TabIndex = 9;
            labelSortDesc.Text = "Sort description: ";
            // 
            // ButtonStop
            // 
            ButtonStop.BorderRadius = 10;
            ButtonStop.CustomizableEdges = customizableEdges21;
            ButtonStop.DisabledState.BorderColor = Color.DarkGray;
            ButtonStop.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonStop.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonStop.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonStop.FillColor = SystemColors.ControlLight;
            ButtonStop.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonStop.ForeColor = Color.Black;
            ButtonStop.Location = new Point(9, 573);
            ButtonStop.Name = "ButtonStop";
            ButtonStop.ShadowDecoration.CustomizableEdges = customizableEdges22;
            ButtonStop.Size = new Size(321, 50);
            ButtonStop.TabIndex = 10;
            ButtonStop.Text = "Stop";
            ButtonStop.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ButtonStop.Visible = false;
            ButtonStop.Click += ButtonStop_Click;
            // 
            // guna2ComboBoxF
            // 
            guna2ComboBoxF.BackColor = Color.Transparent;
            guna2ComboBoxF.BorderRadius = 10;
            guna2ComboBoxF.BorderThickness = 0;
            guna2ComboBoxF.CustomizableEdges = customizableEdges23;
            guna2ComboBoxF.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBoxF.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBoxF.FillColor = SystemColors.ControlLight;
            guna2ComboBoxF.FocusedColor = SystemColors.ControlLight;
            guna2ComboBoxF.FocusedState.BorderColor = SystemColors.ControlLight;
            guna2ComboBoxF.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guna2ComboBoxF.ForeColor = SystemColors.ControlText;
            guna2ComboBoxF.ItemHeight = 30;
            guna2ComboBoxF.Items.AddRange(new object[] { "Linear", "Logarithm", "Exponential", "Logistic", "Random" });
            guna2ComboBoxF.Location = new Point(336, 51);
            guna2ComboBoxF.Name = "guna2ComboBoxF";
            guna2ComboBoxF.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2ComboBoxF.Size = new Size(321, 36);
            guna2ComboBoxF.StartIndex = 0;
            guna2ComboBoxF.TabIndex = 11;
            guna2ComboBoxF.SelectedIndexChanged += guna2ComboBoxF_SelectedIndexChanged;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTime.Location = new Point(663, 51);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(91, 35);
            labelTime.TabIndex = 12;
            labelTime.Text = "Time: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 637);
            Controls.Add(labelTime);
            Controls.Add(guna2ComboBoxF);
            Controls.Add(ButtonStop);
            Controls.Add(labelSortDesc);
            Controls.Add(ButtonSort);
            Controls.Add(ButtonShuffle);
            Controls.Add(guna2ComboBoxSort);
            Controls.Add(panel1);
            Controls.Add(guna2PictureBoxVisualization);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBoxVisualization).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxSortIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSortIcon;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxSort;
        private Guna.UI2.WinForms.Guna2Button ButtonShuffle;
        private Guna.UI2.WinForms.Guna2Button ButtonSort;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBoxVisualization;
        private Guna.UI2.WinForms.Guna2Button ButtonStop;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxF;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label2;
        private Label labelSortDesc;
        private Label labelTime;
    }
}

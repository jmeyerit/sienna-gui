/******************************************************************************************************************************
 * Assignment Final Project                                                                          fStateProvince.Designer.cs
 * Justin Meyer
 * IT3045C-001 Fall Semester
 * meyer3js@mail.uc.edu
 * This Final Project asks us to simulate some of the functions provided by the Sat Nav in Professor 
 * Nicholson's Toyota Siena. NO MAPS!
 * This partial class contains the automagically generated code from the Visual Studio Form Designer
 * Due Date: Tuesday, December 6th, 2016 by 4pm
 * Citations: Program coded by Justin Meyer using Visual Studio Community 2015
 * 
 * 
 * 
 * REFERENCES: 
 * 
 * http://www.free-icons-download.net/images/back-button-icon-72762.png - For the back button used
 * https://www.google.com/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=color%20picker - Color picker
 * useful in picking a color for the forms.
 * http://www.fluxbytes.com/csharp/set-placeholder-text-for-textbox-cue-text/ - For simulating placeholder
 * text for the textboxes.
 * http://www.csi.cuny.edu/administration/ops/2letterstabbrev.pdf - States and their abbreviations
 * http://stackoverflow.com/questions/1665533/communicate-between-two-windows-forms-in-c-sharp - How to make
 * forms talk to each other with events.
 * http://stackoverflow.com/questions/1249394/how-to-select-a-dropdown-list-item-by-value-programatically - Helped
 * with some logic in order to process the Selected items in the fStateProvince class
 * http://stackoverflow.com/questions/1774498/how-to-iterate-through-a-datatable/1774515 - Iterating through
 * a Datatable
 * https://social.msdn.microsoft.com/Forums/en-US/e57e67d2-80d9-4ed6-9e88-ccbec9e2fbf8/how-to-delete-one-character-from-textbox-backspace?forum=Vsexpressvcs - Code to enable backspace functionality.
 * https://msdn.microsoft.com/en-us/library/ms171905.aspx - Creating a paramaterized query
 * http://stackoverflow.com/questions/1568615/how-do-you-access-a-control-in-a-collection-by-its-type - How to determine a 
 * control's type.
 * http://stackoverflow.com/questions/2916583/how-to-get-a-specific-column-value-from-a-datatable - Helped with
 * getting data from a specific column in a DataTable.
 * 
 * REMEMBER TO TURN AUTOSCALING OFF
 * 
 * 
 * ALWAYS think of the cat
 * ******************************************************************************************************************************/

namespace meyer3js_FinalProject {
    partial class fStateProvince {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnUnitesStates = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbState = new System.Windows.Forms.ListBox();
            this.tStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meyer3jsDBConnectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meyer3jsDBConnection = new meyer3js_FinalProject.meyer3jsDBConnection();
            this.tStateTableAdapter = new meyer3js_FinalProject.meyer3jsDBConnectionTableAdapters.tStateTableAdapter();
            this.btnABC = new System.Windows.Forms.Button();
            this.btnDEF = new System.Windows.Forms.Button();
            this.btnGHI = new System.Windows.Forms.Button();
            this.btnJKL = new System.Windows.Forms.Button();
            this.btnMNO = new System.Windows.Forms.Button();
            this.btnPQRS = new System.Windows.Forms.Button();
            this.btnTUV = new System.Windows.Forms.Button();
            this.btnWXYZ = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.tStatesSelectedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tStatesSelectedTableAdapter = new meyer3js_FinalProject.meyer3jsDBConnectionTableAdapters.tStatesSelectedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meyer3jsDBConnectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meyer3jsDBConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStatesSelectedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScreen
            // 
            this.lblScreen.Size = new System.Drawing.Size(113, 18);
            this.lblScreen.Text = "State/Province";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            // 
            // btnUnitesStates
            // 
            this.btnUnitesStates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.btnUnitesStates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnitesStates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnUnitesStates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnUnitesStates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnUnitesStates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitesStates.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnitesStates.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUnitesStates.Location = new System.Drawing.Point(15, 46);
            this.btnUnitesStates.Name = "btnUnitesStates";
            this.btnUnitesStates.Size = new System.Drawing.Size(155, 23);
            this.btnUnitesStates.TabIndex = 64;
            this.btnUnitesStates.Text = "United States";
            this.btnUnitesStates.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(176, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Canada";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(337, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 66;
            this.button2.Text = "Mexico";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbState
            // 
            this.lbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.lbState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbState.DataSource = this.tStateBindingSource;
            this.lbState.DisplayMember = "State";
            this.lbState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbState.FormattingEnabled = true;
            this.lbState.ItemHeight = 15;
            this.lbState.Location = new System.Drawing.Point(12, 87);
            this.lbState.Name = "lbState";
            this.lbState.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbState.Size = new System.Drawing.Size(294, 152);
            this.lbState.TabIndex = 67;
            this.lbState.ValueMember = "State";
            this.lbState.Click += new System.EventHandler(this.lbState_Click);
            // 
            // tStateBindingSource
            // 
            this.tStateBindingSource.DataMember = "tState";
            this.tStateBindingSource.DataSource = this.meyer3jsDBConnectionBindingSource;
            // 
            // meyer3jsDBConnectionBindingSource
            // 
            this.meyer3jsDBConnectionBindingSource.DataSource = this.meyer3jsDBConnection;
            this.meyer3jsDBConnectionBindingSource.Position = 0;
            // 
            // meyer3jsDBConnection
            // 
            this.meyer3jsDBConnection.DataSetName = "meyer3jsDBConnection";
            this.meyer3jsDBConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tStateTableAdapter
            // 
            this.tStateTableAdapter.ClearBeforeFill = true;
            // 
            // btnABC
            // 
            this.btnABC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.btnABC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnABC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnABC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnABC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnABC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABC.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnABC.Location = new System.Drawing.Point(314, 93);
            this.btnABC.Name = "btnABC";
            this.btnABC.Size = new System.Drawing.Size(91, 23);
            this.btnABC.TabIndex = 69;
            this.btnABC.Text = "ABC";
            this.btnABC.UseVisualStyleBackColor = false;
            this.btnABC.Click += new System.EventHandler(this.btnABC_Click);
            // 
            // btnDEF
            // 
            this.btnDEF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.btnDEF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDEF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnDEF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnDEF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnDEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDEF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEF.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDEF.Location = new System.Drawing.Point(411, 93);
            this.btnDEF.Name = "btnDEF";
            this.btnDEF.Size = new System.Drawing.Size(91, 23);
            this.btnDEF.TabIndex = 70;
            this.btnDEF.Text = "DEF";
            this.btnDEF.UseVisualStyleBackColor = false;
            this.btnDEF.Click += new System.EventHandler(this.btnDEF_Click);
            // 
            // btnGHI
            // 
            this.btnGHI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.btnGHI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGHI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnGHI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnGHI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnGHI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGHI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGHI.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGHI.Location = new System.Drawing.Point(314, 122);
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(91, 23);
            this.btnGHI.TabIndex = 71;
            this.btnGHI.Text = "GHI";
            this.btnGHI.UseVisualStyleBackColor = false;
            this.btnGHI.Click += new System.EventHandler(this.btnGHI_Click);
            // 
            // btnJKL
            // 
            this.btnJKL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.btnJKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJKL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnJKL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnJKL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnJKL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJKL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJKL.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnJKL.Location = new System.Drawing.Point(411, 122);
            this.btnJKL.Name = "btnJKL";
            this.btnJKL.Size = new System.Drawing.Size(91, 23);
            this.btnJKL.TabIndex = 72;
            this.btnJKL.Text = "JKL";
            this.btnJKL.UseVisualStyleBackColor = false;
            this.btnJKL.Click += new System.EventHandler(this.btnJKL_Click);
            // 
            // btnMNO
            // 
            this.btnMNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.btnMNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMNO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnMNO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnMNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnMNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMNO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMNO.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMNO.Location = new System.Drawing.Point(314, 151);
            this.btnMNO.Name = "btnMNO";
            this.btnMNO.Size = new System.Drawing.Size(91, 23);
            this.btnMNO.TabIndex = 73;
            this.btnMNO.Text = "MNO";
            this.btnMNO.UseVisualStyleBackColor = false;
            this.btnMNO.Click += new System.EventHandler(this.btnMNO_Click);
            // 
            // btnPQRS
            // 
            this.btnPQRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.btnPQRS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPQRS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnPQRS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnPQRS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnPQRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPQRS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPQRS.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPQRS.Location = new System.Drawing.Point(411, 151);
            this.btnPQRS.Name = "btnPQRS";
            this.btnPQRS.Size = new System.Drawing.Size(91, 23);
            this.btnPQRS.TabIndex = 74;
            this.btnPQRS.Text = "PQRS";
            this.btnPQRS.UseVisualStyleBackColor = false;
            this.btnPQRS.Click += new System.EventHandler(this.btnPQRS_Click);
            // 
            // btnTUV
            // 
            this.btnTUV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.btnTUV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTUV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnTUV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnTUV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnTUV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTUV.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTUV.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTUV.Location = new System.Drawing.Point(314, 180);
            this.btnTUV.Name = "btnTUV";
            this.btnTUV.Size = new System.Drawing.Size(91, 23);
            this.btnTUV.TabIndex = 75;
            this.btnTUV.Text = "TUV";
            this.btnTUV.UseVisualStyleBackColor = false;
            this.btnTUV.Click += new System.EventHandler(this.btnTUV_Click);
            // 
            // btnWXYZ
            // 
            this.btnWXYZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(30)))), ((int)(((byte)(56)))));
            this.btnWXYZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWXYZ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnWXYZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnWXYZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnWXYZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWXYZ.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWXYZ.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnWXYZ.Location = new System.Drawing.Point(411, 180);
            this.btnWXYZ.Name = "btnWXYZ";
            this.btnWXYZ.Size = new System.Drawing.Size(91, 23);
            this.btnWXYZ.TabIndex = 76;
            this.btnWXYZ.Text = "WXYZ";
            this.btnWXYZ.UseVisualStyleBackColor = false;
            this.btnWXYZ.Click += new System.EventHandler(this.btnWXYZ_Click);
            // 
            // btnNum
            // 
            this.btnNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnNum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnNum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNum.Location = new System.Drawing.Point(314, 209);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(91, 23);
            this.btnNum.TabIndex = 77;
            this.btnNum.Text = "0-9";
            this.btnNum.UseVisualStyleBackColor = false;
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOther.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnOther.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnOther.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOther.Location = new System.Drawing.Point(411, 209);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(91, 23);
            this.btnOther.TabIndex = 78;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = false;
            // 
            // tStatesSelectedBindingSource
            // 
            this.tStatesSelectedBindingSource.DataMember = "tStatesSelected";
            this.tStatesSelectedBindingSource.DataSource = this.meyer3jsDBConnectionBindingSource;
            // 
            // tStatesSelectedTableAdapter
            // 
            this.tStatesSelectedTableAdapter.ClearBeforeFill = true;
            // 
            // fStateProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(522, 262);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.btnWXYZ);
            this.Controls.Add(this.btnTUV);
            this.Controls.Add(this.btnPQRS);
            this.Controls.Add(this.btnMNO);
            this.Controls.Add(this.btnJKL);
            this.Controls.Add(this.btnGHI);
            this.Controls.Add(this.btnDEF);
            this.Controls.Add(this.btnABC);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUnitesStates);
            this.Name = "fStateProvince";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.fStateProvince_Load);
            this.Controls.SetChildIndex(this.btnUnitesStates, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.lbState, 0);
            this.Controls.SetChildIndex(this.btnABC, 0);
            this.Controls.SetChildIndex(this.btnDEF, 0);
            this.Controls.SetChildIndex(this.btnGHI, 0);
            this.Controls.SetChildIndex(this.btnJKL, 0);
            this.Controls.SetChildIndex(this.btnMNO, 0);
            this.Controls.SetChildIndex(this.btnPQRS, 0);
            this.Controls.SetChildIndex(this.btnTUV, 0);
            this.Controls.SetChildIndex(this.btnWXYZ, 0);
            this.Controls.SetChildIndex(this.btnNum, 0);
            this.Controls.SetChildIndex(this.btnOther, 0);
            this.Controls.SetChildIndex(this.lblScreen, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meyer3jsDBConnectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meyer3jsDBConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStatesSelectedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnitesStates;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource meyer3jsDBConnectionBindingSource;
        private meyer3jsDBConnection meyer3jsDBConnection;
        private System.Windows.Forms.ListBox lbState;
        private meyer3jsDBConnectionTableAdapters.tStateTableAdapter tStateTableAdapter;
        private System.Windows.Forms.BindingSource tStateBindingSource;
        private System.Windows.Forms.Button btnABC;
        private System.Windows.Forms.Button btnDEF;
        private System.Windows.Forms.Button btnGHI;
        private System.Windows.Forms.Button btnJKL;
        private System.Windows.Forms.Button btnMNO;
        private System.Windows.Forms.Button btnPQRS;
        private System.Windows.Forms.Button btnTUV;
        private System.Windows.Forms.Button btnWXYZ;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.BindingSource tStatesSelectedBindingSource;
        private meyer3jsDBConnectionTableAdapters.tStatesSelectedTableAdapter tStatesSelectedTableAdapter;
    }
}

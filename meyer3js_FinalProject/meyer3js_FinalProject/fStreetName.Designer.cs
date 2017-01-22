/******************************************************************************************************************************
 * Assignment Final Project                                                                             fStreetName.Designer.cs
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
    partial class fStreetName {
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnForwardSlash = new System.Windows.Forms.Button();
            this.btnApostrophe = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnAmpersand = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.tbMatch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.meyer3jsDBConnection = new meyer3js_FinalProject.meyer3jsDBConnection();
            this.tAddressTableAdapter = new meyer3js_FinalProject.meyer3jsDBConnectionTableAdapters.tAddressTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.meyer3jsDBConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScreen
            // 
            this.lblScreen.Size = new System.Drawing.Size(96, 18);
            this.lblScreen.Text = "Street Name";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClear.Location = new System.Drawing.Point(43, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 23);
            this.btnClear.TabIndex = 114;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOK.Location = new System.Drawing.Point(391, 219);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(66, 23);
            this.btnOK.TabIndex = 113;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSpace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpace.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSpace.Location = new System.Drawing.Point(211, 219);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(174, 23);
            this.btnSpace.TabIndex = 112;
            this.btnSpace.Text = "Space";
            this.btnSpace.UseVisualStyleBackColor = false;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.button44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button44.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.button44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button44.Location = new System.Drawing.Point(119, 219);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(86, 23);
            this.button44.TabIndex = 111;
            this.button44.Text = "Other";
            this.button44.UseVisualStyleBackColor = false;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnX.Location = new System.Drawing.Point(139, 181);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(30, 30);
            this.btnX.TabIndex = 110;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnC.Location = new System.Drawing.Point(175, 181);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(30, 30);
            this.btnC.TabIndex = 109;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnV.Location = new System.Drawing.Point(211, 181);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(30, 30);
            this.btnV.TabIndex = 108;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnB.Location = new System.Drawing.Point(247, 181);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(30, 30);
            this.btnB.TabIndex = 107;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnN.Location = new System.Drawing.Point(283, 181);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(30, 30);
            this.btnN.TabIndex = 106;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnM.Location = new System.Drawing.Point(319, 181);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(30, 30);
            this.btnM.TabIndex = 105;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            // 
            // btnForwardSlash
            // 
            this.btnForwardSlash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnForwardSlash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnForwardSlash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnForwardSlash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnForwardSlash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnForwardSlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForwardSlash.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForwardSlash.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnForwardSlash.Location = new System.Drawing.Point(355, 181);
            this.btnForwardSlash.Name = "btnForwardSlash";
            this.btnForwardSlash.Size = new System.Drawing.Size(30, 30);
            this.btnForwardSlash.TabIndex = 104;
            this.btnForwardSlash.Text = "/";
            this.btnForwardSlash.UseVisualStyleBackColor = false;
            // 
            // btnApostrophe
            // 
            this.btnApostrophe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnApostrophe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnApostrophe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnApostrophe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnApostrophe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnApostrophe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApostrophe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostrophe.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnApostrophe.Location = new System.Drawing.Point(391, 181);
            this.btnApostrophe.Name = "btnApostrophe";
            this.btnApostrophe.Size = new System.Drawing.Size(30, 30);
            this.btnApostrophe.TabIndex = 103;
            this.btnApostrophe.Text = "\'";
            this.btnApostrophe.UseVisualStyleBackColor = false;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnDash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnDash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDash.Location = new System.Drawing.Point(427, 181);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(30, 30);
            this.btnDash.TabIndex = 102;
            this.btnDash.Text = "-";
            this.btnDash.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnS.Location = new System.Drawing.Point(119, 145);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(30, 30);
            this.btnS.TabIndex = 101;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnD.Location = new System.Drawing.Point(155, 145);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(30, 30);
            this.btnD.TabIndex = 100;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btnAmpersand
            // 
            this.btnAmpersand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnAmpersand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAmpersand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnAmpersand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnAmpersand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnAmpersand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmpersand.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmpersand.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAmpersand.Location = new System.Drawing.Point(407, 145);
            this.btnAmpersand.Name = "btnAmpersand";
            this.btnAmpersand.Size = new System.Drawing.Size(30, 30);
            this.btnAmpersand.TabIndex = 99;
            this.btnAmpersand.Text = "&&";
            this.btnAmpersand.UseVisualStyleBackColor = false;
            this.btnAmpersand.Click += new System.EventHandler(this.btnAmpersand_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnK.Location = new System.Drawing.Point(335, 145);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(30, 30);
            this.btnK.TabIndex = 98;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnL.Location = new System.Drawing.Point(371, 145);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(30, 30);
            this.btnL.TabIndex = 97;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnH.Location = new System.Drawing.Point(263, 145);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(30, 30);
            this.btnH.TabIndex = 96;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJ.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnJ.Location = new System.Drawing.Point(299, 145);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(30, 30);
            this.btnJ.TabIndex = 95;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnF.Location = new System.Drawing.Point(191, 145);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(30, 30);
            this.btnF.TabIndex = 94;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnG.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnG.Location = new System.Drawing.Point(227, 145);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(30, 30);
            this.btnG.TabIndex = 93;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
            // 
            // btnZ
            // 
            this.btnZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnZ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnZ.Location = new System.Drawing.Point(103, 181);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(30, 30);
            this.btnZ.TabIndex = 92;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button24.Location = new System.Drawing.Point(43, 181);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(54, 30);
            this.button24.TabIndex = 91;
            this.button24.Text = "VVV";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnA.Location = new System.Drawing.Point(83, 145);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(30, 30);
            this.btnA.TabIndex = 90;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnW.Location = new System.Drawing.Point(99, 109);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(30, 30);
            this.btnW.TabIndex = 89;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnE.Location = new System.Drawing.Point(135, 109);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(30, 30);
            this.btnE.TabIndex = 88;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnR.Location = new System.Drawing.Point(171, 109);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(30, 30);
            this.btnR.TabIndex = 87;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnT.Location = new System.Drawing.Point(207, 109);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(30, 30);
            this.btnT.TabIndex = 86;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnY.Location = new System.Drawing.Point(243, 109);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(30, 30);
            this.btnY.TabIndex = 85;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnO.Location = new System.Drawing.Point(351, 109);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(30, 30);
            this.btnO.TabIndex = 84;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnP.Location = new System.Drawing.Point(387, 109);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(30, 30);
            this.btnP.TabIndex = 83;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnI.Location = new System.Drawing.Point(315, 109);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(30, 30);
            this.btnI.TabIndex = 82;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnU.Location = new System.Drawing.Point(279, 109);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(30, 30);
            this.btnU.TabIndex = 81;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQ.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnQ.Location = new System.Drawing.Point(63, 109);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(30, 30);
            this.btnQ.TabIndex = 80;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn2.Location = new System.Drawing.Point(79, 73);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(30, 30);
            this.btn2.TabIndex = 79;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn3.Location = new System.Drawing.Point(115, 73);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(30, 30);
            this.btn3.TabIndex = 78;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn4.Location = new System.Drawing.Point(151, 73);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(30, 30);
            this.btn4.TabIndex = 77;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn5.Location = new System.Drawing.Point(187, 73);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(30, 30);
            this.btn5.TabIndex = 76;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn6.Location = new System.Drawing.Point(223, 73);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(30, 30);
            this.btn6.TabIndex = 75;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn7.Location = new System.Drawing.Point(259, 73);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(30, 30);
            this.btn7.TabIndex = 74;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn8.Location = new System.Drawing.Point(295, 73);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(30, 30);
            this.btn8.TabIndex = 73;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn9.Location = new System.Drawing.Point(331, 73);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(30, 30);
            this.btn9.TabIndex = 72;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn0.Location = new System.Drawing.Point(367, 73);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(30, 30);
            this.btn0.TabIndex = 71;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btnBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnBackSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnBackSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackSpace.Location = new System.Drawing.Point(403, 73);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(54, 30);
            this.btnBackSpace.TabIndex = 70;
            this.btnBackSpace.Text = "<";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn1.Location = new System.Drawing.Point(43, 73);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(30, 30);
            this.btn1.TabIndex = 69;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // tbMatch
            // 
            this.tbMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.tbMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMatch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tbMatch.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbMatch.Location = new System.Drawing.Point(367, 48);
            this.tbMatch.Name = "tbMatch";
            this.tbMatch.Size = new System.Drawing.Size(90, 21);
            this.tbMatch.TabIndex = 68;
            this.tbMatch.Enter += new System.EventHandler(this.readOnlyButton_Enter);
            this.tbMatch.Leave += new System.EventHandler(this.readOnlyButton_Leave);
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
            this.button1.Location = new System.Drawing.Point(247, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 67;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbStreet
            // 
            this.tbStreet.AccessibleDescription = "";
            this.tbStreet.AccessibleName = "";
            this.tbStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.tbStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStreet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tbStreet.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbStreet.Location = new System.Drawing.Point(43, 48);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(198, 21);
            this.tbStreet.TabIndex = 66;
            this.tbStreet.TextChanged += new System.EventHandler(this.tbStreet_TextChanged);
            this.tbStreet.Enter += new System.EventHandler(this.readOnlyButton_Enter);
            this.tbStreet.Leave += new System.EventHandler(this.readOnlyButton_Leave);
            // 
            // meyer3jsDBConnection
            // 
            this.meyer3jsDBConnection.DataSetName = "meyer3jsDBConnection";
            this.meyer3jsDBConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAddressTableAdapter
            // 
            this.tAddressTableAdapter.ClearBeforeFill = true;
            // 
            // fStreetName
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 256);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.button44);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnForwardSlash);
            this.Controls.Add(this.btnApostrophe);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnAmpersand);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbMatch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbStreet);
            this.Name = "fStreetName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.lblScreen, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.tbStreet, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.tbMatch, 0);
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.btnBackSpace, 0);
            this.Controls.SetChildIndex(this.btn0, 0);
            this.Controls.SetChildIndex(this.btn9, 0);
            this.Controls.SetChildIndex(this.btn8, 0);
            this.Controls.SetChildIndex(this.btn7, 0);
            this.Controls.SetChildIndex(this.btn6, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.Controls.SetChildIndex(this.btnQ, 0);
            this.Controls.SetChildIndex(this.btnU, 0);
            this.Controls.SetChildIndex(this.btnI, 0);
            this.Controls.SetChildIndex(this.btnP, 0);
            this.Controls.SetChildIndex(this.btnO, 0);
            this.Controls.SetChildIndex(this.btnY, 0);
            this.Controls.SetChildIndex(this.btnT, 0);
            this.Controls.SetChildIndex(this.btnR, 0);
            this.Controls.SetChildIndex(this.btnE, 0);
            this.Controls.SetChildIndex(this.btnW, 0);
            this.Controls.SetChildIndex(this.btnA, 0);
            this.Controls.SetChildIndex(this.button24, 0);
            this.Controls.SetChildIndex(this.btnZ, 0);
            this.Controls.SetChildIndex(this.btnG, 0);
            this.Controls.SetChildIndex(this.btnF, 0);
            this.Controls.SetChildIndex(this.btnJ, 0);
            this.Controls.SetChildIndex(this.btnH, 0);
            this.Controls.SetChildIndex(this.btnL, 0);
            this.Controls.SetChildIndex(this.btnK, 0);
            this.Controls.SetChildIndex(this.btnAmpersand, 0);
            this.Controls.SetChildIndex(this.btnD, 0);
            this.Controls.SetChildIndex(this.btnS, 0);
            this.Controls.SetChildIndex(this.btnDash, 0);
            this.Controls.SetChildIndex(this.btnApostrophe, 0);
            this.Controls.SetChildIndex(this.btnForwardSlash, 0);
            this.Controls.SetChildIndex(this.btnM, 0);
            this.Controls.SetChildIndex(this.btnN, 0);
            this.Controls.SetChildIndex(this.btnB, 0);
            this.Controls.SetChildIndex(this.btnV, 0);
            this.Controls.SetChildIndex(this.btnC, 0);
            this.Controls.SetChildIndex(this.btnX, 0);
            this.Controls.SetChildIndex(this.button44, 0);
            this.Controls.SetChildIndex(this.btnSpace, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            ((System.ComponentModel.ISupportInitialize)(this.meyer3jsDBConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnForwardSlash;
        private System.Windows.Forms.Button btnApostrophe;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnAmpersand;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox tbMatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbStreet;
        private meyer3jsDBConnection meyer3jsDBConnection;
        private meyer3jsDBConnectionTableAdapters.tAddressTableAdapter tAddressTableAdapter;
    }
}

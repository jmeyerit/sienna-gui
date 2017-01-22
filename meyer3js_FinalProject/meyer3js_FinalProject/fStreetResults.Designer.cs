/******************************************************************************************************************************
 * Assignment Final Project                                                                          fStreetResults.Designer.cs
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
    partial class fStreetResults {
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
            this.tbMatch = new System.Windows.Forms.TextBox();
            this.tbStreetResults = new System.Windows.Forms.TextBox();
            this.meyer3jsDBConnection = new meyer3js_FinalProject.meyer3jsDBConnection();
            this.lvStreetName = new System.Windows.Forms.ListView();
            this.chStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // tbMatch
            // 
            this.tbMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.tbMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMatch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tbMatch.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbMatch.Location = new System.Drawing.Point(367, 48);
            this.tbMatch.Name = "tbMatch";
            this.tbMatch.Size = new System.Drawing.Size(90, 21);
            this.tbMatch.TabIndex = 22;
            // 
            // tbStreetResults
            // 
            this.tbStreetResults.AccessibleDescription = "";
            this.tbStreetResults.AccessibleName = "";
            this.tbStreetResults.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbStreetResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.tbStreetResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStreetResults.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tbStreetResults.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbStreetResults.Location = new System.Drawing.Point(43, 48);
            this.tbStreetResults.Name = "tbStreetResults";
            this.tbStreetResults.Size = new System.Drawing.Size(318, 21);
            this.tbStreetResults.TabIndex = 21;
            // 
            // meyer3jsDBConnection
            // 
            this.meyer3jsDBConnection.DataSetName = "meyer3jsDBConnection";
            this.meyer3jsDBConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lvStreetName
            // 
            this.lvStreetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.lvStreetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStreetName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStreet});
            this.lvStreetName.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvStreetName.FullRowSelect = true;
            this.lvStreetName.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvStreetName.Location = new System.Drawing.Point(43, 75);
            this.lvStreetName.MultiSelect = false;
            this.lvStreetName.Name = "lvStreetName";
            this.lvStreetName.Size = new System.Drawing.Size(414, 171);
            this.lvStreetName.TabIndex = 23;
            this.lvStreetName.UseCompatibleStateImageBehavior = false;
            this.lvStreetName.View = System.Windows.Forms.View.Details;
            this.lvStreetName.Click += new System.EventHandler(this.lvStreetName_Click);
            // 
            // chStreet
            // 
            this.chStreet.Text = "Street";
            this.chStreet.Width = 396;
            // 
            // tAddressTableAdapter
            // 
            this.tAddressTableAdapter.ClearBeforeFill = true;
            // 
            // fStreetResults
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 256);
            this.Controls.Add(this.lvStreetName);
            this.Controls.Add(this.tbMatch);
            this.Controls.Add(this.tbStreetResults);
            this.Name = "fStreetResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.lblScreen, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.tbStreetResults, 0);
            this.Controls.SetChildIndex(this.tbMatch, 0);
            this.Controls.SetChildIndex(this.lvStreetName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.meyer3jsDBConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMatch;
        private System.Windows.Forms.TextBox tbStreetResults;
        private meyer3jsDBConnection meyer3jsDBConnection;
        private System.Windows.Forms.ListView lvStreetName;
        private System.Windows.Forms.ColumnHeader chStreet;
        private meyer3jsDBConnectionTableAdapters.tAddressTableAdapter tAddressTableAdapter;
    }
}

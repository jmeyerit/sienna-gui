/******************************************************************************************************************************
 * Assignment Final Project                                                                            fCityResults.Designer.cs
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
    partial class fCityResults {
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
            this.lvCityStateAbr = new System.Windows.Forms.ListView();
            this.chCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStateAbr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbMatch = new System.Windows.Forms.TextBox();
            this.tbCityResults = new System.Windows.Forms.TextBox();
            this.cityResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meyer3jsDBConnection = new meyer3js_FinalProject.meyer3jsDBConnection();
            this.tCityWithSpecificStateTableAdapterResults = new meyer3js_FinalProject.meyer3jsDBConnectionTableAdapters.tCityWithSpecificStateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cityResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meyer3jsDBConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScreen
            // 
            this.lblScreen.Location = new System.Drawing.Point(14, 12);
            this.lblScreen.Size = new System.Drawing.Size(79, 18);
            this.lblScreen.Text = "City Name";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            // 
            // lvCityStateAbr
            // 
            this.lvCityStateAbr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.lvCityStateAbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCityStateAbr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCity,
            this.chStateAbr});
            this.lvCityStateAbr.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lvCityStateAbr.FullRowSelect = true;
            this.lvCityStateAbr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCityStateAbr.Location = new System.Drawing.Point(43, 75);
            this.lvCityStateAbr.MultiSelect = false;
            this.lvCityStateAbr.Name = "lvCityStateAbr";
            this.lvCityStateAbr.Size = new System.Drawing.Size(414, 171);
            this.lvCityStateAbr.TabIndex = 2;
            this.lvCityStateAbr.UseCompatibleStateImageBehavior = false;
            this.lvCityStateAbr.View = System.Windows.Forms.View.Details;
            this.lvCityStateAbr.Click += new System.EventHandler(this.lvCityStateAbr_Click);
            // 
            // chCity
            // 
            this.chCity.Text = "City";
            this.chCity.Width = 98;
            // 
            // chStateAbr
            // 
            this.chStateAbr.Text = "State";
            this.chStateAbr.Width = 298;
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
            this.tbMatch.TabIndex = 19;
            // 
            // tbCityResults
            // 
            this.tbCityResults.AccessibleDescription = "";
            this.tbCityResults.AccessibleName = "";
            this.tbCityResults.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCityResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.tbCityResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCityResults.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.tbCityResults.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbCityResults.Location = new System.Drawing.Point(43, 48);
            this.tbCityResults.Name = "tbCityResults";
            this.tbCityResults.Size = new System.Drawing.Size(318, 21);
            this.tbCityResults.TabIndex = 17;
            // 
            // cityResultsBindingSource
            // 
            this.cityResultsBindingSource.DataSource = this.meyer3jsDBConnection;
            this.cityResultsBindingSource.Position = 0;
            // 
            // meyer3jsDBConnection
            // 
            this.meyer3jsDBConnection.DataSetName = "meyer3jsDBConnection";
            this.meyer3jsDBConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCityWithSpecificStateTableAdapterResults
            // 
            this.tCityWithSpecificStateTableAdapterResults.ClearBeforeFill = true;
            // 
            // fCityResults
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 256);
            this.Controls.Add(this.tbMatch);
            this.Controls.Add(this.tbCityResults);
            this.Controls.Add(this.lvCityStateAbr);
            this.Name = "fCityResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fCityResults";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.lblScreen, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.lvCityStateAbr, 0);
            this.Controls.SetChildIndex(this.tbCityResults, 0);
            this.Controls.SetChildIndex(this.tbMatch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cityResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meyer3jsDBConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCityStateAbr;
        private System.Windows.Forms.TextBox tbMatch;
        private System.Windows.Forms.TextBox tbCityResults;
        private System.Windows.Forms.ColumnHeader chCity;
        private System.Windows.Forms.ColumnHeader chStateAbr;
        private System.Windows.Forms.BindingSource cityResultsBindingSource;
        private meyer3jsDBConnection meyer3jsDBConnection;
        private meyer3jsDBConnectionTableAdapters.tCityWithSpecificStateTableAdapter tCityWithSpecificStateTableAdapterResults;
    }
}
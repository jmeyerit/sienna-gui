/******************************************************************************************************************************
 * Assignment Final Project                                                                                   fStateProvince.cs
 * Justin Meyer
 * IT3045C-001 Fall Semester
 * meyer3js@mail.uc.edu
 * This Final Project asks us to simulate some of the functions provided by the Sat Nav in Professor 
 * Nicholson's Toyota Siena. NO MAPS!
 * This partial class contains the methods necessary to query and select a state to begin a query against the database in future
 * forms.
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

using System;
using System.Data;
using System.Windows.Forms;

namespace meyer3js_FinalProject {
    public partial class fStateProvince : meyer3js_FinalProject.fTemplate {

        // This public event exists so the fAddress form can listen in on this event to retrieve the selected item in the
        // listbox of this form.
        public event EventHandler lbStateClick;

        public fStateProvince() {
            InitializeComponent();
        }      
        // The message returned here is the selected value of the lbState listbox and will be retrieved from the fAddress Form
        public string lbStateSelectedValue {

            get {
                return lbState.SelectedValue.ToString();
            }
        }
        /// <summary>
        /// This method sets the top item in the lbState listbox of the specified string. If the string is not found, nothing will happen
        /// </summary>
        /// <param name="state">The state to be scrolled to in the lbState listbox</param>
        private void ScrollToState(string state) {

            foreach (DataRow row in this.meyer3jsDBConnection.tState.Rows) {

                int index = lbState.FindString(state);

                if (index != ListBox.NoMatches) {
                    lbState.TopIndex = index;
                }
            }
        }

        private void fStateProvince_Load(object sender, EventArgs e) {
            
            
            try {
                // Populates the table used to populate the tbState listbox
                this.tStateTableAdapter.Fill(this.meyer3jsDBConnection.tState);

                // Populates the table used to select the states with addresses
                this.tStatesSelectedTableAdapter.Fill(this.meyer3jsDBConnection.tStatesSelected);

                // calls the setSelectedItems method using the tStatesSelected data table
                SetSelectedItems();
                
                // eat the Exception if it is thrown
            } catch { }
            
            

        }
        /// <summary>
        /// This custom event handler sends a reference to this form's public properties of the fAddress form to access
        /// the state that the user clicked.
        /// </summary>
        /// <param name="sender">The object that triggered this event</param>
        /// <param name="e">The event arguments associated with the object passed.</param>
        private void lbState_Click(object sender, EventArgs e) {
            try {
                lbStateClick.Invoke(this, EventArgs.Empty);
                this.Close();
                // Eat the Exception if one is thrown
            } catch { }
            
        }
        /// <summary>
        /// This method selects the items in the lbState listbox based on an sql statement that returns only states that have an
        /// address in the database.
        /// </summary>
        private void SetSelectedItems() {
            // Clear the initial selection. The first item is always selected in a listbox if items are selectable.
            lbState.ClearSelected();
            
            try {
                // foreach loop that loops through the result set of the table populated above
                foreach (DataRow row in this.meyer3jsDBConnection.tStatesSelected.Rows) {

                    // Store the index location of the state in the row of the tStatesSelected data table
                    int index = lbState.FindString(row["State"].ToString());

                    // sets the matching index to the item in the listbox as selected if a match was found.
                    if (index != ListBox.NoMatches) {
                        lbState.SetSelected(index, true);
                    }
                }
            }
            catch { } // Eat the exception if one is thrown
            

            // Set the top index to start at 0, otherwise the list will start at the first highlighted list item.
            lbState.TopIndex = 0;          
        }
        

        private void btnABC_Click(object sender, EventArgs e) {
            ScrollToState("Alabama");
        }

        private void btnDEF_Click(object sender, EventArgs e) {
            ScrollToState("Delaware");
        }

        private void btnGHI_Click(object sender, EventArgs e) {
            ScrollToState("Georgia");
        }

        private void btnJKL_Click(object sender, EventArgs e) {
            ScrollToState("Kansas");
        }

        private void btnMNO_Click(object sender, EventArgs e) {
            ScrollToState("Maine");
        }

        private void btnPQRS_Click(object sender, EventArgs e) {
            ScrollToState("Pennsylvania");
        }

        private void btnTUV_Click(object sender, EventArgs e) {
            ScrollToState("Tennessee");
        }

        private void btnWXYZ_Click(object sender, EventArgs e) {
            ScrollToState("Washington");
        }
    }
}

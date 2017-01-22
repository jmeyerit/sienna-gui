/******************************************************************************************************************************
 * Assignment Final Project                                                                                   fStreetResults.cs
 * Justin Meyer
 * IT3045C-001 Fall Semester
 * meyer3js@mail.uc.edu
 * This Final Project asks us to simulate some of the functions provided by the Sat Nav in Professor 
 * Nicholson's Toyota Siena. NO MAPS!
 * This partial class contains the street names returned from the meyer3js database using a parameter from the fStreetName form.
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

namespace meyer3js_FinalProject {
    public partial class fStreetResults : meyer3js_FinalProject.fTemplate {

        private string stateAbr; // State abbreviation associated with the current query passed from the fStreetName form
        private string city; // city associated with the current query passed from the fStreetName form
        private string partialStreet; // The partial street passed from the fStreetName form to be fed into a like query
        private string match; // the number of records that will be displayed. Taken from the previous form

        private fHouseNumber houseNumber; // The next form to create once all necessary data has been processed in this one.

        public fStreetResults() {
            InitializeComponent();
        }

        public fStreetResults(string stateAbr, string city, string partialStreet, string match) {
            InitializeComponent();
            this.stateAbr = stateAbr;
            this.city = city;
            this.partialStreet = partialStreet;
            this.match = match;

            GenerateResults(partialStreet, match);
        }

        /// <summary>
        /// Populates the listview with the street passed. The match lists the number of items in the listview
        /// </summary>
        /// <param name="street">The string parameter passed. Since this is a like query, the street will deliver items like the street passed here.</param>
        /// <param name="match">The number of items the listview contains</param>
        private void GenerateResults(string partialStreet, string match) {

            tbStreetResults.Text = partialStreet;
            tbMatch.Text = match;

            this.tAddressTableAdapter.Fill(this.meyer3jsDBConnection.tAddress, stateAbr, city, partialStreet);

            foreach (DataRow row in this.meyer3jsDBConnection.tAddress.Rows) {

                lvStreetName.Items.Add(row["StreetName"].ToString());
            }
        }

        /// <summary>
        /// Passes the street selected to the newly created fHouseNumber form.
        /// </summary>
        /// <param name="sender">The listview object generating the event</param>
        /// <param name="e">The event arguments</param>
        private void lvStreetName_Click(object sender, EventArgs e) {

            string street = lvStreetName.SelectedItems[0].Text.ToString();


            houseNumber = new fHouseNumber(city, stateAbr, street);
            houseNumber.TopLevel = false;
            this.Controls.Add(houseNumber);
            houseNumber.Show();
        }
    }
}

/******************************************************************************************************************************
 * Assignment Final Project                                                                              fConfirmDestination.cs
 * Justin Meyer
 * IT3045C-001 Fall Semester
 * meyer3js@mail.uc.edu
 * This Final Project asks us to simulate some of the functions provided by the Sat Nav in Professor 
 * Nicholson's Toyota Siena. NO MAPS!
 * This partial class contains the results of all the queries and selections the user has generated. In a real app, this would
 * have actual functionality and maps to facilitate the user in navigation. The go button merely closes the app in this case.
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
using System.Windows.Forms;

namespace meyer3js_FinalProject {
    public partial class fConfirmDestination : meyer3js_FinalProject.fTemplate {

        private string houseNumber; // The house number passed from the fHouseNumber form
        private string street; // The street passed from the fHouseNumber form
        private string city; // the city passed from the fHouseNumber form
        private string stateAbr; // the state abbreviation passed from the fHouseNumber form

        public fConfirmDestination() {
            InitializeComponent();
        }

        public fConfirmDestination(string houseNumber, string street, string city, string stateAbr) {
            InitializeComponent();
            this.houseNumber = houseNumber;
            this.street = street;
            this.city = city;
            this.stateAbr = stateAbr;

            ShowAddress();
        }

        private void ShowAddress () {
            tbFullAddress.Text = houseNumber + " " + street + Environment.NewLine + city + ", " + stateAbr;        
        }

        private void btnGo_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}

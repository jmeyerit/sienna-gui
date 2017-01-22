/******************************************************************************************************************************
 * Assignment Final Project                                                                                         fAddress.cs
 * Justin Meyer
 * IT3045C-001 Fall Semester
 * meyer3js@mail.uc.edu
 * This Final Project asks us to simulate some of the functions provided by the Sat Nav in Professor 
 * Nicholson's Toyota Siena. NO MAPS!
 * This partial class contains the buttons necessary to create the state and city selection forms respectively
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

namespace meyer3js_FinalProject {
    public partial class fAddress : meyer3js_FinalProject.fTemplate {
        public fAddress() {
            InitializeComponent();
        }

        private fCityName cityName; // The fCityName form to be instantiated upon clicking btnCity passing the state parameter along with it.
        private fStateProvince stateProvince; // the fStateProvince form to be instantiated upon clicking btnState

        private void btnCity_Click(object sender, EventArgs e) {
            cityName = new fCityName(tbState.Text);
            cityName.TopLevel = false;
            this.Controls.Add(cityName);
            cityName.Show();
        }

        private void btnState_Click(object sender, EventArgs e) {
            stateProvince = new fStateProvince();
            stateProvince.TopLevel = false;
            this.Controls.Add(stateProvince);
            stateProvince.lbStateClick += lbState_Click; // Register the event listener for the selection of the state to be passed back to this form from the fStateProvince form.
            stateProvince.Show();
        }

        private void lbState_Click(object sender, EventArgs e) {
            try {
                tbState.Text = ((fStateProvince)sender).lbStateSelectedValue; // Set the text from the public property of the fStateProvince form referenced here.
            } catch { } // eat the exception
            
        }
    }
}

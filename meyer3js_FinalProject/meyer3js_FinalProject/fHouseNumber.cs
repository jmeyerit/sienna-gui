/******************************************************************************************************************************
 * Assignment Final Project                                                                                     fHouseNumber.cs
 * Justin Meyer
 * IT3045C-001 Fall Semester
 * meyer3js@mail.uc.edu
 * This Final Project asks us to simulate some of the functions provided by the Sat Nav in Professor 
 * Nicholson's Toyota Siena. NO MAPS!
 * This partial class contains the methods necessary to: Highlight buttons, reset button text color, search the database based on
 * specific parameters, registers the necessary event listeners, and creates a new fConfirmDestination form and passes the necessary data based on the selection from the user.
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
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace meyer3js_FinalProject {
    public partial class fHouseNumber : meyer3js_FinalProject.fTemplate {

        private string city; // The city used in the query passed from the fStreetResults form
        private string stateAbr; // the state abbreviation used in the query passed from the fStreetResults form
        private string street; // the street used in the query passed from the fStreetResults form

        private fConfirmDestination confirmDestination; // The last form to pass the necessary information that displays the address the user selected.

        public fHouseNumber() {
            InitializeComponent();
            RegisterButtonEventListeners();
            // The SendMessage function simulates a sort of placeholder text similar to html5 elements.
            SendMessage(tbHouseNumber.Handle, EM_SETCUEBANNER, 0, "Enter a House Number");
            SearchHouseNumber("");
        }

        public fHouseNumber(string city, string stateAbr, string street) {
            InitializeComponent();
            this.city = city;
            this.stateAbr = stateAbr;
            this.street = street;
            RegisterButtonEventListeners();
            // The SendMessage function simulates a sort of placeholder text similar to html5 elements.
            SendMessage(tbHouseNumber.Handle, EM_SETCUEBANNER, 0, "Enter a House Number");
            SearchHouseNumber("");
        }

        // We import the user32.dll in order to use the Windows function SendMessage
        private const int EM_SETCUEBANNER = 0x1501;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        // The readOnlyButton_Enter/Leave methods were implemented in order to allow the placeholder text to go through while
        // keeping the control from being edited directly. Normally we would just have the control read only from the get go, 
        // but this prevented the SendMessage function from actually changing the text of the box when it was empty. This
        // workaround was required.
        private void readOnlyButton_Enter(object sender, EventArgs e) {
            TextBox incomingSender = (TextBox)sender;
            incomingSender.ReadOnly = true;
        }

        private void readOnlyButton_Leave(object sender, EventArgs e) {
            TextBox incomingSender = (TextBox)sender;
            incomingSender.ReadOnly = false;
        }

        /// <summary>
        /// This method resets the button color back to their defaults. This method is called before the SearchHouseNumber
        /// function is called.
        /// </summary>
        private void ResetButtonColor() {

            try {
                foreach (Control control in this.Controls) {

                    if (control is Button) {
                        ((Button)control).BackColor = Color.FromArgb(1, 18, 33);
                    }
                }
            }
            catch { } // eats any exceptions thrown
            
        }

        /// <summary>
        /// This method uses the incoming houseNumber parameter to search the meyer3js database using a like query
        /// </summary>
        /// <param name="houseNumber">The house Number name passed. This can be a partial value.</param>
        private void SearchHouseNumber(string houseNumber) {

            try {
                int houseNumberCount = tAddressTableAdapter.FillLikeHouseNumber(this.meyer3jsDBConnection.tAddress, stateAbr, city, street, houseNumber);

                HighlightButtons(tbHouseNumber.Text);

                foreach (DataRow row in this.meyer3jsDBConnection.tAddress.Rows) {

                    if (houseNumber == row["Housenumber"].ToString()) {
                        btnOK.Enabled = true;
                    }
                    else {
                        btnOK.Enabled = false;
                    }
                }

                // This check needs to be here in case there are no entries returned. Otherwise the OK button will never be
                // disabled with 0 records returned.
                if (houseNumberCount == 0) {
                    btnOK.Enabled = false;
                }
            }
            catch { } // eats any exceptions thrown
            
        }

        /// <summary>
        /// This method highlights the buttons to match the house numbers returned from a database query. This method gets
        /// called after any text has changed in the tbHouseNumber textbox.
        /// </summary>
        /// <param name="houseNumberEntry">This parameter is the current input in the tbHouseNumber textbox.</param>
        private void HighlightButtons(string houseNumberEntry) {

            try {
                // We iterate through each row of the house numbers that have been returned from the query
                foreach (DataRow row in this.meyer3jsDBConnection.tAddress.Rows) {

                    // We set the street being checked as the current row value
                    string houseNumber = row["HouseNumber"].ToString();

                    // We loop through the controls of this form's instance
                    foreach (Control control in this.Controls) {

                        // If the control is a button, we execute this if statement
                        if (control is Button) {

                            // To prevent an IndexOutOfBounds Exception, we need to make sure that length of the input from the 
                            // tbHouseNumber text box is not greater than the length of the houseNumber string from the row
                            if (houseNumberEntry.Length < houseNumber.Length) {

                                // We perform an equality operation that is case insensitive. If the character at the houseNumbrt with
                                // the houseNumberEntry.Length as the index is equal to the text of the control's button, then we
                                // highlight it as it matches.
                                if ((((Button)control).Text.ToLower()) == houseNumber[houseNumberEntry.Length].ToString().ToLower()) {
                                    control.BackColor = Color.FromArgb(9, 30, 56);
                                }
                                // We have to have an extra check for the space as its text property doesn't actually contain a space.
                                else if ((((Button)control).Text == "Space" && houseNumber[houseNumberEntry.Length].ToString() == " ")) {
                                    control.BackColor = Color.FromArgb(9, 30, 56);
                                }
                            }
                        }
                    }
                }
            }
            catch { } // eats any exceptions thrown
            
        }

        /// <summary>
        /// This method registers the buttons for text input. Some buttons with special characteristics like space and Ampersand
        /// had to be moved to their own methods.
        /// </summary>
        private void RegisterButtonEventListeners() {
            btn0.Click += btn_Click;
            btn1.Click += btn_Click;
            btn2.Click += btn_Click;
            btn3.Click += btn_Click;
            btn4.Click += btn_Click;
            btn5.Click += btn_Click;
            btn6.Click += btn_Click;
            btn7.Click += btn_Click;
            btn8.Click += btn_Click;
            btn9.Click += btn_Click;
            btnForwardSlash.Click += btn_Click;
            btnDash.Click += btn_Click;
        }

        /// <summary>
        /// Event handler for most of the forms buttons
        /// </summary>
        /// <param name="sender">The button that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void btn_Click(object sender, EventArgs e) {
            Button incomingButton = (Button)sender;

            tbHouseNumber.AppendText(incomingButton.Text);
        }

        private void btnClear_Click(object sender, EventArgs e) {
            tbHouseNumber.Clear();
        }

        private void btnBackSpace_Click(object sender, EventArgs e) {
            
            // If the length of the text is 0, we prevent the substring from happening, less we get an ArgumentOutOfRangeException
            if (tbHouseNumber.Text.Length != 0) {
                tbHouseNumber.Text = tbHouseNumber.Text.Substring(0, tbHouseNumber.Text.Length - 1);
            }
        
        }

        private void tbHouseNumber_TextChanged(object sender, EventArgs e) {

            ResetButtonColor();
            SearchHouseNumber(tbHouseNumber.Text);
        }

        private void btnOK_Click(object sender, EventArgs e) {

            confirmDestination = new fConfirmDestination(tbHouseNumber.Text, street, city, stateAbr);
            confirmDestination.TopLevel = false;
            this.Controls.Add(confirmDestination);
            confirmDestination.Show();
        }
    }
}

/******************************************************************************************************************************
 * Assignment Final Project                                                                                      fStreetName.cs
 * Justin Meyer
 * IT3045C-001 Fall Semester
 * meyer3js@mail.uc.edu
 * This Final Project asks us to simulate some of the functions provided by the Sat Nav in Professor 
 * Nicholson's Toyota Siena. NO MAPS!
 * This partial class contains the methods necessary to: Highlight buttons, reset button text color, search the database based on
 * specific parameters, registers the necessary event listeners, and creates a new fStreetResults form and passes the necessary
 * data based on the selection from the user.
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
    public partial class fStreetName : meyer3js_FinalProject.fTemplate {

        private fStreetResults streetResults; // The form that this form will create once the user selects a street

        private string city; // The city used in the current query passed from the fCityResults form
        private string stateAbr; // The state abbreviation used in the current query passed from the fCityResults form


        public fStreetName() {
            InitializeComponent();

            SearchStreet("");
            RegisterButtonEventListeners();

            // The SendMessage function simulates a sort of placeholder text similar to html5 elements.
            SendMessage(tbStreet.Handle, EM_SETCUEBANNER, 0, "Enter a City Name");
            SendMessage(tbMatch.Handle, EM_SETCUEBANNER, 0, "***");
        }

        public fStreetName(string city, string stateAbr) {
            InitializeComponent();
            this.city = city;
            this.stateAbr = stateAbr;
            RegisterButtonEventListeners();
            

            SearchStreet("");

            // The SendMessage function simulates a sort of placeholder text similar to html5 elements.
            SendMessage(tbStreet.Handle, EM_SETCUEBANNER, 0, "Enter a Street Name");
            SendMessage(tbMatch.Handle, EM_SETCUEBANNER, 0, "***");
        }

        // We import the user32.dll in order to use the Windows function SendMessage
        private const int EM_SETCUEBANNER = 0x1501;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        /// <summary>
        /// This method uses the incoming streetName parameter to search the meyer3js database using a like query
        /// </summary>
        /// <param name="streetName">The street name passed. This can be a partial value.</param>
        private void SearchStreet(string streetName) {
            try {
                int streetCount = tAddressTableAdapter.Fill(this.meyer3jsDBConnection.tAddress, stateAbr, city, streetName);

                if (streetCount != 1) {
                    tbMatch.Text = streetCount + " Matches";
                }
                else {
                    tbMatch.Text = streetCount + " Match";
                }

                HighlightButtons(tbStreet.Text);

                if (streetCount > 0 && streetCount < 4) {
                    GenerateList(stateAbr, city, streetName, tbMatch.Text);

                }
            }
            catch { } // eat any exceptions thrown
            
        }

        /// <summary>
        /// Generates a list of the number of current matches
        /// </summary>
        /// <param name="stateAbr">The state abreviation of the current state</param>
        /// <param name="city">The current city</param>
        /// <param name="streetName">The partial or full streetname desired</param>
        /// <param name="match">Number of items that the listview will populate</param>
        private void GenerateList(string stateAbr, string city, string streetName, string match) {

            try {
                streetResults = new fStreetResults(stateAbr, city, streetName, match);
                streetResults.TopLevel = false;
                this.Controls.Add(streetResults);
                streetResults.Show();
            }
            catch { } // eat the exception
            
        }

        /// <summary>
        /// This method resets the button color back to their defaults. This method is called before the SearchStreet function
        /// is called.
        /// </summary>
        private void ResetButtonColor() {

            try {
                foreach (Control control in this.Controls) {

                    if (control is Button) {
                        ((Button)control).BackColor = Color.FromArgb(1, 18, 33);
                    }
                }
            }
            catch { } // eat any exceptions thrown
            
        }
        /// <summary>
        /// This method highlights the buttons to match the streets returned from a database query. This method gets called after 
        /// any text has changed in the tbStreet textbox.
        /// </summary>
        /// <param name="streetEntry">This parameter is the current input in the tbStreet textbox.</param>
        private void HighlightButtons(string streetEntry) {

            try {
                // We iterate through each row of the streets that have been returned from the query
                foreach (DataRow row in this.meyer3jsDBConnection.tAddress.Rows) {

                    // We set the street being checked as the current row value
                    string street = row["StreetName"].ToString();

                    // We loop through the controls of this form's instance
                    foreach (Control control in this.Controls) {

                        // If the control is a button, we execute this if statement
                        if (control is Button) {

                            // To prevent an IndexOutOfBounds Exception, we need to make sure that length of the input from the 
                            // tbStreet text box is not greater than the length of the street string from the row
                            if (streetEntry.Length < street.Length) {

                                // We perform an equality operation that is case insensitive. If the character at the street with the
                                // streetEntry.Length as the index is equal to the text of the control's button, then we highlight
                                // it as it matches.
                                if ((((Button)control).Text.ToLower()) == street[streetEntry.Length].ToString().ToLower()) {
                                    control.BackColor = Color.FromArgb(9, 30, 56);
                                }
                                // We have to have an extra check for the space as its text property doesn't actually contain a space.
                                else if ((((Button)control).Text == "Space" && street[streetEntry.Length].ToString() == " ")) {
                                    control.BackColor = Color.FromArgb(9, 30, 56);
                                }
                            }
                        }
                    }
                }
            }
            catch { } // eat any exceptions thrown
            
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
            btnA.Click += btn_Click;
            btnB.Click += btn_Click;
            btnC.Click += btn_Click;
            btnD.Click += btn_Click;
            btnE.Click += btn_Click;
            btnF.Click += btn_Click;
            btnG.Click += btn_Click;
            btnH.Click += btn_Click;
            btnI.Click += btn_Click;
            btnJ.Click += btn_Click;
            btnK.Click += btn_Click;
            btnL.Click += btn_Click;
            btnM.Click += btn_Click;
            btnN.Click += btn_Click;
            btnO.Click += btn_Click;
            btnP.Click += btn_Click;
            btnQ.Click += btn_Click;
            btnR.Click += btn_Click;
            btnS.Click += btn_Click;
            btnT.Click += btn_Click;
            btnU.Click += btn_Click;
            btnV.Click += btn_Click;
            btnW.Click += btn_Click;
            btnX.Click += btn_Click;
            btnY.Click += btn_Click;
            btnZ.Click += btn_Click;
            btnApostrophe.Click += btn_Click;
            btnForwardSlash.Click += btn_Click;
            btnDash.Click += btn_Click;
        }

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
        /// Event handler for most of the forms buttons
        /// </summary>
        /// <param name="sender">The button that initiated the event</param>
        /// <param name="e">The event arguments</param>
        private void btn_Click(object sender, EventArgs e) {
            Button incomingButton = (Button)sender;

            tbStreet.AppendText(incomingButton.Text);
        }

        private void btnBackSpace_Click(object sender, EventArgs e) {
            // If the length of the text is 0, we prevent the substring from happening, less we get an ArgumentOutOfRangeException
            if (tbStreet.Text.Length != 0) {
                tbStreet.Text = tbStreet.Text.Substring(0, tbStreet.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            tbStreet.Clear();
        }

        private void btnAmpersand_Click(object sender, EventArgs e) {
            tbStreet.AppendText("&");
        }

        private void btnSpace_Click(object sender, EventArgs e) {
            tbStreet.AppendText(" ");

            // Prevents empty spaces at the beginning of the text box
            tbStreet.Text = tbStreet.Text.TrimStart();

        }

        private void tbStreet_TextChanged(object sender, EventArgs e) {

            ResetButtonColor();
            SearchStreet(tbStreet.Text);
        }

        private void btnOK_Click(object sender, EventArgs e) {
            GenerateList(stateAbr, city, tbStreet.Text, tbMatch.Text);
        }
    }
}

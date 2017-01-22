/******************************************************************************************************************************
 * Assignment Final Project                                                                                        fCityName.cs
 * Justin Meyer
 * IT3045C-001 Fall Semester
 * meyer3js@mail.uc.edu
 * This Final Project asks us to simulate some of the functions provided by the Sat Nav in Professor 
 * Nicholson's Toyota Siena. NO MAPS!
 * This partial class contains the methods necessary to: Highlight buttons, reset button text color, search the database based on
 * specific parameters, registers the necessary event listeners, and creates a new fCityResults form and passes the necessary
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
    public partial class fCityName : meyer3js_FinalProject.fTemplate {

        private fCityResults cityResults; // The form that will be created once a partial city name can be passed

        private string stateParameter; // The specific state passed from the fAddress form instance

        public fCityName() {
            InitializeComponent();
            RegisterButtonEventListeners();
           // this.stateParameter = stateParameter;

            SearchCity("");


            // The SendMessage function simulates a sort of placeholder text similar to html5 elements.
            SendMessage(tbCity.Handle, EM_SETCUEBANNER, 0, "Enter a City Name");
            SendMessage(tbMatch.Handle, EM_SETCUEBANNER, 0, "***");
        }

        // This custom constructor will take the state that the user has selected in the previous form page
        public fCityName(string stateParameter) {
            InitializeComponent();
            RegisterButtonEventListeners();
            this.stateParameter = stateParameter;

            SearchCity("");

            // The SendMessage function simulates a sort of placeholder text similar to html5 elements.
            SendMessage(tbCity.Handle, EM_SETCUEBANNER, 0, "Enter a City Name");
            SendMessage(tbMatch.Handle, EM_SETCUEBANNER, 0, "***");
        }

        // We import the user32.dll in order to use the Windows function SendMessage
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        /// <summary>
        /// This method uses the incoming cityName parameter to search the meyer3js database using a like query
        /// </summary>
        /// <param name="cityName">The city name passed. This can be a partial value.</param>
        private void SearchCity(string cityName) {

            try {
                int cityCount = tCityWithSpecificStateTableAdapter.FillLikeCity(this.meyer3jsDBConnection.tCityWithSpecificState, stateParameter, cityName);

                if (cityCount != 1) {
                    tbMatch.Text = cityCount + " Matches";
                }
                else {
                    tbMatch.Text = cityCount + " Match";
                }

                HighlightButtons(tbCity.Text);

                if (cityCount > 0 && cityCount < 4) {
                    GenerateList(cityName, stateParameter, tbMatch.Text);
                }
            } catch { } // eat any exceptions thrown
            
        }

        /// <summary>
        /// Generates a list of the number of current matches
        /// </summary>
        /// <param name="city">The current city</param>
        /// <param name="streetName">The partial or full streetname desired</param>
        /// <param name="match">Number of items that the listview will populate</param>
        private void GenerateList(string city, string stateAbr, string match) {

            try {
                cityResults = new fCityResults(city, stateAbr, tbMatch.Text);
                cityResults.TopLevel = false;
                this.Controls.Add(cityResults);
                cityResults.Show();
            }
            catch { } // eat any exceptions thrown
            
        }

        /// <summary>
        /// This method resets the button color back to their defaults. This method is called before the SearchCity function
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
        /// This method highlights the buttons to match the cities returned from a database query. This method gets called after 
        /// any text has changed in the tbCity textbox.
        /// </summary>
        /// <param name="cityEntry">This parameter is the current input in the tbCity textbox.</param>
        private void HighlightButtons(string cityEntry) {

            try {
                // We iterate through each row of the cities that have been returned from the query
                foreach (DataRow row in this.meyer3jsDBConnection.tCityWithSpecificState.Rows) {

                    // We set the city being checked as the current row value
                    string city = row["City"].ToString();

                    // We loop through the controls of this form's instance
                    foreach (Control control in this.Controls) {

                        // If the control is a button, we execute this if statement
                        if (control is Button) {

                            // To prevent an IndexOutOfBounds Exception, we need to make sure that length of the input from the 
                            // tbCity text box is not greater than the length of the city string from the row
                            if (cityEntry.Length < city.Length) {

                                // We perform an equality operation that is case insensitive. If the character at the city with the
                                // cityEntry.Length as the index is equal to the text of the control's button, then we highlight
                                // it as it matches.
                                if ((((Button)control).Text.ToLower()) == city[cityEntry.Length].ToString().ToLower()) {
                                    control.BackColor = Color.FromArgb(9, 30, 56);
                                }
                                // We have to have an extra check for the space as its text property doesn't actually contain a space.
                                else if ((((Button)control).Text == "Space" && city[cityEntry.Length].ToString() == " ")) {
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

            tbCity.AppendText(incomingButton.Text);
        }

        private void btnBackSpace_Click(object sender, EventArgs e) {
            // If the length of the text is 0, we prevent the substring from happening, less we get an ArgumentOutOfRangeException
            if (tbCity.Text.Length != 0) {
                tbCity.Text = tbCity.Text.Substring(0, tbCity.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            tbCity.Clear();
        }

        private void btnAmpersand_Click(object sender, EventArgs e) {
            tbCity.AppendText("&");
        }

        private void btnSpace_Click(object sender, EventArgs e) {
            tbCity.AppendText(" ");

            // Prevents empty spaces at the beginning of the text box
            tbCity.Text = tbCity.Text.TrimStart();
           
        }
 
        private void tbCity_TextChanged(object sender, EventArgs e) {

            ResetButtonColor();
            SearchCity(tbCity.Text);
        }

        private void btnOK_Click(object sender, EventArgs e) {
            GenerateList(tbCity.Text, stateParameter, tbMatch.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web.Security;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using UserControl = System.Windows.Controls.UserControl;
using MessageBox = System.Windows.MessageBox;

namespace ProjektniZadatak.Views
{
    /// <summary>
    /// Interaction logic for LogonPage.xaml
    /// </summary>
    public partial class LogonPage : UserControl
    {
        public LogonPage()
        {
            InitializeComponent();
        }

        public event EventHandler LogonSuccess;



        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LogonSuccess(this, null);
        }
            
            //{

        //    SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-2583KAA\SQLEXPRESS;Initial Catalog=TEST_DOO;Integrated Security=True");
        //    try
        //    {
        //        if (sqlCon.State == ConnectionState.Closed)
        //            sqlCon.Open();
        //        String query = "SELECT COUNT(1) FROM Korisnici WHERE username=@username AND password=@password";
        //        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
        //        sqlCmd.CommandType = CommandType.Text;
        //        sqlCmd.Parameters.AddWithValue("@username", username.Text);
        //        sqlCmd.Parameters.AddWithValue("@password", password.Password);
        //        int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
        //        if (count == 1)
        //        {
        //            MainWindow dashboard = new MainWindow();
        //            dashboard.Show();
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Username or password is incorrect.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        sqlCon.Close();
        //    }
            //        string v = "Select * from Korisnici where username = '" + username.Text.Trim() + "' and password = '" + password + "'";
            //        SqlDataAdapter sda = new SqlDataAdapter(v, sqlcon);
            //        DataTable dtbl = new DataTable();
            //        sda.Fill(dtbl);

            //        if (dtbl.Rows.Count == 1)
            //        {
            //            frmMain objFrmMain = new frmMain();
            //            this.Hide;
            //            objFrmMain.Show();

            //        }
            //        else
            //        {
            //            Message.Show("Check your username and password!");
            //        }

            //    }
            //}

            //private void Hide()
            //{
            //    throw new NotImplementedException();
            //}
            //        private void Logon()
            //        {
            //            if (username.Text == String.Empty || password.Password == String.Empty)
            //            {
            //                DisplayError(true);
            //                return;
            //            }

            //            // Call Membership.ValidateUser to validate the supplied logon credentials and then
            //            // If successful, call GetRolesForUser to find out the roles to which this user belongs
            //            if (Membership.ValidateUser(username.Text, password.Password))
            //            {
            //                DisplayError(false);

            //                string[] roles = Roles.GetRolesForUser(username.Text);
            //                if (roles.Length == 0)
            //                {
            //                    DisplayError(true);
            //                    if (LogonFailed != null)
            //                    {
            //                        LogonFailed(this, new EventArgs());
            //                    }
            //                }
            //                else
            //                {
            //                    SessionContext.Logon(username.Text, roles[0]);
            //                    logonName.Text = SessionContext.UserName;

            //                    if (LogonSuccess != null)
            //                    {
            //                        LogonSuccess(this, new EventArgs());
            //                    }

            //                    logonForm.Visibility = Visibility.Collapsed;
            //                    logoffForm.Visibility = Visibility.Visible;
            //                }
            //            }
            //            else
            //            {
            //                DisplayError(true);
            //                if (LogonFailed != null)
            //                {
            //                    LogonFailed(this, new EventArgs());
            //                }
            //            }
            //        }

            //        public void Logoff()
            //        {
            //            SessionContext.Logoff();

            //            logoffForm.Visibility = Visibility.Collapsed;
            //            logonForm.Visibility = Visibility.Visible;
            //        }
            //#endregion

            //        #region Helper Methods
            //        private void DisplayError(bool b)
            //        {
            //            if (!b)
            //                txtError.Visibility = Visibility.Collapsed;
            //            else
            //            {
            //                txtError.Text = "Login was unsuccessful.  Please correct the errors and try again.\n The username or password provided is incorrect.";
            //                txtError.Visibility = Visibility.Visible;
            //            }
            //        }
            //        #endregion   
            //    }
            //}
        }

        //private void Close()
        //{
        //    throw new NotImplementedException();
        //}

        //internal class frmMain
        //{
        //    public frmMain()
        //    {
        //    }

        //    internal void Show()
        //    {
        //        throw new NotImplementedException();
        //    }
    }
    


    

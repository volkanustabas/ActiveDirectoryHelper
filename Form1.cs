using System;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ActiveDs;

namespace ActiveDirectoryHelper
{
    public partial class Form1 : Form
    {
        public DirectorySearcher DirSearch;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb_userPhoto.Visible = false;
            rtb_userDetail.Visible = false;
            lb_memberOf.Visible = false;
            btn_search.Select();
            tb_domainInfo.Text = GetSystemDomain();
        }

        private string GetSystemDomain()
        {
            try
            {
                return Domain.GetComputerDomain().ToString().ToLower();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private void ShowUserInformation(SearchResult rs)
        {

            rtb_userDetail.Clear();
            lb_memberOf.Items.Clear();

            pb_userPhoto.Visible = true;
            rtb_userDetail.Visible = true;
            lb_memberOf.Visible = true;

            Cursor.Current = Cursors.Default;

            var pd = PasswordDetails(tb_user.Text);
            var ipl = IsPasswordLock(tb_user.Text);

            rtb_userDetail.AppendText(@"Username : " + rs.GetDirectoryEntry().Properties["samaccountname"].Value +
                                      Environment.NewLine + @"FirstName : " +
                                      rs.GetDirectoryEntry().Properties["givenName"].Value + Environment.NewLine +
                                      @"Sn : " + rs.GetDirectoryEntry().Properties["sn"].Value + Environment.NewLine +
                                      @"Initials : " + rs.GetDirectoryEntry().Properties["initials"].Value +
                                      Environment.NewLine + @"Mail : " +
                                      rs.GetDirectoryEntry().Properties["mail"].Value + Environment.NewLine +
                                      @"Title : " + rs.GetDirectoryEntry().Properties["title"].Value +
                                      Environment.NewLine + @"Company : " +
                                      rs.GetDirectoryEntry().Properties["company"].Value + Environment.NewLine +
                                      @"TelephoneNumber : " +
                                      rs.GetDirectoryEntry().Properties["telephoneNumber"].Value + Environment.NewLine +
                                      @"PasswordExpireDate : " + pd + Environment.NewLine + @"IsPasswordLock? :" + ipl);


            foreach (var group in rs.GetDirectoryEntry().Properties["memberOf"])
            {
                var startIndex = group.ToString().IndexOf("CN=", 0, StringComparison.Ordinal) + 3;
                var endIndex = group.ToString().IndexOf(",", startIndex, StringComparison.Ordinal);

                lb_memberOf.Items.Add(group.ToString().Substring(startIndex, endIndex - startIndex));
            }

            if (rs.GetDirectoryEntry().Properties["thumbnailPhoto"].Value is byte[] data)
                using (var s = new MemoryStream(data))
                {
                    pb_userPhoto.Image = Image.FromStream(s);
                }
        }


        private void GetUserInformation(string domain)
        {
            Cursor.Current = Cursors.WaitCursor;

            SearchResult rs = null;

            rs = SearchUserByUserName(GetDirectorySearcher(domain), tb_user.Text.Trim());

            if (rs != null)
                ShowUserInformation(rs);
            else
                MessageBox.Show(@"User not found!", @"Search Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private DirectorySearcher GetDirectorySearcher(string domain)
        {
            if (DirSearch == null)
            {
                try
                {
                    DirSearch = new DirectorySearcher(
                        new DirectoryEntry("LDAP://" + domain));
                }
                catch (DirectoryServicesCOMException e)
                {
                    MessageBox.Show(@"Connection Creditial is Wrong!, please Check.", @"Erro Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    var s = e.Message;
                }

                return DirSearch;
            }

            return DirSearch;
        }

        private SearchResult SearchUserByUserName(DirectorySearcher ds, string username)
        {
            ds.Filter = @"(&((&(objectCategory=Person)(objectClass=User)))(samaccountname=" + username + "*))";

            ds.SearchScope = SearchScope.Subtree;
            ds.ServerTimeLimit = TimeSpan.FromSeconds(90);

            var userObject = ds.FindOne();

            if (userObject != null)
                return userObject;
            return null;
        }

        public static string PasswordDetails(string expireDate)
        {
            var domain = new PrincipalContext(ContextType.Domain);
            var user = UserPrincipal.FindByIdentity(domain, expireDate);
            if (user != null)
            {
                var entry = (DirectoryEntry) user.GetUnderlyingObject();
                var native = (IADsUser) entry.NativeObject;
                expireDate = native.PasswordExpirationDate.ToString("g");
            }

            return expireDate;
        }


        public static string IsPasswordLock(string username)
        {
            var ctx = new PrincipalContext(ContextType.Domain);

            var user = UserPrincipal.FindByIdentity(ctx, username);

            if (user != null)
            {
                var displayName = user.DisplayName;

                if (user.IsAccountLockedOut())
                    return "Locked";
                return "Not Locked";
            }

            return "0";
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if (tb_domainInfo.Text.Trim().Length != 0 && tb_user.Text.Trim().Length != 0)
                GetUserInformation(tb_domainInfo.Text.Trim());
            else
                MessageBox.Show(@"Please enter all required inputs.", @"Missing Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
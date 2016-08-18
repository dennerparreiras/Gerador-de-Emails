using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.Configuration;


namespace Gerador_de_Email.assets.ADHelper
{
    public class ActiveDirectoryHelper
    {
        private DirectoryEntry _directoryEntry = null;
        //LDAPPath, LDAPUser, LDAPPassword, LDAPDomain
        private ADConfig config;

        public ActiveDirectoryHelper(ref ADConfig aux)
        {
            config = aux;
        }

        private DirectoryEntry SearchRoot
        {
            get
            {
                if (_directoryEntry == null)
                {
                    _directoryEntry = new DirectoryEntry(config.LDAPPath, config.LDAPUser, MD5Crypt.Decript(config.LDAPPassword), AuthenticationTypes.Secure);
                }
                return _directoryEntry;
            }
        }


        internal ADUserDetail GetUserByFullName(String userName)
        {
            try
            {
                _directoryEntry = null;
                DirectorySearcher directorySearch = new DirectorySearcher(SearchRoot);
                directorySearch.Filter = "(&(objectClass=user)(cn=" + userName + "))";
                SearchResult results = directorySearch.FindOne();

                if (results != null)
                {
                    DirectoryEntry user = new DirectoryEntry(results.Path, config.LDAPUser, MD5Crypt.Decript(config.LDAPPassword));
                    return ADUserDetail.GetUser(user);
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public ADUserDetail GetUserByLoginName(String userName)
        {
            try
            {
                _directoryEntry = null;
                DirectorySearcher directorySearch = new DirectorySearcher(SearchRoot);
                directorySearch.Filter = "(&(objectClass=user)(SAMAccountName=" + userName + "))";
                SearchResult results = directorySearch.FindOne();

                if (results != null)
                {
                    DirectoryEntry user = new DirectoryEntry(results.Path, config.LDAPUser, MD5Crypt.Decript(config.LDAPPassword));
                    return ADUserDetail.GetUser(user);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }


        /// <summary>
        /// This function will take a DL or Group name and return list of users
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>

        public List<ADUserDetail> GetUserFromGroup(String groupName)
        {
            List<ADUserDetail> userlist = new List<ADUserDetail>();

            try
            {
                _directoryEntry = null;
                DirectorySearcher directorySearch = new DirectorySearcher(SearchRoot);
                directorySearch.Filter = "(&(objectClass=group)(SAMAccountName=" + groupName + "))";
                SearchResult results = directorySearch.FindOne();

                if (results != null)
                {

                    DirectoryEntry deGroup = new DirectoryEntry(results.Path, config.LDAPUser, MD5Crypt.Decript(config.LDAPPassword));
                    System.DirectoryServices.PropertyCollection pColl = deGroup.Properties;

                    int count = pColl["member"].Count;
                    for (int i = 0; i < count; i++)
                    {
                        string respath = results.Path;
                        string[] pathnavigate = respath.Split("CN".ToCharArray());
                        respath = pathnavigate[0];
                        string objpath = pColl["member"][i].ToString();
                        string path = respath + objpath;

                        DirectoryEntry user = new DirectoryEntry(path, config.LDAPUser, MD5Crypt.Decript(config.LDAPPassword));
                        ADUserDetail userobj = ADUserDetail.GetUser(user);
                        userlist.Add(userobj);
                        user.Close();
                    }
                }
                return userlist;
            }
            catch
            {
                return userlist;
            }
        }

        #region Get user with First Name

        public List<ADUserDetail> GetUsersByFirstName(string fName)
        {
            //UserProfile user;
            List<ADUserDetail> userlist = new List<ADUserDetail>();
            string filter = "";

            _directoryEntry = null;
            DirectorySearcher directorySearch = new DirectorySearcher(SearchRoot);
            directorySearch.Asynchronous = true;
            directorySearch.CacheResults = true;
            //filter = string.Format("(givenName={0}*", fName);

            filter = "(&(objectClass=user)(objectCategory=person)(givenName=" + fName + "*))";

            directorySearch.Filter = filter;

            SearchResultCollection userCollection = directorySearch.FindAll();

            foreach (SearchResult users in userCollection)
            {
                DirectoryEntry userEntry = new DirectoryEntry(users.Path, config.LDAPUser, MD5Crypt.Decript(config.LDAPPassword));
                ADUserDetail userInfo = ADUserDetail.GetUser(userEntry);

                userlist.Add(userInfo);
            }

            directorySearch.Filter = "(&(objectClass=group)(SAMAccountName=" + fName + "*))";
            SearchResultCollection results = directorySearch.FindAll();

            if (results != null)
            {
                foreach (SearchResult r in results)
                {
                    DirectoryEntry deGroup = new DirectoryEntry(r.Path, config.LDAPUser, MD5Crypt.Decript(config.LDAPPassword));

                    ADUserDetail agroup = ADUserDetail.GetUser(deGroup);
                    userlist.Add(agroup);
                }
            }
            return userlist;
        }

        #endregion
        #region AddUserToGroup

        public bool AddUserToGroup(string userlogin, string groupName)
        {
            try
            {
                _directoryEntry = null;
                ADManager admanager = new ADManager(config.LDAPDomain, config.LDAPUser, MD5Crypt.Decript(config.LDAPPassword));
                admanager.AddUserToGroup(userlogin, groupName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
        #region RemoveUserToGroup

        public bool RemoveUserToGroup(string userlogin, string groupName)
        {
            try
            {
                _directoryEntry = null;
                ADManager admanager = new ADManager("xxx", config.LDAPUser, MD5Crypt.Decript(config.LDAPPassword));
                admanager.RemoveUserFromGroup(userlogin, groupName);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
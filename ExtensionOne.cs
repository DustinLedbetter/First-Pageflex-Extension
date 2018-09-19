/***********************************************************************************************************************************
*                                                 GOD First                                                                        *
* Author: Dustin Ledbetter                                                                                                         *
* Release Date: 9-19-2018                                                                                                          *
* Version: 1.0                                                                                                                     *
* Purpose: To create an extension for the storefront to test how they work                                               *
************************************************************************************************************************************/

using Pageflex.Interfaces.Storefront;


namespace MyFirstExtension
{

    public class ExtensionOne : StorefrontExtension
    {

        #region Extension Name Overides
        // At a minimum your extension must override the DisplayName and UniqueName properties.


        // The UniqueName is used to associate a module with any data that it provides to Storefront.
        public override string UniqueName
        {
            get
            {
                return "ExtensionOne.logons.#####.com";
            }
        }

        // The DisplayName will be shown on the Extensions and Site Options pages of the Administrator site as the name of your module.
        public override string DisplayName
        {
            get
            {
                return "Extension One";
            }
        }
        #endregion


        #region UserLogin_Before (called before the user is allowed to logon)
        public override int UserLogon_Before(string uid)
        {
            string name;
            name = Storefront.GetValue("UserProperty", "LogonName", uid);
            if (name == "#####")
                return eShouldAbort;
            else
                return eSuccess;
        }
        #endregion



    //end of the class: ExtensionOne
    }
//end of the file
}

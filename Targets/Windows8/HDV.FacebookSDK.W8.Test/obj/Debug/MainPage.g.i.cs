﻿

#pragma checksum "D:\Workspace\HDV_PRJX01_FACEBOOKSDK\Targets\Windows8\HDV.FacebookSDK.W8.Test\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3283B881B1DF1376BF3477938D3E75AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HDV.FacebookSDK.W8.Test
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::HDV.FacebookSDK.Test.UserInfoView userInfoView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListBox lstFriends; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnLogin; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnLogout; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnRequest; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///MainPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            userInfoView = (global::HDV.FacebookSDK.Test.UserInfoView)this.FindName("userInfoView");
            lstFriends = (global::Windows.UI.Xaml.Controls.ListBox)this.FindName("lstFriends");
            btnLogin = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnLogin");
            btnLogout = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnLogout");
            btnRequest = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnRequest");
        }
    }
}



﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Discord_Bot.Modules.Quotation {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class QuoteSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static QuoteSettings defaultInstance = ((QuoteSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new QuoteSettings())));
        
        public static QuoteSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime LastUpdate {
            get {
                return ((global::System.DateTime)(this["LastUpdate"]));
            }
            set {
                this["LastUpdate"] = value;
            }
        }
    }
}
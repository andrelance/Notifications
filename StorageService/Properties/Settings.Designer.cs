﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorageService.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DefaultEndpointsProtocol=https;AccountName=andrelanceblob;AccountKey=7XrSSfZwM27x" +
            "TK/RdT7D30aVs6UF2tIxOMVaK/8ygs+E0e7I6GFALq30T2S51goxeUGZzykmZq0Es1I0zcekeA==;End" +
            "pointSuffix=core.windows.net")]
        public string AzureStorageServiceConnectionString {
            get {
                return ((string)(this["AzureStorageServiceConnectionString"]));
            }
        }
    }
}
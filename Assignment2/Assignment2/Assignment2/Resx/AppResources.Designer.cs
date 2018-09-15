using System;

namespace Assignment2.Resx {
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Assignment2.Resx.AppResources", typeof(AppResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LionTodo.
        /// </summary>
        internal static string ApplicationHeading {
            get {
                return ResourceManager.GetString("ApplicationHeading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LionTodo.
        /// </summary>
        internal static string ApplicationTitle {
            get {
                return ResourceManager.GetString("ApplicationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        internal static string CancelButton {
            get {
                return ResourceManager.GetString("CancelButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete.
        /// </summary>
        internal static string DeleteButton {
            get {
                return ResourceManager.GetString("DeleteButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done.
        /// </summary>
        internal static string DoneLabel {
            get {
                return ResourceManager.GetString("DoneLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        internal static string NameLabel {
            get {
                return ResourceManager.GetString("NameLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Notes.
        /// </summary>
        internal static string NotesLabel {
            get {
                return ResourceManager.GetString("NotesLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save.
        /// </summary>
        internal static string SaveButton {
            get {
                return ResourceManager.GetString("SaveButton", resourceCulture);
            }
        }
        
    }
}

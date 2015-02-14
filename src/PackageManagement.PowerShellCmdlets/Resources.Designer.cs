﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.PackageManagement.PowerShellCmdlets {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.PackageManagement.PowerShellCmdlets.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to This Command/Parameter combination has been deprecated and will be removed in the next release. Please consider using the new command that replaces it: &apos;{0}&apos;..
        /// </summary>
        internal static string Cmdlet_CommandObsolete {
            get {
                return ResourceManager.GetString("Cmdlet_CommandObsolete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} Command has been deprecated and will be removed in the next release. Please modify your PowerShell scripts accordingly. .
        /// </summary>
        internal static string Cmdlet_CommandRemoved {
            get {
                return ResourceManager.GetString("Cmdlet_CommandRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating package at {0}....
        /// </summary>
        internal static string Cmdlet_CreatingPackage {
            get {
                return ResourceManager.GetString("Cmdlet_CreatingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop to display more packages.
        /// </summary>
        internal static string Cmdlet_DisplayMorePackagesNoHelp {
            get {
                return ResourceManager.GetString("Cmdlet_DisplayMorePackagesNoHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continue to display more packages.
        /// </summary>
        internal static string Cmdlet_DisplayMorePackagesYesHelp {
            get {
                return ResourceManager.GetString("Cmdlet_DisplayMorePackagesYesHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to parse package identities from file {0} with exception: {1}.
        /// </summary>
        internal static string Cmdlet_FailToParsePackages {
            get {
                return ResourceManager.GetString("Cmdlet_FailToParsePackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to parse the input of Version parameter: {0} to a valid Semantic version. .
        /// </summary>
        internal static string Cmdlet_FailToParseVersion {
            get {
                return ResourceManager.GetString("Cmdlet_FailToParseVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source at {0} is unreachable. Falling back to NuGet Local Cache at {1}.
        /// </summary>
        internal static string Cmdlet_FallbackToCache {
            get {
                return ResourceManager.GetString("Cmdlet_FallbackToCache", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skip this file and all subsequent files.
        /// </summary>
        internal static string Cmdlet_FileConflictNoAllHelp {
            get {
                return ResourceManager.GetString("Cmdlet_FileConflictNoAllHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skip this file.
        /// </summary>
        internal static string Cmdlet_FileConflictNoHelp {
            get {
                return ResourceManager.GetString("Cmdlet_FileConflictNoHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite this file and all subsequent files.
        /// </summary>
        internal static string Cmdlet_FileConflictYesAllHelp {
            get {
                return ResourceManager.GetString("Cmdlet_FileConflictYesAllHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite this file.
        /// </summary>
        internal static string Cmdlet_FileConflictYesHelp {
            get {
                return ResourceManager.GetString("Cmdlet_FileConflictYesHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output file &apos;{0}&apos; exists and -NoClobber was specified..
        /// </summary>
        internal static string Cmdlet_FileExistsNoClobber {
            get {
                return ResourceManager.GetString("Cmdlet_FileExistsNoClobber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No packages found in the current package source..
        /// </summary>
        internal static string Cmdlet_GetPackageNoPackageFound {
            get {
                return ResourceManager.GetString("Cmdlet_GetPackageNoPackageFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are downloading {0} from {1}, the license agreement to which is available at {2}. Check the package for additional dependencies, which may come with their own license agreement(s). Your use of the package and dependencies constitutes your acceptance of their license agreements. If you do not accept the license agreement(s), then delete the relevant components from your device..
        /// </summary>
        internal static string Cmdlet_InstallSuccessDisclaimerText {
            get {
                return ResourceManager.GetString("Cmdlet_InstallSuccessDisclaimerText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string Cmdlet_InvalidPathSyntax {
            get {
                return ResourceManager.GetString("Cmdlet_InvalidPathSyntax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified IProjectManager instance is not recognized..
        /// </summary>
        internal static string Cmdlet_InvalidProjectManagerInstance {
            get {
                return ResourceManager.GetString("Cmdlet_InvalidProjectManagerInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only paths residing on a FileSystemProvider are supported..
        /// </summary>
        internal static string Cmdlet_InvalidProvider {
            get {
                return ResourceManager.GetString("Cmdlet_InvalidProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The PSDrive &apos;{0}&apos; was not found..
        /// </summary>
        internal static string Cmdlet_InvalidPSDrive {
            get {
                return ResourceManager.GetString("Cmdlet_InvalidPSDrive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source at {0} is unreachable. There is no NuGet Local Cache found.
        /// </summary>
        internal static string Cmdlet_LocalCacheFailure {
            get {
                return ResourceManager.GetString("Cmdlet_LocalCacheFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;No.
        /// </summary>
        internal static string Cmdlet_No {
            get {
                return ResourceManager.GetString("Cmdlet_No", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to retrieve package list because no source was specified..
        /// </summary>
        internal static string Cmdlet_NoActivePackageSource {
            get {
                return ResourceManager.GetString("Cmdlet_NoActivePackageSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No to Al&amp;l.
        /// </summary>
        internal static string Cmdlet_NoAll {
            get {
                return ResourceManager.GetString("Cmdlet_NoAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No compatible project(s) found in the active solution..
        /// </summary>
        internal static string Cmdlet_NoCompatibleProjects {
            get {
                return ResourceManager.GetString("Cmdlet_NoCompatibleProjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No package actions available to be executed..
        /// </summary>
        internal static string Cmdlet_NoPackageActions {
            get {
                return ResourceManager.GetString("Cmdlet_NoPackageActions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No packages installed..
        /// </summary>
        internal static string Cmdlet_NoPackagesInstalled {
            get {
                return ResourceManager.GetString("Cmdlet_NoPackagesInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No package updates are available from the current package source..
        /// </summary>
        internal static string Cmdlet_NoPackageUpdates {
            get {
                return ResourceManager.GetString("Cmdlet_NoPackageUpdates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current environment doesn&apos;t have a solution open..
        /// </summary>
        internal static string Cmdlet_NoSolution {
            get {
                return ResourceManager.GetString("Cmdlet_NoSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nothing to do.
        /// </summary>
        internal static string Cmdlet_NothingToDo {
            get {
                return ResourceManager.GetString("Cmdlet_NothingToDo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate a .nuspec file in the specified project..
        /// </summary>
        internal static string Cmdlet_NuspecFileNotFound {
            get {
                return ResourceManager.GetString("Cmdlet_NuspecFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open.
        /// </summary>
        internal static string Cmdlet_OpenPackagePageAction {
            get {
                return ResourceManager.GetString("Cmdlet_OpenPackagePageAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package file successfully created....
        /// </summary>
        internal static string Cmdlet_PackageCreated {
            get {
                return ResourceManager.GetString("Cmdlet_PackageCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package with the Id &apos;{0}&apos; and version &apos;{1}&apos; is not found in the specified source..
        /// </summary>
        internal static string Cmdlet_PackageIdAndVersionNotFound {
            get {
                return ResourceManager.GetString("Cmdlet_PackageIdAndVersionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package with the Id &apos;{0}&apos; is not found in the specified source..
        /// </summary>
        internal static string Cmdlet_PackageIdNotFound {
            get {
                return ResourceManager.GetString("Cmdlet_PackageIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package with the Id &apos;{0}&apos; is not installed to the current project..
        /// </summary>
        internal static string Cmdlet_PackageNotInstalled {
            get {
                return ResourceManager.GetString("Cmdlet_PackageNotInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} {1}.
        /// </summary>
        internal static string Cmdlet_PackageOperation {
            get {
                return ResourceManager.GetString("Cmdlet_PackageOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package source &apos;{0}&apos; is not matching any of the enabled package sources..
        /// </summary>
        internal static string Cmdlet_PackageSourceNotFound {
            get {
                return ResourceManager.GetString("Cmdlet_PackageSourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Package source&apos; has been successfully set as &apos;{0}&apos;..
        /// </summary>
        internal static string Cmdlet_PackageSourceSet {
            get {
                return ResourceManager.GetString("Cmdlet_PackageSourceSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project &apos;{0}&apos; is not found..
        /// </summary>
        internal static string Cmdlet_ProjectNotFound {
            get {
                return ResourceManager.GetString("Cmdlet_ProjectNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Default project&apos; has been successfully set as &apos;{0}&apos;..
        /// </summary>
        internal static string Cmdlet_ProjectSet {
            get {
                return ResourceManager.GetString("Cmdlet_ProjectSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There may be more packages to display. Do you want to continue?.
        /// </summary>
        internal static string Cmdlet_PrompToDisplayMorePackages {
            get {
                return ResourceManager.GetString("Cmdlet_PrompToDisplayMorePackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one .nuspec files were found..
        /// </summary>
        internal static string Cmdlet_TooManySpecFiles {
            get {
                return ResourceManager.GetString("Cmdlet_TooManySpecFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package &apos;{0}&apos; does not provide the requested URL..
        /// </summary>
        internal static string Cmdlet_UrlMissing {
            get {
                return ResourceManager.GetString("Cmdlet_UrlMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifying both -Reinstall and -WhatIf is not supported for now..
        /// </summary>
        internal static string Cmdlet_WhatIfReinstallUnsupported {
            get {
                return ResourceManager.GetString("Cmdlet_WhatIfReinstallUnsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Yes.
        /// </summary>
        internal static string Cmdlet_Yes {
            get {
                return ResourceManager.GetString("Cmdlet_Yes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yes to &amp;All.
        /// </summary>
        internal static string Cmdlet_YesAll {
            get {
                return ResourceManager.GetString("Cmdlet_YesAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished adding BindingRedirects to project &apos;{0}&apos;.
        /// </summary>
        internal static string Cmdlets_AddedBindingRedirects {
            get {
                return ResourceManager.GetString("Cmdlets_AddedBindingRedirects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to add BindingRedirects to project &apos;{0}&apos; due to error: {1}.
        /// </summary>
        internal static string Cmdlets_FailedBindingRedirects {
            get {
                return ResourceManager.GetString("Cmdlets_FailedBindingRedirects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing script file &apos;{0}&apos;.
        /// </summary>
        internal static string ExecutingScript {
            get {
                return ResourceManager.GetString("ExecutingScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File Conflict.
        /// </summary>
        internal static string FileConflictTitle {
            get {
                return ResourceManager.GetString("FileConflictTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None.
        /// </summary>
        internal static string Log_NoActionsWhatIf {
            get {
                return ResourceManager.GetString("Log_NoActionsWhatIf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WhatIf: {0}.
        /// </summary>
        internal static string Log_OperationWhatIf {
            get {
                return ResourceManager.GetString("Log_OperationWhatIf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was not installed in any project. Update failed..
        /// </summary>
        internal static string PackageNotInstalledInAnyProject {
            get {
                return ResourceManager.GetString("PackageNotInstalledInAnyProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find package &apos;{0}&apos;..
        /// </summary>
        internal static string UnknownPackage {
            get {
                return ResourceManager.GetString("UnknownPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find version &apos;{1}&apos; of package &apos;{0}&apos;..
        /// </summary>
        internal static string UnknownPackageSpecificVersion {
            get {
                return ResourceManager.GetString("UnknownPackageSpecificVersion", resourceCulture);
            }
        }
    }
}

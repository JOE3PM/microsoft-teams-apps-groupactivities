﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Teams.Apps.GroupBot.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Teams.Apps.GroupBot.Resources.Strings", typeof(Strings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to create channels for each group right now?.
        /// </summary>
        public static string AutoCreateChannelQuestionText {
            get {
                return ResourceManager.GetString("AutoCreateChannelQuestionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Try different group criteria. I can&apos;t create more than 30 private channels and 200 public channels..
        /// </summary>
        public static string ChannelCountValidationText {
            get {
                return ResourceManager.GetString("ChannelCountValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I couldn’t create channels for the following groups :.
        /// </summary>
        public static string ChannelCreationFailureSubText {
            get {
                return ResourceManager.GetString("ChannelCreationFailureSubText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Here is an update for the activity **{0}**:.
        /// </summary>
        public static string ChannelCreationFailureText {
            get {
                return ResourceManager.GetString("ChannelCreationFailureText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description is required..
        /// </summary>
        public static string ChannelDesciptionValidationText {
            get {
                return ResourceManager.GetString("ChannelDesciptionValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name is required and do not accept characters ~#%&amp;*{}+/\:&lt;&gt;?|&apos;&quot;...
        /// </summary>
        public static string ChannelTitleValidationText {
            get {
                return ResourceManager.GetString("ChannelTitleValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Channel type.
        /// </summary>
        public static string ChannelTypeQuestionText {
            get {
                return ResourceManager.GetString("ChannelTypeQuestionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong. Try again in a few minutes..
        /// </summary>
        public static string CustomErrorMessage {
            get {
                return ResourceManager.GetString("CustomErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Due date is required..
        /// </summary>
        public static string DueDateEmptyValidationText {
            get {
                return ResourceManager.GetString("DueDateEmptyValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Due date.
        /// </summary>
        public static string DueDateText {
            get {
                return ResourceManager.GetString("DueDateText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Due date cannot be a past date time..
        /// </summary>
        public static string DueDateValidationText {
            get {
                return ResourceManager.GetString("DueDateValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time.
        /// </summary>
        public static string DueTimeText {
            get {
                return ResourceManager.GetString("DueTimeText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Go to original thread.
        /// </summary>
        public static string GoToOriginalThreadButtonText {
            get {
                return ResourceManager.GetString("GoToOriginalThreadButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Description.
        /// </summary>
        public static string GroupActivityDescriptionTitle {
            get {
                return ResourceManager.GetString("GroupActivityDescriptionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Activity.
        /// </summary>
        public static string GroupActivityTitle {
            get {
                return ResourceManager.GetString("GroupActivityTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to **{0}** has created a new group activity :.
        /// </summary>
        public static string GroupCreatorActivityCardText {
            get {
                return ResourceManager.GetString("GroupCreatorActivityCardText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Try again. The number in each group must be less than the total in the team..
        /// </summary>
        public static string GroupCriteriaFailText {
            get {
                return ResourceManager.GetString("GroupCriteriaFailText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group criteria.
        /// </summary>
        public static string GroupCriteriaText {
            get {
                return ResourceManager.GetString("GroupCriteriaText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group criteria is required..
        /// </summary>
        public static string GroupCriteriaValidationText {
            get {
                return ResourceManager.GetString("GroupCriteriaValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There&apos;s a {0} channel for each group. Head to your channel to get started!.
        /// </summary>
        public static string GroupingCardConclusionText {
            get {
                return ResourceManager.GetString("GroupingCardConclusionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Groups for this activity :.
        /// </summary>
        public static string GroupingMessageText {
            get {
                return ResourceManager.GetString("GroupingMessageText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid tenant detected..
        /// </summary>
        public static string InvalidTenant {
            get {
                return ResourceManager.GetString("InvalidTenant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group created :.
        /// </summary>
        public static string MentionText {
            get {
                return ResourceManager.GetString("MentionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        public static string NameLabel {
            get {
                return ResourceManager.GetString("NameLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No results found. Try a different keyword..
        /// </summary>
        public static string NoActivitiesFoundText {
            get {
                return ResourceManager.GetString("NoActivitiesFoundText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please try opening from the team where app is installed..
        /// </summary>
        public static string NoTeamFoundErrorText {
            get {
                return ResourceManager.GetString("NoTeamFoundErrorText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The bot will send the reminders two times a day..
        /// </summary>
        public static string NotificationInformationText {
            get {
                return ResourceManager.GetString("NotificationInformationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want due-date reminders?.
        /// </summary>
        public static string NotificationQuestionText {
            get {
                return ResourceManager.GetString("NotificationQuestionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have been added to a new group activity in {0} by {1}. Details as follows:.
        /// </summary>
        public static string NotificationText {
            get {
                return ResourceManager.GetString("NotificationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No.
        /// </summary>
        public static string NoTitle {
            get {
                return ResourceManager.GetString("NoTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not logged in. Please sign in to create group activity..
        /// </summary>
        public static string NotLoginText {
            get {
                return ResourceManager.GetString("NotLoginText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I can&apos;t create your group activity. Ask your team owner to create one..
        /// </summary>
        public static string NotTeamOwnerText {
            get {
                return ResourceManager.GetString("NotTeamOwnerText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Private.
        /// </summary>
        public static string PrivateChannelTypeText {
            get {
                return ResourceManager.GetString("PrivateChannelTypeText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Public.
        /// </summary>
        public static string PublicChannelTypeText {
            get {
                return ResourceManager.GetString("PublicChannelTypeText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sign in to send messages with Group Activities Bot..
        /// </summary>
        public static string SigninCardText {
            get {
                return ResourceManager.GetString("SigninCardText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create.
        /// </summary>
        public static string SplitButtonText {
            get {
                return ResourceManager.GetString("SplitButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total number of groups to create.
        /// </summary>
        public static string SplitInGivenNumberOfGroups {
            get {
                return ResourceManager.GetString("SplitInGivenNumberOfGroups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of people in each group.
        /// </summary>
        public static string SplitInGroupOfGivenMembers {
            get {
                return ResourceManager.GetString("SplitInGroupOfGivenMembers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No team members available for grouping. Please add team members..
        /// </summary>
        public static string TeamMembersDoesNotExistsText {
            get {
                return ResourceManager.GetString("TeamMembersDoesNotExistsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose a number.
        /// </summary>
        public static string UnitsText {
            get {
                return ResourceManager.GetString("UnitsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Try different group criteria. I can&apos;t create less than 2 groups or more than 30..
        /// </summary>
        public static string UnitValidationText {
            get {
                return ResourceManager.GetString("UnitValidationText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I can quickly divide your team into groups and assign activities with deadlines. 
        ///To get started, click on the small Group Activities Bot logo below where you type messages. If it&apos;s not visible, select **More options...**..
        /// </summary>
        public static string WelcomeCardContent {
            get {
                return ResourceManager.GetString("WelcomeCardContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome!.
        /// </summary>
        public static string WelcomeCardTitle {
            get {
                return ResourceManager.GetString("WelcomeCardTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yes.
        /// </summary>
        public static string YesTitle {
            get {
                return ResourceManager.GetString("YesTitle", resourceCulture);
            }
        }
    }
}

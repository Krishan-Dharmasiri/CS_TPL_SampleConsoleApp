using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    /// <summary>
    /// hold data about Report Groups that we deal with. E.g. Run date, client that the group belongs to, 
    /// A report group can have more than one report
    /// 
    /// </summary>
    class ReportGroup
    {
        public int ReportGroupId { get; set; }
        public string ReportGroupName { get; set; }

        /*
         * KD: To, CC, BCC email address that the summary of this should be sent to.
         * 
         */ 
        public string SummaryTo { get; set; }
        public string SummaryCC { get; set; }
        public string SummaryBCC { get; set; }
    }
}

using System;
namespace AutomationFramework.APIResponse
{
	public class OrderResponse
	{
        public string AccessionNumber { get; set; }
        public string OrgCode { get; set; }
        public string SiteName { get; set; }
        public string PatientMRN { get; set; }
        public string PatientName { get; set; }
        public string Modality { get; set; }
        public DateTime StudyDateTime { get; set; }
        public string Status { get; set; }
    }
}


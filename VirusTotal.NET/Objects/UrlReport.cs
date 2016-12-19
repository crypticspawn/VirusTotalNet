using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VirusTotalNET.Objects
{
    public class UrlReport
    {
        /// <summary>
        /// Filescan Id of the resource.
        /// </summary>
        [JsonProperty("filescan_id")]
        public string FilescanId { get; set; }

        /// <summary>
        /// A permanent link that points to this specific scan.
        /// </summary>
        public string Permalink { get; set; }

        /// <summary>
        /// How many engines flagged this resource.
        /// </summary>
        public int Positives { get; set; }
        
        /// <summary>
        /// Contains the id of the resource. Can be a SHA256, MD5 or other hash type.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The response code. Use this to determine the status of the report.
        /// </summary>
        [JsonProperty("response_code")]
        public ReportResponseCode ResponseCode { get; set; }

        /// <summary>
        /// The date the resource was last scanned.
        /// </summary>
        [JsonProperty("scan_date")]
        public DateTime ScanDate { get; set; }
        
        /// <summary>
        /// Contains the scan id for this result.
        /// </summary>
        [JsonProperty("scan_id")]
        public string ScanId { get; set; }

        /// <summary>
        /// The scan results from each engine.
        /// </summary>
        public Dictionary<string, ScanEngine> Scans { get; set; }

        /// <summary>
        /// How many engines scanned this resource.
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Contains the message that corrosponds to the reponse code.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Contains the message that corrosponds to the reponse code.
        /// </summary>
        [JsonProperty("verbose_msg")]
        public string VerboseMsg { get; set; }
    }
}
using System;
using System.Configuration;

namespace Business.Core
{
    public static class Settings
    {
        private static string jobsearchConnectionString = string.Empty;

        public static string JobSearchConnectionString
        {
            get
            {
                if (String.IsNullOrWhiteSpace(jobsearchConnectionString))
                {
                    jobsearchConnectionString = ConfigurationManager.ConnectionStrings["JOBSEARCH"].ToString();
                }
                return jobsearchConnectionString;
            }
        }
    }
}
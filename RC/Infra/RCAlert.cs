using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RC.Infra
{
    public class RCAlert
    {
        public string Message { get; set; }
        public AlertType Type { get; set; }
        public string HTMLClass { get; private set; }
        public string UrlHelp { get; set; }
        public string UrlName { get; set; }

        public RCAlert(string message, AlertType type)
        {
            this.Message = message;
            this.Type = type;

            switch (this.Type)
            {
                case AlertType.Warning:
                    this.HTMLClass = "";
                    break;
                case AlertType.Error:
                    this.HTMLClass = "alert-danger";
                    break;
                case AlertType.Success:
                    this.HTMLClass = "alert-success";
                    break;
                case AlertType.Info:
                    this.HTMLClass = "alert-info";
                    break;
            }
        }

        public RCAlert(string message, AlertType type, string urlHelp, string urlName)
        {
            this.Message = message;
            this.Type = type;
            this.UrlHelp = urlHelp;
            this.UrlName = urlName;

            switch (this.Type)
            {
                case AlertType.Warning:
                    this.HTMLClass = "";
                    break;
                case AlertType.Error:
                    this.HTMLClass = "alert-error";
                    break;
                case AlertType.Success:
                    this.HTMLClass = "alert-success";
                    break;
                case AlertType.Info:
                    this.HTMLClass = "alert-info";
                    break;
            }
        }
    }

    public enum AlertType
    {
        Warning,
        Error,
        Success,
        Info
    }
}


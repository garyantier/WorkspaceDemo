using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkspaceDemo.Models
{
    public class ServiceWorkspace
    {
        public Guid WorkspaceId { get; set; }
        public string WorkspaceName { get; set; }
        public List<WorkspaceAction> Actions { get; set; }
    }
}
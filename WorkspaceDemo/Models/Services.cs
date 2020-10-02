using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkspaceDemo.Models
{
    public class Services
    {
        public Guid ServiceId { get; set; }
        public string ServiceName { get; set; }
        public List<ServiceWorkspace> Workspaces { get; set; }

        public static List<Services> Browse()
        {
            var action = new WorkspaceAction() {
                ActionId = new Guid(),
                ActionName = "Create",
                IsModal = true,
                ModalSource = "/ensurance/clients/createmodal/"
            };
            var workspace = new List<ServiceWorkspace>()
            {
                new ServiceWorkspace()
                {
                    WorkspaceId = new Guid(),
                    WorkspaceName = "Client",
                    Actions = new List<WorkspaceAction>() {
                        action
                    }
                }
            };
            var services = new List<Services>()
            {
                new Services()
                {
                    ServiceId = new Guid(),
                    ServiceName = "Ensurance",
                    Workspaces = workspace
                }
            };

            return services;
        }
    }
}
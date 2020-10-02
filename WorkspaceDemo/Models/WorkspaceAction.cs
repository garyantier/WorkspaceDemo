using System;

namespace WorkspaceDemo.Models
{
    public class WorkspaceAction
    {
        public Guid ActionId { get; set; }
        public string ActionName { get; set; }
        public bool IsModal { get; set; }
        public string ModalSource { get; set; }
    }
}
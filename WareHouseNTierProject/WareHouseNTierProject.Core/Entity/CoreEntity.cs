using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseNTierProject.Core.Enum;

namespace WareHouseNTierProject.Core.Entity
{
    public class CoreEntity:IEntity
    {
        public CoreEntity()
        {
            this.Status = Status.Active;
            this.CreateDate = DateTime.Now;
            this.CreatedComputerName = Environment.MachineName;
            this.CreatedUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.CreatedIP = "";
        }

        public Guid ID { get; set; }
        public Guid MasterID { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedUserName { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedIP { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedUserName { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedIP { get; set; }
        public Status Status { get; set; }
    }
}

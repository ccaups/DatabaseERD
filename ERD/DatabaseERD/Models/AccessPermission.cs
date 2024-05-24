using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseERD.Models
{
    public class AccessPermission
    {
        [Key]
        public Guid AccessPermissionsID { get; set; }

        public Guid EmployeeID { get; set; }

        public string AccessLevels { get; set; }


    }
}
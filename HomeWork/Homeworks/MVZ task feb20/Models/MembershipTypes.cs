using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MVZ_task_feb20.Models
{
    public class MembershipTypes
    {
        public string? MembershipTypeName { get; set; }

        [Key]
        public int MembershipTypeId { get; set; }

    }
}

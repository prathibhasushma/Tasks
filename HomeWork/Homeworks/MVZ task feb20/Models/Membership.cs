using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVZ_task_feb20.Models
{
    public class Membership
    {
        [Key]
        public int MembershipId { get; set; }

        [ForeignKey("Customer")]

        public int CustomerId { get; set; }

        public Customer? cust { get; set; }

        public string? MembershipName { get; set; }


        [ForeignKey("MembershipTypes")]
        public int? MembershipTypeId { get; set; }

        public MembershipTypes? membershipTypes { get; set; }

    }
}


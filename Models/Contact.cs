using System.ComponentModel.DataAnnotations.Schema;

namespace SelfReference.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public virtual List<Relationship> Relationships { get; set; } = new List<Relationship>();

        //[InverseProperty(nameof(Relationship.ParentId))]
        //public virtual ICollection<Relationship> Parent { get; set; }

        //[InverseProperty(nameof(Relationship.ChildId))]
        //public virtual ICollection<Relationship> Child { get; set; }
    }
}

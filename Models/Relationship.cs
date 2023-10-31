using System.ComponentModel.DataAnnotations.Schema;

namespace SelfReference.Models
{
    public class Relationship
    {
        public int Id { get; set; }


        //public int ParentId { get; set; }
        //public virtual Contact? Parent { get; set; }

        //public int ChildId { get; set; }
        //public virtual Contact? Child { get; set; }

        //[ForeignKey(nameof(Parent)), Column(Order = 0)]
        public int? ParentId { get; set; }
        public virtual Contact? Parent { get; set; }


        //[ForeignKey(nameof(Child)), Column(Order = 1)]
        public int? ChildId { get; set; }
        public virtual Contact? Child { get; set; }

        // foreign key

        public int? RelationshipId { get; set; }
        public virtual Relationship? Relationships { get; set; }
    }
}

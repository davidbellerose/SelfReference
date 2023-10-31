namespace SelfReference.Models
{
    public class RelationshipType
    {
        public int Id { get; set; }
        public string? Type { get; set; }



        // I use List instead of ICollection in order to itereate through the list
        // using an array index in the todo index view
        public virtual List<Relationship> Relationships { get; set; } = new List<Relationship>();
    }
}

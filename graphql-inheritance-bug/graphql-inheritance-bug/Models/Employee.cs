namespace graphql_inheritance_bug.Models
{
    using GraphQL.AspNet.Attributes;

    public class Employee : Person
    {
        public string FullName => $"{this.FirstName} {this.LastName}";
    }
}
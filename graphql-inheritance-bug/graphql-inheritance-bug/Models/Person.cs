namespace graphql_inheritance_bug.Models
{
    using GraphQL.AspNet.Attributes;

    public class Person
    {
        protected int _hardCodedBirthDay = 2000;

        // This Method based field DOES NOT
        // show up on Employee
        [GraphField("AgeOnDate")]
        public int AgeInYear(int year)
        {
            return year - _hardCodedBirthDay; ;
        }


        public string FirstName { get; set; }

        // This property based field DOES show up on Employee
        [GraphField("Surname")]
        public string LastName { get; set; }
    }
}

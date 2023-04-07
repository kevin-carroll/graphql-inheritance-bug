namespace graphql_inheritance_bug.Controllers
{
    using GraphQL.AspNet.Attributes;
    using GraphQL.AspNet.Controllers;
    using graphql_inheritance_bug.Models;

    public class EmployeeController : GraphController
    {
        [QueryRoot("retrieveEmployee")]
        public Employee RetrieveEmployee()
        {
            var emp = new Employee()
            {
                FirstName = "Bob",
                LastName = "Smith",
            };

            return emp;
        }
    }
}
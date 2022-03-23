using RestApi.Model;

namespace RestApi.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> listPerson = new List<Person>();
            for (int i = 0; i < 4; i++)           
                listPerson.Add(MockPerson());

            return listPerson;
        }

        public Person FindById(long id)
        {
            return MockPerson();
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson()
        {
            var id = new Random().NextInt64(100);
            return new Person()
            {
                Id = id,
                FirstName = "Mock FirtName " + id,
                LastName = "Mock LastName " + id,
                Address = "Mock Address " + id,
                Gender = "Mock Gender"
            };
        }
    }
}

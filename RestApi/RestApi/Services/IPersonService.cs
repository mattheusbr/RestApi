using RestApi.Model;

namespace RestApi.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        void Delete(Person person);
        Person FindById(long id);
        List<Person> FindAll();

    }
}

using IAmHere.Web.Models.Person;

namespace IAmHere.Web.Services
{
    public interface IPersonService
    {
        List<PersonModel> GetPersons();
    }
}

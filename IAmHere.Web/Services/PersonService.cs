using IAmHere.Web.Models.Person;

namespace IAmHere.Web.Services
{
    public class PersonService:IPersonService
    {
        public List<PersonModel> GetPersons()
        {

            

            
            var person = new PersonModel
            {
                Id = 1,
                FirstName = "يف",
                LastName = "تانجوي",
                Age = 30,
                Gender = "ذكر",
                LastSeenDate = DateTime.Now.AddDays(-5),
                Location = "مكان ما",
                Description = "وصف ما",
                CaseDetails = "تفاصيل الحالة",
                ClothingDescription = "وصف الملابس",
                HeightCM = 180,
                WeightKG = 75,
                HairColor = "أسود",
                EyeColor = "بني",
                PhotoPath = "مسار/إلى/الصورة",
                Contact = "1234567890",
                CaseStatus = "مفقود"
            };
            var person2 = new PersonModel
            {
                Id = 2,
                FirstName = "ليلى",
                LastName = "خان",
                Age = 25,
                Gender = "أنثى",
                LastSeenDate = DateTime.Now.AddDays(-10),
                Location = "مدينة الرياض",
                Description = "شابة هادئة تعاني من القلق",
                CaseDetails = "تم رؤيتها آخر مرة في حي النسيم",
                ClothingDescription = "ترتدي قميصًا أبيض وبنطلون أسود",
                HeightCM = 165,
                WeightKG = 60,
                HairColor = "بني",
                EyeColor = "أخضر",
                PhotoPath = "مسار/إلى/الصورة2",
                Contact = "9876543210",
                CaseStatus = "مفقودة"
            };

            var person3 = new PersonModel
            {
                Id = 3,
                FirstName = "علي",
                LastName = "خان",
                Age = 40,
                Gender = "ذكر",
                LastSeenDate = DateTime.Now.AddDays(-15),
                Location = "مدينة جدة",
                Description = "رجل مرح يحب المغامرات",
                CaseDetails = "تم العثور على سيارته متروكة بجوار الطريق",
                ClothingDescription = "يحمل قميصًا أسود وبنطلون جينز",
                HeightCM = 175,
                WeightKG = 80,
                HairColor = "رمادي",
                EyeColor = "أزرق",
                PhotoPath = "مسار/إلى/الصورة3",
                Contact = "5678901234",
                CaseStatus = "مفقود"
            };

            var person4 = new PersonModel
            {
                Id = 4,
                FirstName = "مريم",
                LastName = "أحمد",
                Age = 35,
                Gender = "أنثى",
                LastSeenDate = DateTime.Now.AddDays(-20),
                Location = "مكة المكرمة",
                Description = "امرأة متفتحة ومحبة للسفر",
                CaseDetails = "كانت في طريقها لزيارة الحرم الشريف",
                ClothingDescription = "ترتدي فستانًا أبيض وحجاب أسود",
                HeightCM = 160,
                WeightKG = 70,
                HairColor = "أشقر",
                EyeColor = "بني",
                PhotoPath = "مسار/إلى/الصورة4",
                Contact = "6789012345",
                CaseStatus = "مفقودة"
            };

            var person5 = new PersonModel
            {
                Id = 5,
                FirstName = "حسين",
                LastName = "خليل",
                Age = 50,
                Gender = "ذكر",
                LastSeenDate = DateTime.Now.AddDays(-25),
                Location = "الدمام",
                Description = "رجل هادئ يعمل في مجال البناء",
                CaseDetails = "فقدت أثاره بعد خروجه من العمل",
                ClothingDescription = "يرتدي قميصًا أزرق وبنطلون أسود",
                HeightCM = 170,
                WeightKG = 85,
                HairColor = "أسود",
                EyeColor = "بني",
                PhotoPath = "مسار/إلى/الصورة5",
                Contact = "7890123456",
                CaseStatus = "مفقود"
            };
            var person6 = new PersonModel
            {
                Id = 6,
                FirstName = "John",
                LastName = "Doe",
                Age = 40,
                Gender = "Male",
                LastSeenDate = DateTime.Now.AddDays(-30),
                Location = "New York",
                Description = "Lorem ipsum dolor sit amet...",
                CaseDetails = "Lorem ipsum dolor sit amet...",
                ClothingDescription = "Lorem ipsum dolor sit amet...",
                HeightCM = 175,
                WeightKG = 80,
                HairColor = "Black",
                EyeColor = "Brown",
                PhotoPath = "/path/to/photo6.jpg",
                Contact = "9876543210",
                CaseStatus = "Missing"
            };

            var personList = new List<PersonModel>
            {
                person,
                person2,
                person3,
                person4,
                person5,
                person6
            };

           
            

            
            return personList;
        }
    }
}

using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
//süslü parantez açmazsak sadece tek satır yazabiliriz. 
if (isAuthenticated)
    Console.WriteLine("Buton --> Hoşgeldin Görkem");
else Console.WriteLine("Buton --> Sisteme giriş yap!");

string[] loans =
{
    "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6"
};//dB'den gelecek. 

/*
string[] loans2 = new string[6];
loans2[0] = "Kredi 1";
*/
        // start    condition   increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new(new EfCourseDal());
List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

Console.WriteLine("Kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "1233456788910";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "1233456788911";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

string[] cities1 =
{
    "Ankara", "İstanbul", "İzmir"
};
string[] cities2 =
{
    "Bursa", "Bolu", "Diyarbakır"
};

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

//value types --> int, bool, double...
//reference types --> array, class, interface...

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };


//polymorphism
foreach (var customer in customers)
{  
    Console.WriteLine(customer.CustomerNumber);

}


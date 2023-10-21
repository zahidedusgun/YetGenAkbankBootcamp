using Freelancer.Entities;
using Freelancer.Services;
using FreelancerApp.Abstract;
using FreelancerApp.Entities;

Console.WriteLine("FreelancerApp");


ICsvConvertible freelancerInstance = new Freelancer.Entities.Freelancer()
{
    Id = Guid.NewGuid(),          
    CreatedOn = DateTime.Now,    
    FirstName = "FreelancerTestName",
    LastName = "FreelancerTestName",
    WorkExperience = "10years",
    Reviews = new List<Review>
    {
        new Review { Text = "Bad", Rating = 1 },
        new Review { Text = "Perfect", Rating = 5 }
    }
};

var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(),          
    CreatedOn = DateTime.Now,    
    FirstName = "CustomerTestName",
    LastName = "CustomerTestSurname",
    PhoneNumber = "11-22-33" 
};

NotepadService notepadService = new();

string customerData = notepadService.GetOnNotepad("C:\\Users\\Zahide Düşgün\\Desktop\\AkbankYetGenJump\\FreelancerApp\\FreelancerApp\\Database\\Customer.txt");

string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}
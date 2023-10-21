using CalenderApp.Entities;

Console.WriteLine("Calender App");

Meeting meeting1 = new()
{
    Title = "Title Test",
    Details = new List<string>() { "Details Test" },
    StartTime = new DateTime(2023, 09, 18, 19, 00, 00),
    FinishTime = new DateTime(2023, 09, 18, 20, 00, 00),
    Guests = new() { "zahide@gmail.com", "test@gmail.com" },
};

Todo todo1 = new()
{
    Title = "Title Test",
    Details = new List<string>() { "Details Test" },
    StartTime = new DateTime(2023, 09, 18, 19, 00, 00),
    FinishTime = new DateTime(2023, 09, 18, 20, 00, 00),
    Importance = "Test Importance"
};

meeting1.GetNotification();
todo1.GetNotification();
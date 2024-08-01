using ConsoleApp1;
List<DateTime> julyDays = new List<DateTime>();

for (int day = 1; day <= 31; day++)
{
    DateTime date = new DateTime(2024, 7, day); // Ano 2023, mês de julho
    var blabla = new Apontamento(date, "blabla");
    julyDays.Add(date);
}

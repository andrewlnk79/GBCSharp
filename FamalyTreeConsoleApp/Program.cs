using FamilyTreeConsoleApp.Enum;

namespace FamilyTreeConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        FamilyMamber GrandFather1 = new()
        {
            Name = "Николай Иванов",
            Age = 65,
            Gender = Gender.male
        };
        FamilyMamber grandFather2 = new()
        {
            Name = "Петр",
            Surname = "Петров",
            Age = 55,
            Gender = Gender.male
        };
        FamilyMamber grandMother1 = new FamilyMamber()
        {
            Name = "Любовь",
            Surname = "Иванова",
            Age = 60,
            Gender = Gender.female
        };
        FamilyMamber grandMother2 = new FamilyMamber()
        {
            Name = "Лариса",
            Surname = "Петрова",
            Age = 54,
            Gender = Gender.female
        };
        FamilyMamber Father = new FamilyMamber()
        {
            Name = "Сергей",
            Surname = "Иванов",
            Age = 35,
            Gender = Gender.male,
            Married = true,
            children = true,
            Father = GrandFather1,
            Mother = grandMother1
        };
        FamilyMamber Mother = new FamilyMamber()
        {
            Name = "Татьяна",
            Surname = "Иванова",
            Age = 30,
            Gender = Gender.female,
            Married = true,
            children = true,
            Mother = grandMother2,
            Father = grandFather2
        };
        FamilyMamber Son = new()
        {
            Name = "Антон",
            Surname = "Иванов",
            Age = 19,
            Gender = Gender.male,
            Father = Father,
            Mother = Mother
        };
        var grandMa = Son.GetGrandMothers();
        var grandPa = Son.GetGrandFathers();
        Console.WriteLine("Дедушки и бабушки:");
        Console.WriteLine(grandMa[0]?.Name + " " + grandMa[0]?.Surname + " \n" + grandPa[0]?.Name +
                          grandPa[0]?.Surname);
        Console.WriteLine(grandMa[1]?.Name + " " + grandMa[1]?.Surname + " \n" + grandPa[1]?.Name + " " +
                          grandPa[1]?.Surname);
        Console.WriteLine("Женаты:");
        List<FamilyMamber> family = new();
        family.Add(Mother);
        family.Add(Father);
        family.Add(Son);
        var husband = family.FirstOrDefault(h => h.Gender == Gender.male && h.Married && h.Age >= 20 && h.children);
        Console.WriteLine($"Муж:{husband.Name} {husband.Surname}");
        var wife = family.FirstOrDefault(w => w.Gender == Gender.female && w.Married && w.Age >= 20 && w.children);
        Console.WriteLine($"Жена:{wife.Name} {wife.Surname}");
    }
}

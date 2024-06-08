namespace FamilyTreeConsoleApp;

internal class Program
    {
    static void Main(string[] args)
        {
        FamilyMamber GrandFather1 = new FamilyMamber()
            {
            Name = "Николай Иванов",
            Age = 65,
            Gender = Gender.male
            };
        FamilyMamber GrandFather2 = new FamilyMamber()
            {
            Name = "Петр",
            Surname = "Петров",
            Age = 55,
            Gender = Gender.male

            };
        FamilyMamber GrandMother1 = new FamilyMamber()
            {
            Name = "Любовь",
            Surname = "Иванова",
            Age = 60,
            Gender = Gender.female
            };
        FamilyMamber GrandMother2 = new FamilyMamber()
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
            Mother = GrandMother1
            };
        FamilyMamber Mother = new FamilyMamber()
            {
            Name = "Татьяна",
            Surname = "Иванова",
            Age = 30,
            Gender = Gender.female,
            Married = true,
            children = true,
            Mother = GrandMother2,
            Father = GrandFather2
            };
        FamilyMamber Son = new FamilyMamber()
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
        Console.WriteLine("Дедушки и бабушки:\n");
        Console.WriteLine(grandMa[0]?.Name + " " + grandMa[0]?.Surname + " \n" + grandPa[0]?.Name +
                          grandPa[0]?.Surname + " \n");
        Console.WriteLine(grandMa[1]?.Name + " " + grandMa[1]?.Surname + " \n" + grandPa[1]?.Name + " " +
                          grandPa[1]?.Surname + " \n");
        Console.WriteLine("Женаты:");
        List<FamilyMamber> famaly = new List<FamilyMamber>();
        famaly.Add(Mother);
        famaly.Add(Father);
        famaly.Add(Son);
        var husband = famaly.FirstOrDefault(h => h.Gender == Gender.male && h.Married && h.Age >= 20 && h.children);
        Console.WriteLine($"Муж:{husband.Name} {husband.Surname}");
        var wife = famaly.FirstOrDefault(w => w.Gender == Gender.female && w.Married && w.Age >= 20 && w.children);
        Console.WriteLine($"Жена:{wife.Name} {wife.Surname}");






        }








    }













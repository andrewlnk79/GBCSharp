namespace FamalyTreeConsoleApp;

internal class Program
    {
    static void Main(string[] args)
        {
        FamalyMamber GrandFather1 = new FamalyMamber()
            {
            FullName = "Николай Иванов",
            Age = 65,
            Gender = Gender.male
            };
        FamalyMamber GrandFather2 = new FamalyMamber()
            {
            FullName = "Петр Петров",
            Age = 55,
            Gender = Gender.male

            };
        FamalyMamber GrandMother1 = new FamalyMamber()
            {
            FullName = "Любовь Иванова",
            Age = 60,
            Gender = Gender.female
            };
        FamalyMamber GrandMother2 = new FamalyMamber()
            {
            FullName = "Лариса Петрова",
            Age = 54,
            Gender = Gender.female
            };
        FamalyMamber Father = new FamalyMamber()
            {
            FullName = "Сергей Иванов",
            Age = 35,
            Gender = Gender.male,
            Father = GrandFather1,
            Mother = GrandMother1
            };
        FamalyMamber Mother = new FamalyMamber()
            {
            FullName = "Татьяна Иванова",
            Age = 30,
            Gender = Gender.female,
            Mother = GrandMother2,
            Father = GrandFather2
            };
        FamalyMamber Son = new FamalyMamber()
            {
            FullName = "Антон Иванов",
            Age = 19,
            Gender = Gender.male,
            Father = Father,
            Mother = Mother
            };
        var grandMa = Son.GetGrandMothers();
        var grandPa = Son.GetGrandFathers();
        Console.WriteLine(grandMa[0]?.FullName + " \n" + grandPa[0]?.FullName);



        }



    }


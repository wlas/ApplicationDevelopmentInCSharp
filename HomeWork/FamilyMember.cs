namespace HomeWork
{
    public class FamilyMember : Human
    {
        private FamilyMember _father;
        private FamilyMember _mother;
        private List<FamilyMember> _childs;
        private FamilyMember _spouse;

        public FamilyMember(string name, Gender sex, DateOnly birthday) : base(name, sex, birthday)
        {
            _childs = new List<FamilyMember>();
        }
        public void AddSpouse(FamilyMember spouse)
        {
            _spouse = spouse;
        }


        public void AddChild(FamilyMember child)
        {
            _childs.Add(child);
        }

        public void SetParents(FamilyMember father, FamilyMember mother)
        {
            _father = father;
            _mother = mother;
        }

        public void PrintFamily()
        {
            Console.WriteLine(this.ToString());

            Console.WriteLine("Мать:");
            Console.WriteLine(_mother is null ? "None" : _mother.ToString());

            Console.WriteLine("Отец:");
            Console.WriteLine(_father is null ? "None" : _father.ToString());

            Console.WriteLine("Брат:");

            if (_childs is not null && _childs.Count > 1)
            {
                foreach (FamilyMember child in _childs)
                {
                    if (child.GetGender() == Gender.Male)
                    {
                        Console.WriteLine(child.ToString());
                    }
                }

                Console.WriteLine("Сестра:");

                foreach (FamilyMember child in _childs)
                {
                    if (child.GetGender() == Gender.Female)
                    {
                        Console.WriteLine(child.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Бабаушки и дедушки:");

            if (_father is not null)
            {
                Console.WriteLine(_father._mother is not null ? _father._mother.ToString() : "None");
                Console.WriteLine(_father._father is not null ? _father._father.ToString() : "None");
            }

            if (_mother is not null)
            {
                Console.WriteLine(_mother._mother is not null ? _mother._mother.ToString() : "None");
                Console.WriteLine(_mother._father is not null ? _mother._father.ToString() : "None");
            }
        }

        public override string ToString()
        {
            return $"{GetName}";
        }

        public static void PrintTree(FamilyMember person)
        {
            Console.WriteLine($"{person.GetName} генеалогическое древо:");
            PrintPerson(person);
        }

        private static void PrintPerson(FamilyMember person)
        {
            string wife = person._spouse is null ? "" : $" и жена {person._spouse.ToString()}";


            Console.WriteLine($"{person}{wife}");

            if (person._childs.Count > 0)
            {
                Console.Write("Дети: ");

                foreach (var child in person._childs)
                {
                    Console.Write($"{child.ToString()} ");
                }

            }


            Console.WriteLine();

            if (person._childs.Count > 0)
            {
                foreach (FamilyMember child in person._childs)
                {
                    if (child.GetGender() == Gender.Male && child._childs.Count > 0)
                    {
                        PrintPerson(child);
                    }
                }
            }
        }

    }
}

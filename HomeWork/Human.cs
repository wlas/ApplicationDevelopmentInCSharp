namespace HomeWork
{
    public class Human
    {
        private string _name;
        private Gender _sex;
        private DateOnly _birthday;
      
        public Human(string name, Gender sex, DateOnly birthday)
        {
            _name = name;
            _sex = sex;
            _birthday = birthday;
        }
        public Gender GetGender() => _sex;
        public string GetName => _name;
        public DateOnly GetBirthday() => _birthday;
        public override string ToString()
        {
            return $"Имя = {_name}\nПол = {_sex}\nДата рождения = {_birthday}";

        }

    }
}

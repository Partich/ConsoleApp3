namespace ConsoleApp3
{
    public class Princess
    {
        private string _index;
        public string Index
        {
            get => _index;
            set
            {
                if (int.Parse(value) <= 0)
                {
                    throw new ArgumentException("Индес должен быть больше нуля");
                }

                _index = value.Trim();
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 1 || value.Length > 30)
                {
                    throw new ArgumentException("Длина имени должны бать больше 1 и меньше 30 символов");
                }
                

                _name = value.Trim();
            }
        }

        private string _age;
        public string Age
        {
            get => _age;
            set
            {
                var age = int.Parse(value);

                if (age < 0 && age > 99)
                {
                    throw new ArgumentException("Возраст должен быть больше 0 и меньше 99");
                }

                _age = value.Trim();
            }
        }

        private string _hairColor;
        public string HairColor
        {
            get => _hairColor;
            set
            {
                var age = PrincessCharacteristics.HairColor.Parse<PrincessCharacteristics.HairColor>(value);
                _hairColor = value.Trim();
            }
        }

        private string _eyesColor;
        public string EyesColor
        {
            get => _eyesColor;
            set
            {
                var age = PrincessCharacteristics.EyesColor.Parse<PrincessCharacteristics.EyesColor>(value);
                _eyesColor = value.Trim();
            }
        }

        public override string ToString()
        {
            return $"{Name}\n" +
                $"Age: {Age}\n" +
                $"Hair: {HairColor}\n" +
                $"Eyes: {EyesColor}\n";
        }       
    }
}

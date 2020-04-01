using System;


namespace Fitness.BL.Model
{
    public class Gender
    {
        public string Name { get; }
       /// <summary>
       /// Создать новый пол
       /// </summary>
       /// <param name="name">имя пола</param>
        public Gender(string name) 
        {
            if (string.IsNullOrWhiteSpace(name)) 
            {
                throw new ArgumentNullException("Имя пола не может быть пустым", nameof(name));
            }

            Name = name;

        }
        public override string ToString()
        {
            return Name;
        }

    }
}

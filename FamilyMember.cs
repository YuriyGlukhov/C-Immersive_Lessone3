using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FamilyMembers
{
    public enum Gender { male, female }
    public class FamilyMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public FamilyMember Father { get; set; }
        public FamilyMember Mother { get; set; }

        public FamilyMember BrotherOrSister { get; set; } //добавление братьев и сестер


        public FamilyMember Spouse { get; set; } // добавление супругов
        public FamilyMember[] Children { get; set; } // добавление детей



        public FamilyMember[] GetGranMotherName()
        {
            return new FamilyMember[] { Mother.Mother, Father.Mother };
        }
        public FamilyMember[] GetGranFatherName()
        {
            return new FamilyMember[] { Mother.Father, Father.Father };
        }

        public void MyDisplayFam()
        {
            DisplayGrandParents();
            DisplayParents();
            DisplayClidrenParrents();

            DisplaySpouse();
            DisplayChildren();


            
        }

        public void DisplayGrandParents()
        {

            string paternalGrandFather = Father?.Father != null ? $"{Father.Father.Name}, {Father.Father.Age}, {Father.Father.Gender}" : "Дедушка по отцу: Неизвестен";
            string paternalGrandMother = Father?.Mother != null ? $"{Father.Mother.Name}, {Father.Mother.Age}, {Father.Mother.Gender}" : "Бабушка по отцу: Неизвестна";
            string maternalGrandFather = Mother?.Father != null ? $"{Mother.Father.Name}, {Mother.Father.Age}, {Mother.Father.Gender}" : "Дедушка по матери: Неизвестен";
            string maternalGrandMother = Mother?.Mother != null ? $"{Mother.Mother.Name}, {Mother.Mother.Age}, {Mother.Mother.Gender}" : "Бабушка по матери: Неизвестна";

            Console.WriteLine($"{new string(' ', 10)}Дедушка по отцу: {new string(' ', 18)}Бабушка по отцу:{new string(' ', 35)}Дедушка по матери{new string(' ', 18)}Бабушка по матери");
            Console.WriteLine($"|{paternalGrandFather}|----|{paternalGrandMother}|{new string(' ', 9)}|{maternalGrandFather}|----|{maternalGrandMother}|");

        }

        public void DisplayParents()
        {

            string fatherInfo = Father != null ? $"{Father.Name}, {Father.Age}, {Father.Gender}" : "Отец: Неизвестен";
            string motherInfo = Mother != null ? $"{Mother.Name}, {Mother.Age}, {Mother.Gender}" : "Мать: Неизвестна";

            Console.WriteLine($"{new string(' ', 34)}|{new string(' ', 85)}|");
            Console.WriteLine($"{new string(' ', 32)}Отец: {new string(' ', 81)}Мать:");
            Console.WriteLine($"{new string(' ', 18)}|{fatherInfo}|{new string('-', 51)}|{motherInfo}|");
        }

        public void DisplayClidrenParrents()
        {
            if (BrotherOrSister != null)
            {

               
                Console.WriteLine($"{new string(' ', 54)}|{new string(' ', 42)}|");
                Console.WriteLine($"{new string(' ', 50)}Наш member{new string(' ', 32)}Брат/Сестра");
                Console.WriteLine($"{new string(' ', 37)}**{Name},{Age},{Gender}**{new string(' ', 7)}|{BrotherOrSister.Name},{BrotherOrSister.Age},{BrotherOrSister.Gender}|");
            }
            else
            {
                Console.WriteLine($"{new string(' ', 54)}|{new string(' ', 42)}|");
                Console.WriteLine($"{new string(' ', 50)}Наш member{new string(' ', 32)}Брат/Сестра");
                Console.WriteLine($"{new string(' ', 37)}**{Name},{Age},{Gender}**{new string(' ', 17)}|Неизвестно|");
            }
           
        }

        public void DisplaySpouse()
        {

            if (Spouse != null)
            {
                Console.WriteLine($"{new string(' ', 35)}|{new string(' ', 18)}|");
                Console.WriteLine($"{new string(' ', 30)}Супруг(а){ new string(' ', 15)}|");
                Console.WriteLine($"{new string(' ', 15)}|{Spouse.Name}, {Spouse.Age}, {Spouse.Gender}|{new string(' ', 1)}|");
            }
            else
            {
                Console.WriteLine($"{new string(' ', 35)}|{new string(' ', 18)}|");
                Console.WriteLine($"{new string(' ', 30)}Супруг(а){new string(' ', 15)}|");
                Console.WriteLine($"{new string(' ', 30)}Неизвестно{new string(' ', 14)}|");
            }
        }
        public void DisplayChildren()
        {
           
            if (Children != null && Children.Length > 0)
            {
                Console.WriteLine($"{new string(' ', 54)}|");
                Console.WriteLine($"{new string(' ', 53)}Дети:");
                
                foreach (var child in Children)
                {
                    Console.WriteLine($"{new string(' ', 40)}{child.Name}, {child.Age}, {child.Gender}");
                }
            }
            else
            {
                Console.WriteLine($"{new string(' ', 54)}|");
                Console.WriteLine($"{new string(' ', 53)}Дети:");
                Console.WriteLine($"{new string(' ', 50)}|Неизвестно|");


            }
        }
    }

}




















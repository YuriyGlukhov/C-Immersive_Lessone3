using System;
using System.Linq.Expressions;
using FamilyMembers;

namespace C_Immersive_Seminar1_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyMember grandFatrher_1 = new FamilyMember()
            {
                Name = "Мухов Олег Витальевич",
                Age = 61,
                Gender = Gender.male,
              
            };

            FamilyMember grandFatrher_2 = new FamilyMember()
            {
                Name = "Шушукин Борис Юрьевич",
                Age = 63,
                Gender = Gender.male
            };

            FamilyMember grandMother_1 = new FamilyMember()
            {
                Name = "Мухова Валентина Евгеневна",
                Age = 59,
                Gender = Gender.female
            };

            FamilyMember grandMother_2 = new FamilyMember()
            {
                Name = "Шушукина Роза Олеговна",
                Age = 66,
                Gender = Gender.female
            };

            FamilyMember father = new FamilyMember()
            {
                Name = "Мухов Кирилл Олегович",
                Age = 45,
                Gender = Gender.male,
                Mother = grandMother_1,
                Father = grandFatrher_1,
              
            };
            FamilyMember mother = new FamilyMember()
            {
                Name = "Мухова Татьяна Борисовна",
                Age = 43,
                Gender = Gender.female,
                Mother = grandMother_2,
                Father = grandFatrher_2,
                
            };

            FamilyMember brother = new FamilyMember()
            {
                Name = "Мухов Вдалислав Кириллович",
                Age = 15,
                Gender = Gender.male,
                Mother = mother,
                Father = father,
            };
            FamilyMember wife = new FamilyMember()
            {
                Name = "Тестовая Жена Тестововна",
                Age = 20,
                Gender = Gender.female,
               
            };

            FamilyMember member = new FamilyMember()
            {
                Name = "Мухов Александр Кириллович",
                Age = 21,
                Gender = Gender.male,
                Mother = mother,
                Father = father,
            };
            FamilyMember Son = new FamilyMember()
            {
                Name = "Мухов Олег Александрович",
                Age = 2,
                Gender = Gender.male,
                Mother = wife,
                Father = member
            };

            member.BrotherOrSister = brother;
            member.Children = new FamilyMember[] {Son };
            member.Spouse = wife;


            member.MyDisplayFam();



            Console.ReadKey();


        }
    }
}

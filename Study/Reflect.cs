using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Study
{
    internal class Reflect
    {
        /// <summary>
        /// Показать члены класса. Приватных нет
        /// </summary>
        /// <param name="nameClass"></param>
        public static void ShowMemberInfoName(string nameClass)
        {
            Type type = Type.GetType("Study." + nameClass);

            var members = type.GetMembers();


            foreach (MemberInfo memberInfo in members)
            {
                Console.WriteLine(memberInfo.Name);
            }
        }

        /// <summary>
        /// Показать приватные экземплярные члены
        /// </summary>
        /// <param name="nameClass"></param>
        public static void ShowMemberInfoNameNonPublicORInstance(string nameClass)
        {
            Type type = Type.GetType("Study." + nameClass);

            var members = type.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic);


            foreach (MemberInfo memberInfo in members)
            {
                Console.WriteLine(memberInfo.Name);
            }
        }

        /// <summary>
        /// Изменяет приватное поле _temp для нового экземпляра класса
        /// </summary>
        public static void ChangeField()
        {
            Student student = new Student();

            Type type = student.GetType();

            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo fieldInfo in fields)
            {
                if (fieldInfo.Name == "_temp")
                {
                    var value = fieldInfo.GetValue(student);
                    Console.WriteLine($"Before: {value}");

                    fieldInfo.SetValue(student, 15);

                    value = fieldInfo.GetValue(student);
                    Console.WriteLine($"After: {value}");


                }
            }
        }

    }
}

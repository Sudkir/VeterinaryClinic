using System;

namespace Sudarikov3ISP1113.MyClass
{
    internal class ClassRole
    {
        //сохранять данные о пользователе и его роли через Singleton Class

        private ClassRole()
        {
        }

        private static readonly Lazy<ClassRole> instance = new Lazy<ClassRole>(() => new ClassRole());
        public static ClassRole Instance { get { return instance.Value; } }
        public int UserRoleInstance { get; set; }

        public int UserIdInstance { get; set; }
    }
}
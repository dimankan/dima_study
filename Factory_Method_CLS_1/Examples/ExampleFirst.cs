using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_CLS_1.Examples
{
    #region 1-ый абстрактный -- Аналог Creator
    // абстрактный класс строительной компании
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public House Create();
    }
    #endregion
    #region 2 реализации 1-ого абстрактного
    // строит панельные дома
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
    // строит деревянные дома
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    #endregion

    #region 2-ой абстрактный класс -- Аналог Product
    abstract class House
    { }
    #endregion
    #region 2 реализации 2-ого абстрактного класса
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
    #endregion

    #region Добавил как пример

    class HayDeveloper : Developer
    {
        public HayDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new HayHouse();
        }
    }

    class HayHouse : House
    {
        public HayHouse()
        {
            Console.WriteLine("Соломенный дом построен");
        }
    }
    #endregion

}

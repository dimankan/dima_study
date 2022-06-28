using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    #region 0. Client -- Точка входа
    class Client
    {
        //private AbstractProductA abstractProductA;
        //private AbstractProductB abstractProductB;

        public AbstractProductA abstractProductA;
        public AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }
        public void Run()
        { }
    } 
    #endregion


    #region 1.1. Абстрактный класс Создателей/Creator/Developer/Factory
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    } 
    #endregion

    #region 1.2. Реализация абстрактного класса типа Создатель/Creator/Developer/Factory
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    #endregion


    #region   2.1. Абстрактные классы Продуктов/Product/House
    abstract class AbstractProductA
    { }

    abstract class AbstractProductB
    { }
    #endregion

    #region 2.2. Реализация абстрактных классов Продуктов/Product/House
    class ProductA1 : AbstractProductA
    { }

    class ProductB1 : AbstractProductB
    { }

    class ProductA2 : AbstractProductA
    { }

    class ProductB2 : AbstractProductB
    { } 
    #endregion

}

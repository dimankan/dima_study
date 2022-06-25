using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_CLS_1
{

    #region 1. Абстрактный класс Product определяет интерфейс класса, объекты которого надо создавать.
    abstract class Product
    { }
    #endregion


    #region 2. Конкретные классы ConcreteProductA и ConcreteProductB представляют реализацию класса Product. Таких классов может быть множество
    class ConcreteProductA : Product
    { }

    class ConcreteProductB : Product
    { }
    #endregion

    #region 3. Абстрактный класс Creator определяет абстрактный фабричный метод FactoryMethod(), который возвращает объект Product.
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
    #endregion

    #region 4. Конкретные классы ConcreteCreatorA и ConcreteCreatorB - наследники класса Creator, определяющие свою реализацию метода FactoryMethod(). Причем метод FactoryMethod() каждого отдельного класса-создателя возвращает определенный конкретный тип продукта. Для каждого конкретного класса продукта определяется свой конкретный класс создателя.
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }
    #endregion
}

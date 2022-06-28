using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_CLS_1
{

    #region 1.1. Абстрактный класс Creator определяет абстрактный фабричный метод FactoryMethod(), который возвращает объект Product.
    abstract class AbstractCreator
    {
        public abstract AbstractProduct FactoryMethod();
    }
    #endregion

    #region 1.2. Конкретные классы ConcreteCreatorA и ConcreteCreatorB - наследники класса Creator, определяющие свою реализацию метода FactoryMethod(). Причем метод FactoryMethod() каждого отдельного класса-создателя возвращает определенный конкретный тип продукта. Для каждого конкретного класса продукта определяется свой конкретный класс создателя.
    class ConcreteCreatorA : AbstractCreator
    {
        public override AbstractProduct FactoryMethod() 
        {
            return new ConcreteProductA(); 
        }
    }

    class ConcreteCreatorB : AbstractCreator
    {
        public override AbstractProduct FactoryMethod() 
        { 
            return new ConcreteProductB();
        }
    }
    #endregion
    #region 2.1. Абстрактный класс Product определяет интерфейс класса, объекты которого надо создавать.
    abstract class AbstractProduct
    { }
    #endregion


    #region 2.2. Конкретные классы ConcreteProductA и ConcreteProductB представляют реализацию класса Product. Таких классов может быть множество
    class ConcreteProductA : AbstractProduct
    { }

    class ConcreteProductB : AbstractProduct
    { }
    #endregion

}

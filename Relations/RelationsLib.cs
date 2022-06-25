using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{

    #region Наследование
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Manager : User
    {
        public string Company { get; set; }
    }

    #endregion

    #region Реализация
    public interface IMovable
    {
        void Move();
    }
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
    #endregion

    #region Ассоциация
    class Team
    {

    }
    class Player
    {
        public Team Team { get; set; }
    }
    #endregion

    // Подтипы ассоциации
    #region Композиция

    public class ElectricEngine
    { }

    public class Car1
    {
        ElectricEngine engine;
        public Car1()
        {
            engine = new ElectricEngine();
        }

    }
    #endregion

    #region Агрегация

    public abstract class Engine
    { }

    public class Car2
    {
        Engine engine;
        public Car2(Engine eng)
        {
            engine = eng;
        }
    }
    #endregion


}

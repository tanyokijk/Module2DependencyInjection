using Module2DependencyInjection.Repositories;

namespace Module2DependencyInjection.Entities.EntitiesAnimals;

public class Dog : Animal
{
    public Dog() : base(null)
    {
    }

    public Dog(ILogger logger) : base(logger)
    {
        Name = "Собака";
        Sound = "Гав! Гав! Гав!";
    }
}

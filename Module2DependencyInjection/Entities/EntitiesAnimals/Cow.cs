using Module2DependencyInjection.Repositories;

namespace Module2DependencyInjection.Entities.EntitiesAnimals;

public class Cow : Animal
{
    public Cow() : base(null)
    {
    }

    public Cow(ILogger logger) : base(logger)
    {
        Name = "Корова";
        Sound = "Му! Му! Мууу!";
    }
}

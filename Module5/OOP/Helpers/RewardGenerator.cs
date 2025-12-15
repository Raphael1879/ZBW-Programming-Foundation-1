using OOP.Characters;
using OOP.Interfaces;

namespace OOP.Helpers
{
    public static class RewardGenerator
    {

        public static IItem GetRandomItem()
        {
            var itemType = typeof(IItem);

            var implementations = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t =>
                    itemType.IsAssignableFrom(t) &&
                    !t.IsInterface &&
                    !t.IsAbstract)
                .ToList();

            if (implementations.Count == 0)
                throw new InvalidOperationException("No IItem implementations found");

            var randomType = implementations[Random.Shared.Next(implementations.Count)];

            return (IItem)Activator.CreateInstance(randomType)!;
        }
    }
}

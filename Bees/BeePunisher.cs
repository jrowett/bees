using Bees.Model;

namespace Bees
{
    public interface IPunishBees
    {
        void Punish(IEnumerable<BeeBase> bees);
    }

    public class BeePunisher : IPunishBees
    {
        public void Punish(IEnumerable<BeeBase> bees)
        {
            foreach (var bee in bees)
            {
                var random = new Random();
                var damage = random.Next(80);
                Console.WriteLine($"Inflicting {damage}% damage");
                bee.Damage(damage);
            }
        }
    }
}

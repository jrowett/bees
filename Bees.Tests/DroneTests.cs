using Bees.Model;

namespace Bees.Tests
{
    public class DroneTests
    {
        [Fact]
        public void WhenDamage100_HealthIsZero()
        {
            var bee = new Drone();
            bee.Damage(100);
            Assert.Equal(0, bee.Health);
        }

        [Fact]
        public void WhenDamage0_HealthIs100()
        {
            var bee = new Drone();
            bee.Damage(0);
            Assert.Equal(100, bee.Health);
        }

        [Fact]
        public void OnInit_HealthIs100()
        {
            var bee = new Drone();
            Assert.Equal(100, bee.Health);
        }

        [Fact]
        public void WhenDamage75_HealthIs25()
        {
            var bee = new Drone();
            bee.Damage(75);
            Assert.Equal(25, bee.Health);
        }

        [Fact]
        public void Init_IsAlive()
        {
            var bee = new Drone();
            Assert.False(bee.Dead);
        }

        [Fact]
        public void WhenDamageBelow50_IsDead()
        {
            var bee = new Drone();
            bee.Damage(51);
            Assert.True(bee.Dead);
        }

        [Fact]
        public void WhenDamageAbove50_IsAlive()
        {
            var bee = new Drone();
            bee.Damage(49);
            Assert.False(bee.Dead);
        }

        [Fact]
        public void WhenDead_CannotInflictFurtherDamage()
        {
            var bee = new Drone();
            bee.Damage(51);
            bee.Damage(10);
            Assert.Equal(49, bee.Health);
        }
    }
}
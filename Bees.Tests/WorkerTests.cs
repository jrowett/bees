using Bees.Model;

namespace Bees.Tests
{
    public class WorkerTests
    {
        [Fact]
        public void WhenDamage100_HealthIsZero()
        {
            var bee = new Worker();
            bee.Damage(100);
            Assert.Equal(0, bee.Health);
        }

        [Fact]
        public void WhenDamage0_HealthIs100()
        {
            var bee = new Worker();
            bee.Damage(0);
            Assert.Equal(100, bee.Health);
        }

        [Fact]
        public void OnInit_HealthIs100()
        {
            var bee = new Worker();
            Assert.Equal(100, bee.Health);
        }

        [Fact]
        public void WhenDamage75_HealthIs25()
        {
            var bee = new Worker();
            bee.Damage(75);
            Assert.Equal(25, bee.Health);
        }

        [Fact]
        public void Init_IsAlive()
        {
            var bee = new Worker();
            Assert.False(bee.Dead);
        }

        [Fact]
        public void WhenDamageBelow70_IsDead()
        {
            var bee = new Worker();
            bee.Damage(31);
            Assert.True(bee.Dead);
        }

        [Fact]
        public void WhenDamageAbove70_IsAlive()
        {
            var bee = new Worker();
            bee.Damage(29);
            Assert.False(bee.Dead);
        }

        [Fact]
        public void WhenDead_CannotInflictFurtherDamage()
        {
            var bee = new Worker();
            bee.Damage(31);
            var healthAfterFirstInjury = bee.Health;
            bee.Damage(10);
            Assert.Equal(healthAfterFirstInjury, bee.Health);
        }
    }
}
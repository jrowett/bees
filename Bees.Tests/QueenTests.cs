using Bees.Model;

namespace Bees.Tests
{
    public class QueenTests
    {
        [Fact]
        public void WhenDamage100_HealthIsZero()
        {
            var bee = new Queen();
            bee.Damage(100);
            Assert.Equal(0, bee.Health);
        }

        [Fact]
        public void WhenDamage0_HealthIs100()
        {
            var bee = new Queen();
            bee.Damage(0);
            Assert.Equal(100, bee.Health);
        }

        [Fact]
        public void OnInit_HealthIs100()
        {
            var bee = new Queen();
            Assert.Equal(100, bee.Health);
        }

        [Fact]
        public void WhenDamage75_HealthIs25()
        {
            var bee = new Queen();
            bee.Damage(75);
            Assert.Equal(25, bee.Health);
        }

        [Fact]
        public void Init_IsAlive()
        {
            var bee = new Queen();
            Assert.False(bee.Dead);
        }

        [Fact]
        public void WhenDamageBelow20_IsDead()
        {
            var bee = new Queen();
            bee.Damage(81);
            Assert.True(bee.Dead);
        }

        [Fact]
        public void WhenDamageAbove70_IsAlive()
        {
            var bee = new Queen();
            bee.Damage(79);
            Assert.False(bee.Dead);
        }

        [Fact]
        public void WhenDead_CannotInflictFurtherDamage()
        {
            var bee = new Queen();
            bee.Damage(81);
            var healthAfterFirstInjury = bee.Health;
            bee.Damage(10);
            Assert.Equal(healthAfterFirstInjury, bee.Health);
        }
    }
}
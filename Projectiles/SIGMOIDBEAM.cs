using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SIGMOID.Projectiles
{
    public class SIGMOIDBEAM : ModProjectile
    {

        public override void SetDefaults()
        {
            Projectile.arrow = true;
            Projectile.width = 40;
            Projectile.height = 40;
            Projectile.aiStyle = ProjAIStyleID.Beam;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            AIType = ProjectileID.TerraBeam;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            for (int i = 0; i < 3; i++)
            {
                // Calculate new speeds for other projectiles.
                // Rebound at 40% to 70% speed, plus a random amount between -8 and 8
                float speedX = -Projectile.velocity.X * Main.rand.NextFloat(.4f, .7f) + Main.rand.NextFloat(-8f, 8f);
                float speedY = -Projectile.velocity.Y * Main.rand.Next(40, 70) * 0.01f + Main.rand.Next(-20, 21) * 0.4f; // This is Vanilla code, a little harder to comprehend. This is just here to teach you that you can convert vanilla code to more readable code sometimes.

                // Spawn the Projectile.
                Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.position.X + speedX, Projectile.position.Y + speedY, speedX, speedY, ProjectileID.CrystalShard, (int)(Projectile.damage * 0.5), 0f, Projectile.owner, 0f, 0f);
            }
        }

    }
}

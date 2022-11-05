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
            Projectile.width = 20;
            Projectile.height = 20;
            Projectile.aiStyle = ProjAIStyleID.Bullet;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
            AIType = ProjectileID.bullet;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            for (int i = 0; i < 3; i++)
            {
                float speedX = -Projectile.velocity.X * Main.rand.NextFloat(.4f, .7f) + Main.rand.NextFloat(-8f, 8f);
                float speedY = -Projectile.velocity.Y * Main.rand.Next(40, 70) * 0.01f + Main.rand.Next(-20, 21) * 0.4f;
                Projectile.NewProjectile(Projectile.GetSource_FromThis(),
                                         Projectile.position.X + speedX, Projectile.position.Y + speedY,
                                         speedX, speedY,ModContent.ProjectileType<SIGMOIDBEAM>(),
                                         (int)(Projectile.damage * 0.5),0f, Projectile.owner, 0f, 0f);
            }
        }

    }
}

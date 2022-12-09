using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SIGMOID.Projectiles
{
    public class DestitutionProj : ModProjectile
    {

        public override void SetDefaults()
        {
            Projectile.arrow = true;
            Projectile.width = 20;
            Projectile.height = 20;
            Projectile.aiStyle = 3;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Ranged;
            AIType = 182;
        }
    }
}
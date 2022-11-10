using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SIGMOID.Projectiles
{
	public class Projectile1 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Projectile");
		}

		public override void SetDefaults()
		{
			Projectile.arrow = true;
			Projectile.width = 10;
			Projectile.height = 10;
			Projectile.aiStyle = ProjAIStyleID.Arrow; // or 1
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
			AIType = ProjectileID.WoodenArrowFriendly;
		}

		// Additional hooks/methods here.
	}
}
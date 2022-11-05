using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SIGMOID.Projectiles;

namespace SIGMOID.Items
{
	public class SIGMOIDSWORD : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("it is swag");
		}

		public override void SetDefaults()
		{
			Item.damage = 100;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 10;
			Item.useAnimation = 1;
			Item.useStyle = 1;
			Item.knockBack = 0;
			Item.value = 10000000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<SIGMOIDBEAM>();
			Item.shootSpeed = 10;
        }

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
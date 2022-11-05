using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SIGMOID.Items
{
	public class Reality : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SIGMOID"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("sigmoid sword");
		}

		public override void SetDefaults()
		{
			Item.damage = 10000;
			Item.DamageType = DamageClass.Melee;
			Item.width = 1000;
			Item.height = 1000;
			Item.useTime = 1;
			Item.useAnimation = 1;
			Item.useStyle = 1;
			Item.knockBack = 0;
			Item.value = 10000000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectile1>();
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
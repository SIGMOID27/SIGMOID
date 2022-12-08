using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SIGMOID.Projectiles;

namespace SIGMOID.Items
{
	public class Destitution : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SIGMOID"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Killing machine");
		}

		public override void SetDefaults()
		{


            Item.shootSpeed = 12f;

            Item.width = 28;
            Item.height = 28;
            Item.useStyle = ItemUseStyleID.Shoot;

            Item.DamageType = DamageClass.Ranged;
			Item.useStyle = 5;
            Item.noMelee = true;
            Item.damage = 200;
            Item.knockBack = 3.2f;
			Item.autoReuse = true;
			Item.rare = 5;

            Item.useTime = 3;
            Item.useAnimation = 3;

            Item.UseSound = SoundID.Item71;
			Item.shoot = ModContent.ProjectileType<DestitutionProj>();
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
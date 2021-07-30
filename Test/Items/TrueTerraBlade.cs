using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Test.Items
{
	public class TrueTerraBlade : ModItem
	{
		public override void SetDefaults()
		{
			item.rare = 10;
			item.UseSound = SoundID.Item1;

			item.useStyle = 1;
			item.damage = 919596;
			item.useAnimation = 16;
			item.useTime = 14;
			item.width = 84;
			item.height = 84;
			item.shoot = 132;
			item.scale = 1.1f;
			item.shootSpeed = 15f;
			item.knockBack = 6.5f;
			item.melee = true;
			item.value = Item.sellPrice(0, 20, 0, 0);
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Terra Blade");
			Tooltip.SetDefault("'Insanity, Power, Terrarian!'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddIngredient(ItemID.DirtBlock, 25);
			recipe.AddIngredient(ItemID.CopperBar, 25);
			recipe.AddIngredient(ItemID.Diamond, 25);
			recipe.AddIngredient(ItemID.Ruby, 25);
			recipe.AddIngredient(ItemID.SoulofMight, 25);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

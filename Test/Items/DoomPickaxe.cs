using Terraria.ID;
using Terraria.ModLoader;

namespace Test.Items
{
	public class DoomPickaxe : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 500;
			item.melee = true;
			item.width = 42;
			item.height = 42;
			item.useTime = 1;
			item.useAnimation = 20;
			item.pick = 389;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 600;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.useTurn = true;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DoomPickaxe");
			Tooltip.SetDefault("");
		}

	}
}

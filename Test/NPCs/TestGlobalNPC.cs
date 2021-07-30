using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace test.NPCs
{
	public class TestGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity => true;

		public bool dFear;
		public bool Irradiated = false;

		public override void ResetEffects(NPC npc)
		{
			dFear = false;
		}

		public override void UpdateLifeRegen(NPC npc, ref int damage)
		{
			if (dFear)
			{
				if (npc.lifeRegen > 0)
					npc.lifeRegen = 0;

				npc.lifeRegen -= 50;
				if (damage < 50)
					damage = 50;
			}
		}

		public override void DrawEffects(NPC npc, ref Color drawColor)
		{
			if (dFear)
			{
				if (Main.rand.Next(4) < 3)
				{
					
					if (Main.rand.NextBool(4))
					{
						
					}
				}
				Lighting.AddLight(npc.position, 0.1f, 0.2f, 0.7f);
			}
		}
	}
}
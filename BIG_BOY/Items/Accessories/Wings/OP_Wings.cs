using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace BIG_BOY.Items.Accessories.Wings
{
	[AutoloadEquip(EquipType.Wings)]
	public class OP_Wings : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The God wings");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
			item.maxStack = 1;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 1000000000;
			player.moveSpeed += 100;
			player.accRunSpeed = 100f;
			player.maxRunSpeed = 10000;
			player.moveSpeed += 1000;
			player.breathCD = 0;
			player.dead = false;
			player.waterWalk = true;
			player.maxMinions += 10000000;

		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.10f;
			ascentWhenRising = 0.900f;
			maxCanAscendMultiplier = 90f;
			maxAscentMultiplier = 100f;
			constantAscend = 0.900f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 9f;
			acceleration *= 2.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 50);
			recipe.AddIngredient(ItemID.FragmentNebula, 50);
			recipe.AddIngredient(ItemID.FragmentVortex, 50);
			recipe.AddIngredient(ItemID.FragmentStardust, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;


namespace BIG_BOY.Items.Weapons
{
	public class BIG_ONE : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Little One"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is the basic little boy. I also fires up");
		}
		public override void SetDefaults() 
		{	
			item.value = Item.sellPrice(copper: 20);
            item.damage = 60;
			item.shoot = ProjectileID.Trident;
			item.shootSpeed = 8f;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 60;
			item.useAnimation = 20;
			item.knockBack = 10;
			item.rare = 2;
			item.crit = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 3);
			recipe.AddIngredient(ItemID.SilverOre, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
﻿using System;
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
    public class Apocolopse_bow : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(12, 24);
            item.rare = ItemRarityID.Purple;
            item.value = Item.sellPrice(silver: 22);

            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.UseSound = SoundID.Item5;

            item.autoReuse = true;
            item.noMelee = true;
            item.ranged = true;
            item.damage = 80;

            item.useAmmo = AmmoID.Arrow;
            item.shoot = ItemID.HellfireArrow;
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 20); // Uses either Iron or Lead Bars
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

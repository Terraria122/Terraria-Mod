using Terraria.ModLoader;
using Terraria.ID;

namespace Big_Boy.Items
{
    public class Phoenix_Feather : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phoenix Feather?");
            Tooltip.SetDefault("A Phoenix Feather?");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = 300;
            item.rare = 5;
            item.UseSound = SoundID.Item80;
            item.noMelee = true;
            item.mountType = mod.MountType("PhenioxMount");
        }
 
        
    }
}
using Terraria;
using Terraria.ModLoader;
 
namespace Big_Boy.Buffs
{
    public class PhoenixMountBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Phoenix");
            Description.SetDefault("The Legendry creature Of fire has come to your aid");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }
 
        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(mod.MountType("PhoenixMount"), player);
            player.buffTime[buffIndex] = 9999;
        }
    }
}
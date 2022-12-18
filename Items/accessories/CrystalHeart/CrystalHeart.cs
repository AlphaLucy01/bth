using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.ID;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using bth.Items.PHitems.bars;
using bth.Globals;
using bth.Buffs.Debuffs;

namespace bth.Items.accessories.CrystalHeart
{
    internal class CrystalHeart : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystal Heart");
            Tooltip.SetDefault("Saves you from dying once");
        }
        public override void SetDefaults()
        {
            Item.height = 30;
            Item.width = 30;
            Item.accessory = true;
        }
        public override void UpdateEquip(Player player)
        {

            player.GetModPlayer<GPlayer>().CrystalHeart = true;
            if (player.GetModPlayer<GPlayer>().died == true)
            {
                Item.TurnToAir();
            }
        }
    }
}

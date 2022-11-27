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
using bth.Items.bars;
using bth.Items.Blocks;

namespace bth.Items.PHitems.Ranged
{
    internal class PHbowsplit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("split bow");
        }
        public override void SetDefaults()
        {
            Item.height = 64;
            Item.width = 30;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.useAnimation = 8;
            Item.useTime = 8;
            Item.consumable = false;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 10;
            Item.shootSpeed = 15;
            
            Item.shoot = ModContent.ProjectileType<PHbulletsplit>();
        }
       
        public override void AddRecipes()
        {
            Recipe.Create(ModContent.ItemType<PHbow>())
                .AddIngredient<examplebar>(10)
                .AddTile(TileID.Anvils)
                .Register();
        }
        
        public override bool AltFunctionUse(Player player)
        {
            player.Heal(10);
            return false;
        }
    }
}

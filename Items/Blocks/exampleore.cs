using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using bth.Tiles;
using bth.Items.bars;

namespace bth.Items.Blocks
{
    internal class exampleore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Example ore");
        }
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.createTile = ModContent.TileType<exampletile>();
            Item.autoReuse = true;
            Item.consumable = true;
            Item.useAnimation = 10;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.maxStack = 999;
        }
        public override void AddRecipes()
        {
            Recipe.Create(ModContent.ItemType<examplebar>())
                .AddIngredient<exampleore>(4)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
}

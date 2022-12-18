using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using bth.Items.Blocks;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;

namespace bth.Tiles
{
    internal class CrystalGlassWall : ModWall
    {
        public override void SetStaticDefaults()
        {
            Main.tileMergeDirt[Type] = false;
            ModTranslation name = CreateMapEntryName();
            AddMapEntry(Color.DeepPink, name);
            name.SetDefault("");
        }
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            
            return true;
        }
    }
}

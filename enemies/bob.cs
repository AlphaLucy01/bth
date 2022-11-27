using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;

namespace bth.enemies
{
    internal class bob : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("bob");
        }
        public override void SetDefaults()
        {
            NPC.width = 76;
            NPC.height = 44;
            NPC.friendly = false;
            NPC.lifeMax = 100;
            NPC.aiStyle = 0;
            NPC.damage = 15;
        }
        public override void AI()
        {
            //
            NPC.TargetClosest(true);
            NPC.ai[0]++;
            if (NPC.life >= NPC.lifeMax) NPC.life = NPC.lifeMax;
            Player target = new Player();
            // normal ai
            if (NPC.ai[0] > 60)
            {
                NPC.ai[0] = 0;
                float dir = Vector2.Distance(NPC.position, target.position);
                NPC.rotation = dir;
                
            }
            //

        }
    }
}

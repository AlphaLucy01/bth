using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.ID;
using Terraria.DataStructures;



namespace bth.Items.PHitems
{
    internal class PHpickproj : ModProjectile
    {
        

        public override void SetDefaults()
        {
            Projectile.friendly = true;
            Projectile.width = 28;
            Projectile.height = 14;
            Projectile.aiStyle = 0;
            Projectile.timeLeft = 180;
            Projectile.penetrate = -1;
            Projectile.damage = 5;
            Projectile.tileCollide = true;
        }
        public override void AI()
        {
            
        }
        public override bool OnTileCollide(Vector2 velocityChange)  //On Contact do an action
        {
            //Nums for producing the radius of the effect, this setting should work for at least one tile to be destroyed
            int num101 = (int)(Projectile.position.X / 16f) - 2;
            int num102 = (int)((Projectile.position.X + (float)Projectile.width) / 16f) + 1;
            int num103 = (int)(Projectile.position.Y / 16f) - 2;
            int num104 = (int)((Projectile.position.Y + (float)Projectile.height) / 16f) + 1;
            if (num101 < 0)
            {
                num101 = 0;
            }
            if (num102 > Main.maxTilesX)
            {
                num102 = Main.maxTilesX;
            }
            if (num103 < 0)
            {
                num103 = 0;
            }
            if (num104 > Main.maxTilesY)
            {
                num104 = Main.maxTilesY;
            }

            //Searches at the radius
            for (int num105 = num101; num105 < num102; num105++)
            {
                for (int num106 = num103; num106 < num104; num106++)
                {
                    WorldGen.KillTile(num105, num106, false, false, false); //kills tiles
                }
            }
            return true; //Makes sure the projectile dies on tile collide.
        }
    }
    
}

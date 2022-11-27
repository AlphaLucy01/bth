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
using Terraria.Chat;
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
            Projectile.tileCollide = false;
        }
        public override void AI()
        {
            for(int i = Projectile.timeLeft; i > 0;)
            {
                
            }
        }
    }
    
}

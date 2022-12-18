using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using rail;

namespace bth.Items.PHitems.Melee
{
    internal class rape2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("rape");
        }
        public override void SetDefaults()
        {
            // essentials
            Item.height = 64;
            Item.width = 30;
            //use
            Item.damage = 10;
            Item.useAnimation = 25; // silahın kullanma animasyonu
            Item.useTime = 60; // projectile atma bekleme süresi
            Item.DamageType = DamageClass.Ranged;
            Item.autoReuse = true;
            //
            Item.noMelee = false; // sprite hasar vurmasını true ise kapıyo
            Item.consumable = false;
            Item.UseSound = SoundID.Item1;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.shootSpeed = 15;
            Item.shoot = ModContent.ProjectileType<soulswordproj>();
        }
    }
    public class RapeProj : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.arrow = true;
            Projectile.width = 15;
            Projectile.height = 15;
            Projectile.aiStyle = ProjAIStyleID.Arrow;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Ranged;
        }
    }
}

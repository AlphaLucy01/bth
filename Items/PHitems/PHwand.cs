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

namespace bth.Items.PHitems
{
    internal class PHwand : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("placeholder wand");
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

            Item.shoot = ModContent.ProjectileType<PHwandproj>();
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
            
            return false;
        }
    }
    internal class PHwandproj : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.friendly = true;
            Projectile.width = 26;
            Projectile.height = 26;
            Projectile.aiStyle = 0;
            Projectile.timeLeft = 180;
            Projectile.penetrate = -1;
            Projectile.DamageType = DamageClass.Ranged;
        }
        public override void OnSpawn(IEntitySource source)
        {
            Player player = new Player();
            Projectile.rotation = Vector2.Normalize(Main.MouseWorld - player.position).ToRotation();
        }
        public override void AI()
        {
            
        }
        
    }
}

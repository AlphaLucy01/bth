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

namespace bth.Items.PHitems.Magic
{
    internal class PHwand : ModItem
    {
        public int timesFired = 0;
        
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
            Item.DamageType = DamageClass.Magic;
            Item.damage = 10;
            Item.shootSpeed = 15;

            Item.shoot = ModContent.ProjectileType<PHwandproj>();
        }

        public override void AddRecipes()
        {
            Recipe.Create(ModContent.ItemType<PHwand>())
                .AddIngredient<examplebar>(10)
                .AddTile(TileID.Anvils)
                .Register();
        }
        Projectile projectil = new Projectile();// bunu yani
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(source, position, velocity, ModContent.ProjectileType<PHwandproj>(), damage, knockback, player.whoAmI);
            timesFired++;
            Main.NewText(timesFired);
            if(timesFired == 3)
            {
                projectil.Kill();
                //projectile.newprojectile variable olarak depola
                timesFired = 0;
                Projectile.NewProjectile(source, position, velocity, ModContent.ProjectileType<PHwandproj1>(), damage * 2, knockback,player.whoAmI);
            }
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
            Projectile.penetrate = 1;
            Projectile.DamageType = DamageClass.Ranged;
        }
        public override void OnSpawn(IEntitySource source)
        {

            
            //Main.NewText(wand.timesFired);
            Projectile.rotation = Projectile.Center.DirectionTo(Main.MouseWorld).ToRotation();
        }
        public override void AI()
        {

        }

    }
    internal class PHwandproj1 : ModProjectile
    {
        

        public int timesFired = 0;
        public override void SetDefaults()
        {
            Projectile.friendly = true;
            Projectile.width = 26;
            Projectile.height = 26;
            Projectile.aiStyle = 0;
            Projectile.timeLeft = 180;
            Projectile.penetrate = 1;
            Projectile.DamageType = DamageClass.Ranged;
        }
        public override void OnSpawn(IEntitySource source)
        {
            
            Projectile.rotation = Projectile.Center.DirectionTo(Main.MouseWorld).ToRotation();
        }
        
            

    }
}

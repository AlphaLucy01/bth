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
    internal class PHbow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("placeholder bow");
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
            Item.shoot = ModContent.ProjectileType<PHbullet>();
        }
        public int idamage
        {
            get { return Item.damage; }
            
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(source, position, velocity, ModContent.ProjectileType<PHbullet2>(), damage, knockback, Main.myPlayer, 0);
            return true;
        }
        public override void AddRecipes()
        {
            Recipe.Create(ModContent.ItemType<PHbow>())
                .AddIngredient<examplebar>(10)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace bth.Buffs.Debuffs
{
    internal class souldecay : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul Decay");
            Description.SetDefault("Your soul is slowly decaying");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = false;
            BuffID.Sets.LongerExpertDebuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<SoulDecayDebuff>().lifeRegenDebuff = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<effectednpc>().lifeRegenDebuff = true;
        }
    }
    public class SoulDecayDebuff : ModPlayer
    {
        public bool lifeRegenDebuff;

        public override void ResetEffects()
        {
            lifeRegenDebuff = false;
        }
        public override void UpdateBadLifeRegen()
        {
            if (lifeRegenDebuff)
            {
                if (Player.lifeRegen > 0)
                    Player.lifeRegen = 0;
                Player.lifeRegenTime = 0;
                Player.lifeRegen -= 10;
            }
        }
    }
    public class effectednpc : GlobalNPC
    {
        public bool lifeRegenDebuff;
        public override bool InstancePerEntity => true;

        public override void ResetEffects(NPC npc)
        {
            lifeRegenDebuff = false;
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (lifeRegenDebuff)
            {
                if (npc.lifeRegen > 0)
                    npc.lifeRegen = 0;
                npc.lifeRegen -= 16;
            }
        }
    }
}

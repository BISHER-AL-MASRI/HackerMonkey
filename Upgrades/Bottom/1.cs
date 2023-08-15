using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;

namespace HackerMonkey.Upgrades.BottomPath
{
    public class u1 : ModUpgrade<HackerMonkeyMod>
    {
        public override int Path => BOTTOM;
        public override int Tier => 3;
        public override int Cost => 1600;

        public override string DisplayName => "1";

        public override string Description => "Makes the monkey attack Faster";

        public override string Portrait => "HackerMonkey-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.range += 15;
            tower.GetAttackModel().range += 15;
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.Rate *= .5f;
            }
        }
    }
}
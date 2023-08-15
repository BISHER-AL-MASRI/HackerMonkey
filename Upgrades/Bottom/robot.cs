using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;

namespace HackerMonkey.Upgrades.BottomPath
{
    public class robot : ModUpgrade<HackerMonkeyMod>
    {
        public override int Path => BOTTOM;
        public override int Tier => 4;
        public override int Cost => 2250;

        public override string DisplayName => "01";
        public override string Description => "Final update";

        public override string Portrait => "HackerMonkey-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.projectile.pierce += 30;
                tower.range += 10;
                tower.GetAttackModel().range += 10;
            }
        }
    }
}
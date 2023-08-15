using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;

namespace HackerMonkey.Upgrades.BottomPath
{
    public class Tech : ModUpgrade<HackerMonkeyMod>
    {
        public override int Path => BOTTOM;
        public override int Tier => 1;
        public override int Cost => 300;

        public override string DisplayName => "Tech";

        public override string Description => "Makes the monkey attack Faster";

        public override string Portrait => "HackerMonkey-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            foreach (var weaponModel in tower.GetWeapons())
            {
                weaponModel.Rate *= .666666f;
            }
        }
    }
}
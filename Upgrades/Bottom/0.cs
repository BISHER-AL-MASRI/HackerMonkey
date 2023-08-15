using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers.Filters;


namespace HackerMonkey.Upgrades.BottomPath
{
    public class u0 : ModUpgrade<HackerMonkeyMod>
    {
        public override int Path => BOTTOM;
        public override int Tier => 2;
        public override int Cost => 600;

        public override string DisplayName => "0";

        public override string Description => "Hacker Monkey is able to pop camo";

        public override string Portrait => "HackerMonkey-Portrait";

        public override void ApplyUpgrade(TowerModel tower)
        {
            tower.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }
    }
}
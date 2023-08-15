using System.Collections.Generic;
using System.Linq;
using BTD_Mod_Helper;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using HackerMonkey.Displays.Projectiles;

namespace HackerMonkey
{

    public class HackerMonkeyMod : ModTower
    {

        public override TowerSet TowerSet => TowerSet.Support;

        public override string BaseTower => TowerType.DartMonkey;
        public override int Cost => 400;

        public override int TopPathUpgrades => 5;
        public override int MiddlePathUpgrades => 5;
        public override int BottomPathUpgrades => 5;
        public override string Description => "A hacking monkey";

        // public override string DisplayName => "Don't need to override this, the default turns it into 'Hacker Monkey'"

        public override ParagonMode ParagonMode => ParagonMode.Base555;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.range += 10;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 10;

            var projectile = attackModel.weapons[0].projectile;
            projectile.ApplyDisplay<laptop>(); // Make the projectiles look like Hackers
            projectile.pierce += 2;
        }


        public override int GetTowerIndex(List<TowerDetailsModel> towerSet)
        {
            return towerSet.First(model => model.towerId == TowerType.Benjamin).towerIndex + 1;
        }


        public override bool IsValidCrosspath(int[] tiers) =>
            ModHelper.HasMod("UltimateCrosspathing") || base.IsValidCrosspath(tiers);
    }
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarksClothes.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class BobHelmet : ModItem
    {
       public override void SetDefaults()
        {
            Item.value = 2000;
            Item.rare = ItemRarityID.Pink; 
            base.SetDefaults();
        }
        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Melee) += 0.05f;
            base.UpdateEquip(player);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 20)
                .AddTile(TileID.Anvils)
                .Register();
            base.AddRecipes();
        }
    }
}

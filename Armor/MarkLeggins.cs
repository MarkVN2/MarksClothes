using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

// Has no Sprites yet, but it's a good example of how to make leggins  
namespace MarksClothes.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class MarkLeggins : ModItem
    {
        public override void SetDefaults()
        {
            Item.value = 2000;
            Item.rare = ItemRarityID.Pink;

        }
        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Melee) += 0.1f;
            base.UpdateEquip(player);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            base.Register();
        }
    }
}

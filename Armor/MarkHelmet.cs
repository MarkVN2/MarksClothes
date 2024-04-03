using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

// Has no Sprites yet, but it's a good example of how to make a helmet
namespace MarksClothes.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MarkHelmet : ModItem
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
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "You are Mark, you look old..";
        }   
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<MarkChest>() && legs.type == ModContent.ItemType<MarkLeggins>();
        }
    }
}

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MarksClothes.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class BobChestplate : ModItem // It's more of a Bob's Robe but i am not bothering to change it for now
    {
        public override void Load()
        {
            EquipLoader.AddEquipTexture(Mod, $"{Texture}_{EquipType.Legs}", EquipType.Legs, this);
            base.Load();
        }
        public override void SetDefaults()
        {
            Item.value = 2000;
            Item.rare = ItemRarityID.Pink;
            base.SetDefaults();
        }
        public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
        {
            robes = true;
            base.SetMatch(male, ref equipSlot, ref robes);
            equipSlot = EquipLoader.GetEquipSlot(Mod, Name, EquipType.Legs);
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

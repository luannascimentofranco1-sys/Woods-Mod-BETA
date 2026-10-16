using Engine;
using Engine.Graphics;

namespace Game {
    // Texturas: atlas 6x6 (slot = linha*6 + coluna) e atlas de troncos 2x2.
    public static class WoodTex {
        public const int AtlasSlots = 6;
        public const int LogSlots = 2;
        static Texture2D s_atlas, s_logs;
        public static Texture2D Atlas => s_atlas ??= ContentManager.Get<Texture2D>("Textures/CherryAcaciaWoods");
        public static Texture2D Logs => s_logs ??= ContentManager.Get<Texture2D>("Textures/CherryAcaciaLogs");
    }

    public class CherryWoodBlock : OakWoodBlock {
        // Reaproveita a lógica de eixo do tronco de carvalho; só troca os slots (lado/topo).
        public override int GetFaceTextureSlot(int face, int value) {
            int oakIndex = BlocksManager.GetBlockIndex<OakWoodBlock>();
            int oakTop = base.GetFaceTextureSlot(4, Terrain.MakeBlockValue(oakIndex, 0, 0));
            return base.GetFaceTextureSlot(face, value) == oakTop ? 1 : 0;
        }
        public override int GetTextureSlotCount(int value) => WoodTex.LogSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Logs;
    }

    public class CherryPlanksBlock : PlanksBlock {
        public override int GetFaceTextureSlot(int face, int value) => 22;
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherryStairsBlock : WoodenStairsBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherrySlabBlock : WoodenSlabBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherryDoorBlock : WoodenDoorBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherryTrapdoorBlock : WoodenTrapdoorBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherryFenceBlock : WoodenFenceBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherryFenceGateBlock : WoodenFenceGateBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherryPostedSignBlock : WoodenPostedSignBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherryAttachedSignBlock : WoodenAttachedSignBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherryPressurePlateBlock : PressurePlateBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class CherryWireThroughPlanksBlock : WireThroughPlanksBlock {
        public override int GetFaceTextureSlot(int face, int value) => 34;
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaWoodBlock : OakWoodBlock {
        // Reaproveita a lógica de eixo do tronco de carvalho; só troca os slots (lado/topo).
        public override int GetFaceTextureSlot(int face, int value) {
            int oakIndex = BlocksManager.GetBlockIndex<OakWoodBlock>();
            int oakTop = base.GetFaceTextureSlot(4, Terrain.MakeBlockValue(oakIndex, 0, 0));
            return base.GetFaceTextureSlot(face, value) == oakTop ? 3 : 2;
        }
        public override int GetTextureSlotCount(int value) => WoodTex.LogSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Logs;
    }

    public class AcaciaPlanksBlock : PlanksBlock {
        public override int GetFaceTextureSlot(int face, int value) => 23;
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaStairsBlock : WoodenStairsBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaSlabBlock : WoodenSlabBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaDoorBlock : WoodenDoorBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaTrapdoorBlock : WoodenTrapdoorBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaFenceBlock : WoodenFenceBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaFenceGateBlock : WoodenFenceGateBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaPostedSignBlock : WoodenPostedSignBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaAttachedSignBlock : WoodenAttachedSignBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaPressurePlateBlock : PressurePlateBlock {
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

    public class AcaciaWireThroughPlanksBlock : WireThroughPlanksBlock {
        public override int GetFaceTextureSlot(int face, int value) => 35;
        public override int GetTextureSlotCount(int value) => WoodTex.AtlasSlots;
        public override Texture2D GetDefaultTexture(int value) => WoodTex.Atlas;
    }

}
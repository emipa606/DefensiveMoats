using Verse;

namespace DefensiveMoats
{
    public class Building_MoatBridge : Building
    {
        private Building_Moat moat;


        public override void SpawnSetup(Map map, bool respawningAfterLoad)
        {
            base.SpawnSetup(map, respawningAfterLoad);
            moat = (Building_Moat)Map.thingGrid.ThingAt(Position, MoatThingDefOf.Moat);
            moat.Destroy();
        }

        public override void DeSpawn(DestroyMode mode = DestroyMode.Vanish)
        {
            var map = Map;
            base.DeSpawn(mode);
            var newThing = ThingMaker.MakeThing(MoatThingDefOf.Moat);
            GenPlace.TryPlaceThing(newThing, Position, map, ThingPlaceMode.Direct);
        }
    }
}
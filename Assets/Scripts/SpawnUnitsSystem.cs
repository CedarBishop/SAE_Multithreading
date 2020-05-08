using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class SpawnUnitsSystem : ComponentSystem
{


    private Unity.Mathematics.Random random;
    private int gridWidth;
    private int gridHeight;

    private bool firstUpdate = true;

    protected override void OnUpdate() 
    {
        if (firstUpdate) 
        {
            firstUpdate = false;
            
            random = new Unity.Mathematics.Random(56);

            Grid<GridNode> pathfindingGrid = PathfindingGridSetup.Instance.pathfindingGrid;
            gridWidth = pathfindingGrid.GetWidth();
            gridHeight = pathfindingGrid.GetHeight();

            SpawnUnits(0);
        }

        if (Input.GetKeyDown(KeyCode.W)) 
        {
            SpawnUnits(1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnUnits(10);
        }
    }

    public void SpawnUnits(int spawnCount) 
    {
        PrefabEntityComponent prefabEntityComponent = GetSingleton<PrefabEntityComponent>();
        CanvasManager.instance.IncrementSpawnText(spawnCount);
        for (int i = 0; i < spawnCount; i++) 
        {
            Entity spawnedEntity = EntityManager.Instantiate(prefabEntityComponent.prefabEntity);
            EntityManager.SetComponentData(spawnedEntity, new Translation { Value = new float3(0, 0, 0) });
        }
    }

}

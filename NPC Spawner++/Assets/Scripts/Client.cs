using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    public void Update()
    {
        if (m_SpawnerNPC.numVillagers < 6)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                m_SpawnerNPC.SpawnKnight();
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                m_SpawnerNPC.SpawnGnome();
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                m_SpawnerNPC.SpawnWizard();
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                m_SpawnerNPC.SpawnFarmer();
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                m_SpawnerNPC.SpawnBeggar();
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                m_SpawnerNPC.SpawnShopkeeper();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_SpawnerNPC.SpawnVillagers();
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_SpawnerNPC.delete();
        }
    }
}
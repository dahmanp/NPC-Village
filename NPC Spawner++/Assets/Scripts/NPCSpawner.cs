using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    private INPC m_Gnome;
    private INPC m_Wizard;
    private INPC m_Knight;

    public Image[] villagers;
    public Sprite[] villagerImages;
    public Sprite defaultSprite;
    public TMP_Text[] dialogue;

    public int numVillagers;

    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        m_Gnome = m_Factory.GetNPC(NPCType.Gnome);
        m_Wizard = m_Factory.GetNPC(NPCType.Wizard);
        m_Knight = m_Factory.GetNPC(NPCType.Knight);

        dialogue[1].text = m_Beggar.Speak();
        dialogue[0].text = m_Farmer.Speak();
        dialogue[2].text = m_Shopowner.Speak();
        dialogue[3].text = m_Gnome.Speak();
        dialogue[4].text = m_Wizard.Speak();
        dialogue[5].text = m_Knight.Speak();

        for (int i = 0; i < 6; i++)
        {
            villagers[i].sprite = villagerImages[i];
            numVillagers++;
        }
    }

    public void delete()
    {
        for (int i = 0; i < numVillagers; i++)
        {
            villagers[i].sprite = defaultSprite;
            dialogue[i].text = " ";
        }
        numVillagers = 0;
    }

    public void SpawnFarmer()
    {
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        dialogue[numVillagers].text = m_Farmer.Speak();
        numVillagers++;
        villagers[numVillagers - 1].sprite = villagerImages[0];
    }
    public void SpawnBeggar()
    {
        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        dialogue[numVillagers].text = m_Beggar.Speak();
        numVillagers++;
        villagers[numVillagers - 1].sprite = villagerImages[1];
    }
    public void SpawnShopkeeper()
    {
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        dialogue[numVillagers].text = m_Shopowner.Speak();
        numVillagers++;
        villagers[numVillagers - 1].sprite = villagerImages[2];
    }
    public void SpawnGnome()
    {
        m_Gnome = m_Factory.GetNPC(NPCType.Gnome);
        dialogue[numVillagers].text = m_Gnome.Speak();
        numVillagers++;
        villagers[numVillagers - 1].sprite = villagerImages[3];
    }
    public void SpawnWizard()
    {
        m_Wizard = m_Factory.GetNPC(NPCType.Wizard);
        dialogue[numVillagers].text = m_Wizard.Speak();
        numVillagers++;
        villagers[numVillagers - 1].sprite = villagerImages[4];
    }
    public void SpawnKnight()
    {
        m_Knight = m_Factory.GetNPC(NPCType.Knight);
        dialogue[numVillagers].text = m_Knight.Speak();
        numVillagers++;
        villagers[numVillagers - 1].sprite = villagerImages[5];
    }
}

using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public INPC GetNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCType.Shopowner:
                INPC shopowner = new Shopowner();
                return shopowner;
            case NPCType.Gnome:
                INPC gnome = new Gnome();
                return gnome;
            case NPCType.Knight:
                INPC knight = new Knight();
                return knight;
            case NPCType.Wizard:
                INPC wizard = new Wizard();
                return wizard;
        }
        return null;
    }
}
using UnityEngine;

public class Beggar : INPC
{
    public string[] text;

    public string Speak()
    {
        text = new string[]
        {
            "Beggar: Do you have some change to spare?",
            "Beggar: You look like you have some extra funds...",
            "Beggar: My child is starving, please give us food!"
        };
        int i = Random.Range(0, text.Length);
        return text[i];
    }
}

using UnityEngine;

public class Shopowner : INPC
{
    public string[] text;

    public string Speak()
    {
        text = new string[]
        {
            "Shopowner: Do you wish to purchase something?",
            "Shopowner: Fresh goods for sale! Only the best for you!",
            "Shopowner: I think I burnt my water."
        };
        int i = Random.Range(0, text.Length);
        return text[i];
    }
}

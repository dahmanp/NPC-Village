using UnityEngine;

public class Knight : INPC
{
    public string[] text;

    public string Speak()
    {
        text = new string[]
        {
            "Knight: Those blasted gnomes! Join the Knights in the great war!",
            "Knight: For the king!",
            "Knight: I cant really breathe in this suit..."
        };
        int i = Random.Range(0, text.Length);
        return text[i];
    }
}

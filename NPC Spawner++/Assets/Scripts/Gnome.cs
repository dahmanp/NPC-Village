using UnityEngine;

public class Gnome : INPC
{
    public string[] text;

    public string Speak()
    {
        text = new string[]
        {
            "Gnome: Fear the knights! Join the Gnomes in the great war!",
            "Gnome: *gnome sounds*",
            "Gnome: Teehee!"
        };
        int i = Random.Range(0, text.Length);
        return text[i];
    }
}

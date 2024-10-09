using UnityEngine;

public class Wizard : INPC
{
    public string[] text;

    public string Speak()
    {
        text = new string[]
        {
            "Wizard: I cast fireball!",
            "Wizard: I am feeling silly today!",
            "Wizard: I cast procrastination!"
        };
        int i = Random.Range(0, text.Length);
        return text[i];
    }
}

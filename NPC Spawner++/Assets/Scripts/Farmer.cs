using UnityEngine;

public class Farmer : INPC
{
    public string[] text;

    public string Speak()
    {
        text = new string[]
        {
            "Farmer: You reap what you sow!",
            "Farmer: Nothing beats a long day of hard work.",
            "Farmer: Anyone know where my sheep went?"
        };
        int i = Random.Range(0, text.Length);
        return text[i];
    }
}

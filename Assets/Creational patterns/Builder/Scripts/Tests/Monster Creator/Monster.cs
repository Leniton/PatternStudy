using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.Builder;

public class Monster 
{
    List<string> listPerks = new();

    public void AddPerk(string perk)
    {
        listPerks.Add(perk);
    }

    public void ListParts()
    {
        string result = string.Empty;

        for (int i = 0; i < listPerks.Count; i++)
        {
            result += $"{listPerks[i]}\n";
        }

        Debug.Log(result);
    }
}

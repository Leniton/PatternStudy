using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Creational.Builder;

public class MonsterBuilder : IBuilder
{
    Monster monster = new();

    public MonsterBuilder()
    {
        Reset();
    }

    void Reset()
    {
        monster = new();
    }

    public void StepA()
    {
        monster.AddPerk("Extra speed");
    }

    public void StepB()
    {
        monster.AddPerk("Powerful attack");
    }

    public void StepC()
    {
        monster.AddPerk("Extra defense");
    }

    public Monster GetProduct()
    {
        Monster result = monster;

        //optional
        Reset();

        return result;
    }
}

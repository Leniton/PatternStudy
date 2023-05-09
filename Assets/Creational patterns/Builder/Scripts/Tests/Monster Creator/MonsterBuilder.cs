using UnityEngine;

namespace Patterns.Creational.Builder.Tests
{
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
            monster.hp = 20;
        }

        public void StepB()
        {
            monster.atk = 8;
        }

        public void StepC()
        {
            monster.def = 5;
        }

        public Monster GetProduct()
        {
            Monster result = monster;

            //optional
            Reset();

            Debug.Log($"Monster status:\nHP:{result.hp}\nATK:{result.atk}\nDEF:{result.def}");

            return result;
        }
    }
}
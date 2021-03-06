﻿namespace Puppetry.Puppeteer.Conditions.GameObject
{
    internal class Present : Condition
    {
        public override bool Invoke<T>(T gameObject)
        {
            CurentGameObject = gameObject;

            return gameObject.Exists;
        }

        protected override string DescribeExpected()
        {
            return $"Present {true}";
        }

        protected override string DescribeActual()
        {
            return $"Present {false}";
        }
    }

    public static partial class Be
    {
        public static Condition Present => new Present();
    }
}
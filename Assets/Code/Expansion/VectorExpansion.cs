using UnityEngine;

namespace Code.Expansion
{
    public static class VectorExpansion
    {
        public static Vector2[] ToVector2(this Transform[] _transforms)
        {
            Vector2[] vectors2 = new Vector2[_transforms.Length];

            for (int i = 0; i < _transforms.Length; i++)
            {
                vectors2[i] = _transforms[i].position;
            }
            
            return vectors2;
        }
    }
}
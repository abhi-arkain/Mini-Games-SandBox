#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Arkain.MiniGameSanbox.Editor
{
    public static class CoinFlipSimulation
    {
        [MenuItem("Tools/Simulate/1000 Coin Flips")]
        
        public static void StartCoinFlip()
        {
            const int flipCount = 1000;
            int heads = 0;
            int tails = 0;

            System.Random rng = new System.Random();
            
            for (int i = 0; i < flipCount; i++)
            {
                if (rng.Next(0, 2) == 0)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }

            Debug.Log($"Simulated {flipCount} coin flips.\nHeads: {heads}\nTails: {tails}");
        }
    }
}
#endif
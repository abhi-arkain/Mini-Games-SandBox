#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Arkain.MiniGameSanbox.Editor
{
    public static class CoinFlipSimulation
    {
        // Adds a custom Unity menu item:
        // Unity's top menu bar -> Tools -> Simulate -> 1000 Coin Flips
        // Clicking it will execute the Run() method below.
        [MenuItem("Tools/Simulate/1000 Coin Flips")]
        
        public static void StartCoinFlip()
        {
            const int flipCount = 1000;                                   // Total number of simulated flips
            int heads = 0;                                                // Counter for heads
            int tails = 0;                                                // Counter for tails

            System.Random rng = new System.Random();                      // Random number generator
            
            // Main iterating loop
            for (int i = 0; i < flipCount; i++)
            {
                // rng.Next(0, 2) returns either 0 or 1
                // 0 -> tails , 1 -> heads
                if (rng.Next(0, 2) == 0)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }

            Debug.Log($"Simulated {flipCount} coin flips.\nHeads: {heads}  Tails: {tails}");                    // Prints the results in Console
        }
    }
}
#endif
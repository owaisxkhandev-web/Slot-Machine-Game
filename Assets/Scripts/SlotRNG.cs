using UnityEngine;

public class SlotGenerator : MonoBehaviour
{
    public int[] Generator() // Generates a random result for the Slot Machine based on the defined probabilities for each symbol.
    {
        return new int[]
        {
            GenerateSymbol(),
            GenerateSymbol(),
            GenerateSymbol()

            // 0 - Cherry
            // 1 - Seven 
            // 2 - Bar
            // 3 - Bell
        };
    }
    private int GenerateSymbol() // Generates a random symbol based on the defined probabilities for each symbol.
    {
        int roll = Random.Range(0, 100);

        if (roll < 40) return 1; // Seven (40%)

        if (roll < 65) return 0; // Cherry (25%)

        if (roll < 85) return 2; // Bar (20%)

        return 3; // Bell (15%)
    }
}

using UnityEngine;

public class SlotGenerator : MonoBehaviour
{
    private int[] Slot;


    public int[] Generator()
    {
        return new int[]
        {
            Random.Range(0, 4),
            Random.Range(0, 4),
            Random.Range(0, 4)

            // 0 - Cherry
            // 1 - Seven 
            // 2 - Bar
            // 3 - Bell
        };
    }
}

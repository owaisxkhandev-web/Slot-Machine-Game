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

            // 0 - Bell 
            // 1 - Cherry
            // 2 - Seven 
            // 3 - Bar
        };
    }

    private void Update()
    {
        Slot = Generator();

        Debug.Log($"Slot 1: {Slot[0]}, Slot 2: {Slot[1]}, Slot 3: {Slot[2]}");
    }
}

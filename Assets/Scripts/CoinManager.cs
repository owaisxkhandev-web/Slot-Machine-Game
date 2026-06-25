using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int MaxCoin = 100;

    public int CurrentCoin { get; private set; }


    private void Awake()
    {
        CurrentCoin = MaxCoin;
    }

    public bool CanSpin(int amount)
    {
        if (CurrentCoin < amount)
        {
            return false;
        }
        else
        {
            CurrentCoin -= amount;
            return true;
        }
    }
    public void AddAmount(int WinAmount)
    {
        CurrentCoin += WinAmount;
    }
}

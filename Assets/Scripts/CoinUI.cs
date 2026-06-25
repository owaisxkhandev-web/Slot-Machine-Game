using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private CoinManager CoinManager;
    [SerializeField] private TMP_Text CoinText;

    private void Update()
    {
        CoinText.text = CoinManager.CurrentCoin.ToString();
    }
}

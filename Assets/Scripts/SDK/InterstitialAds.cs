using UnityEngine;

public class InterstitialAds : MonoBehaviour
{
    public void Show()
    {
        Agava.YandexGames.InterstitialAd.Show(OnOpenCallback, OnCloseCallback);
    }

    private void OnOpenCallback()
    {
        Time.timeScale = 0;
        AudioListener.volume = 0f;
    }
    private void OnCloseCallback(bool wasShow)
    {
        Time.timeScale = 1;
        AudioListener.volume = 1f;
    }
}

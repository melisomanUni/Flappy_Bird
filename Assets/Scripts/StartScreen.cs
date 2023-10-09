using UnityEngine.Events;

public class StartScreen : ScreenObserver
{
    public event UnityAction PlayButtonClick;
    
    protected override void OnButtonClick()
    {
        PlayButtonClick?.Invoke();
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
    }

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
    }
}

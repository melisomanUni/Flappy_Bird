using UnityEngine.Events;

public class EndGameScreen : Window
{
    public event UnityAction RestartButtonClicked;
    
    protected override void OnButtonClick()
    {
        RestartButtonClicked?.Invoke();
    }

    public override void Open()
    {
        WindowGroup.alpha = 1;
        ActionButton.interactable = true;
    }

    public override void Close()
    {
        WindowGroup.alpha = 0;
        ActionButton.interactable = false;
    }
}

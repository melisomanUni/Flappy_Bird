using System;

public class StartScreen : Window
{
    public event Action PlayButtonClicked;
    
    protected override void OnButtonClick()
    {
        PlayButtonClicked?.Invoke();
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

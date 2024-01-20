namespace AbstractFactory.AbstractProducts;

public interface IButton
{
    void Render();
    void OnClick(string eventName);
}

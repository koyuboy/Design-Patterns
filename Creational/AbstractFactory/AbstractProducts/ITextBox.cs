namespace AbstractFactory.AbstractProducts;

public interface ITextBox
{
    void Render();
    void OnChange(string text);
}


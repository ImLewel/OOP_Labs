namespace lab4
{
  class MyToolStrip
  {
    public Form currentForm;
    public void Button(string text)
    {
      currentForm = Form.ActiveForm;
      this.currentForm.Text = text;
    }
  }
}

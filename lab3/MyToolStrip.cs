

namespace lab3
{
  class MyToolStrip
  {
    public Form currentForm;

    public void Dot(ShapeObjectsEditor shapeObjectsEditor)
    {
      currentForm = Form.ActiveForm;
      this.currentForm.Text = "Крапка";
      shapeObjectsEditor.DotEditor();
    }

    public void Line(ShapeObjectsEditor shapeObjectsEditor)
    {
      currentForm = Form.ActiveForm;
      currentForm.Text = "Лінія";
      shapeObjectsEditor.LineEditor();
    }

    public void Rectangle(ShapeObjectsEditor shapeObjectsEditor)
    {
      currentForm = Form.ActiveForm;
      currentForm.Text = "Прямокутник";
      shapeObjectsEditor.RectangleEditor();
    }

    public void Elipse(ShapeObjectsEditor shapeObjectsEditor)
    {
      currentForm = Form.ActiveForm;
      currentForm.Text = "Еліпс";
      shapeObjectsEditor.ElipseEditor();
    }
  }
}

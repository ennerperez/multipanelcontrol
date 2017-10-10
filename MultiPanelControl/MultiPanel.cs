using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;

[ToolboxBitmap(typeof(MultiPanel), "MultiPanel")]
[Designer(typeof(Design.MultiPanelDesigner))]
public class MultiPanel : Panel
{
    public MultiPanelPage SelectedPage
    {
        get { return _selectedPage; }
        set
        {
            _selectedPage = value;
            if (_selectedPage != null)
            {
                foreach (Control child in Controls)
                {
                    if (object.ReferenceEquals(child, _selectedPage))
                        child.Visible = true;
                    else
                        child.Visible = false;
                }
                OnSelectedPanelChanged(EventArgs.Empty);
            }
        }
    }

    protected virtual void OnSelectedPanelChanged(EventArgs e)
    {
        SelectedPanelChanged?.Invoke(this, e);
    }

    public EventHandler SelectedPanelChanged;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;

        using (SolidBrush br = new SolidBrush(BackColor))
            g.FillRectangle(br, ClientRectangle);
    }

    protected override ControlCollection CreateControlsInstance()
    {
        return new MultiPanelPagesCollection(this);
    }

    private MultiPanelPage _selectedPage;
}

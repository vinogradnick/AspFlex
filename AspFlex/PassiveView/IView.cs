using System.Windows.Forms;

namespace AspFlex.PassiveView
{
    public interface IView
    {
        DialogResult ShowDialog();
        void Show();
        void Hide();


    }

    
}
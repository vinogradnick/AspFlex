namespace AspFlex.PassiveView
{
    public interface IRequestPage:IView
    {
        void Bind(dynamic dataSource);
        object SelectedObject { get; set; }
    }
}
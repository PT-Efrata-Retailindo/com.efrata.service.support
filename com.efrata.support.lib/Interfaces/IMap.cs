namespace com.efrata.support.lib.Interfaces
{
    public interface IMap<TModel, TViewModel>
    {
        TViewModel MapToViewModel(TModel model);
        TModel MapToModel(TViewModel viewModel);
    }
}
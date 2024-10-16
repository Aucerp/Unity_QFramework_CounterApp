using UnityEngine;

namespace QFramework.Example8
{
    public interface ICounterModel : IModel
    {
        BindableProperty<int> Count { get; }
    }
    public class CounterAppModel : AbstractModel, ICounterModel
    {
        public BindableProperty<int> Count { get; } = new BindableProperty<int>(0);
        protected override void OnInit()
        {
            var storage = this.GetUtility<IStorage>();

            Count.Value = storage.LoadInt( nameof( Count ), 0 );

            Count.Register( count =>
            {
                storage.SaveInt( nameof( Count ), count );
            } );
        }
    }
}

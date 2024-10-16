using UnityEngine;

namespace QFramework.Example7
{
    public class CounterAppModel : AbstractModel
    {
        public BindableProperty<int> Count = new BindableProperty<int>(0);
        protected override void OnInit()
        {
            var storage = this.GetUtility<Storage>();

            Count.Value = storage.LoadInt( nameof( Count ) );

            // 原本通过 CounterApp.Interface 监听数据变更事件，用了BindableProperty 可以直接.Register
            //CounterApp.Interface.RegisterEvent<CountChangeEvent>( e =>
            Count.Register( count =>
            {
                storage.SaveInt( nameof( Count ), count );
            } );
        }
    }
}

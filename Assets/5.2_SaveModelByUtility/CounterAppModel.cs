using UnityEngine;

namespace QFramework.Example5_2
{
    public class CounterAppModel : AbstractModel
    {
        private int mCount = 0;

        public int Count
        {
            get => mCount;
            set
            {
                if ( mCount != value )
                {
                    mCount = value;
                    PlayerPrefs.SetInt( nameof( Count ), value );
                }
            }
        }
        protected override void OnInit()
        {
            var storage = this.GetUtility<Storage>();

            Count = storage.LoadInt( nameof( Count ) );

            // 可以通过 CounterApp.Interface 监听数据变更事件
            CounterApp.Interface.RegisterEvent<CountChangeEvent>( e =>
            {
                this.GetUtility<Storage>().SaveInt( nameof( Count ), Count );
            } );
        }
    }
}

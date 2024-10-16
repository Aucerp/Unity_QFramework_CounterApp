namespace QFramework.Example7
{
    public class DecreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<CounterAppModel>().Count.Value--;
            //this.SendEvent<CountChangeEvent>(); // ++
            //使用了BindableProperty 就不需要CountChangeEvent 因為直接RigisterModel
        }
    }
}